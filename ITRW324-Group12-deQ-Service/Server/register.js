module.exports = function(req, res, con, jwt){
    console.log("REGISTER\n\n"+req.headers['content-type']+"\n\n");
    var sql = 'INSERT INTO USERS (FNAME, LNAME, EMAIL, PASSWORD, IDNUM, TEL, ADDRESS1, ADDRESS2, ADDRESS3, POSTAL) VALUES(?,?,?,?,?,?,?,?,?,?)';
    var val = [
        req.body.name,
        req.body.surname,
        req.body.email,
        req.body.password,
        req.body.said,
        req.body.tel,
        req.body.address1,
        req.body.address2,
        req.body.address3,
        req.body.postcode
    ];
    var identififyUserType = req.body.email.split(".");
    if(identififyUserType[0] == "com")
    {
        res.json({'status':'Not Allowed'});
        return;
    }
    // create Request object
    con.getConnection(function(err, connection){
        if (err) {
          connection.release();
          res.json({"code" : 100, "status" : "Error in connection database"});
          return;
        }

        connection.query(sql, val, function (err, result) {
            if (err){console.log(err);}
            console.log('insert success: '+ req.body.email);
            var sql2 = 'SELECT * FROM users WHERE email = ?';
            connection.query(sql2, req.body.email, function(err,result) {
                if(err){res.json(err);}
                else if(result[0] == undefined) res.json({
                login: "Email or password incorrect.",
                email: req.body.email
                });
                else{
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
                  var sqlfile = 'INSERT INTO user_file (UserID) VALUES ('+result[0].UserId+');';

                  console.log(user);
                  
                var identififyUserType = req.body.email.split(".");
                if(identififyUserType[0] == "adm")
                {
                    res.redirect('/admin');
                    return;
                }
                    const token = jwt.sign({ user }, 'lets_allow_them_in_deqisgreat');
                    console.log(req.headers['accept']);
                    if (!req.headers['accept'] || req.headers['accept'].indexOf('text/html')) {
                        console.log("LOGIN\nTHIS IS THE APP\n\n");
                        res.json({//return values
                            login: 'success',
                            token: token,
                            user: user
                        });
                    } else {
                        console.log("LOGIN\nTHIS IS THE WEBSITE\n\n");
                        res.cookie('auth', token);
                        res.redirect('/profile');
                    }
                }
            })
        });
    });
}