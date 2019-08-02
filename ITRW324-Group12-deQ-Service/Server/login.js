//mySQL root pass: deQ@123456
module.exports = function(req, res, con, jwt) {

    var valU = req.body.email;
    var valP = req.body.password;
    var sqlquery = "SELECT * FROM users WHERE email = ? AND password = ?";
    console.log('Login attempt: '+JSON.stringify(req.body));

    // create Request object
    //********************************************************
    //var request = new sql.Request();

    con.getConnection(function(err, connection){
        if (err) {
          connection.release();
          res.json({"code" : 100, "status" : "Error in connection database"});
          return;
        }
        var identififyUserType = valU.split(".");
        if(identififyUserType[0] == "com")
        {
            var sql2 = "SELECT * FROM service WHERE Email = ?"
            connection.query(sql2, valU, function(err, resul) {
                if (resul[0] == undefined) {
                    console.log('Incorrect login');
                    res.redirect('/');
                    return;
                }
                const company = { servName:resul[0].ServiceName,
                    servID:resul[0].ServiceId,
                    user:valU,
                    servTellers:resul[0].NoOfTellers,
                    servBranch:resul[0].BranchName,
                    servLoc:resul[0].Location,
                    servCity:resul[0].City,
                    servDaysOpen:resul[0].DaysOpen,
                    servOpen:resul[0].OpenTime,
                    servClosed:resul[0].CloseTime
                }
                console.log(company);
                if (req.body.password == resul[0].Password) {
                    const token = jwt.sign({ company }, 'lets_allow_them_in_deqisgreat');
                    res.cookie('auth', token);
                    res.redirect('/company');
                    console.log('Company redirect done\n****************\n******************\n');
                    return;
                }
                else {res.json({'result':'Details incorrect!'}); return;}
            });
        } else {
            connection.query(sqlquery, [valU, valP], function (err, result) {
                if(err){res.json(err);}
                else if(result[0] == undefined)
                /* res.json({
                    login: "Email or password incorrect.",
                    email: valU
                });*/
                res.redirect('/');
                else{
                    if(identififyUserType[0] == "adm")
                    {
                        res.redirect('/admin');
                    }
                    else
                    {
                        const user = { name: result[0].FName,
                            surname: result[0].LName,
                            email: result[0].Email,
                            id: result[0].UserId,
                            said: result[0].IdNum,
                            tel: result[0].Tel,
                            address1: result[0].Address1,
                            address2: result[0].Address2,
                            address3: result[0].Address3,
                            postal: result[0].Postal
                        };
                        console.log(user);
                        const token = jwt.sign({ user }, 'lets_allow_them_in_deqisgreat');
                        //console.log(req.headers['accept']);
                        if (~req.headers['user-agent'].indexOf('dart:io')) {
                            console.log("LOGIN\nTHIS IS THE APP\n\n");
                            res.json({//return values
                                login: 'success',
                                token: token,
                                user: user
                            });
                            console.log("app token: "+token);
                            return;
                        } else {
                            console.log("LOGIN\nTHIS IS THE WEBSITE\n\n");
                            res.cookie('auth', token);
                            res.redirect('/profile');
                            return;
                        }
                    }
                }
            });
        }
    });
}