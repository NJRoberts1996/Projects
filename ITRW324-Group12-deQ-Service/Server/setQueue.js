module.exports = function(req, res, con, jwt) {

    var token = req.cookies['auth'];
    if (token == undefined) {
        if (req.body.token == undefined) {
            res.json({'result':'Token is required!'});
        } else {
            token = req.body.token;
        }
    }
    console.log('Selected Service: '+req.body.servID);
    var user = jwt.verify(token, 'lets_allow_them_in_deqisgreat').user;
    var sqlquery = "INSERT INTO  master_queue VALUES(?,?,?)";

    con.getConnection(function(err, connection){
        if (err) {
          connection.release();
          res.json({"code" : 100, "status" : "Error in connection database"});
          return;
        }

        var sqldel = "DELETE FROM master_queue WHERE ServiceId = ? AND UserId = ?";
        connection.query(sqldel, [req.body.servID, user.id], function (err, result) {
            if (result[0] != undefined) {console.log("The old booking has been removed");}
        });

        console.log('pre time select');
        sqlinit = "SELECT * FROM master_queue WHERE Time > sysdate() AND ServiceID = ?"
        connection.query(sqlinit, req.body.servID, function (err, resul) {
            if (err) {res.json({'error':err}); console.log(err);connection.release(); return;}
            var time;
            if (resul[0] == undefined) {
                time = new Date();
                time.setMinutes(parseInt(time.getMinutes()/15)*15+15);
                time.setHours(time.getHours()+2);
                console.log('Time set 1: '+time+' *** '+time.getMinutes()+" *** "+time.getMinutes()/15+" *** "+(parseInt(time.getMinutes()/15)*15+15)); 
            } else {
                time = resul[resul.length-1].Time+15;
                //console.log('Time set 2: '+time+' *** '+time.getMinutes()+" *** "+time.getMinutes()/15+" *** "+(parseInt(time.getMinutes()/15)*15+15));
            }
            console.log('selected time: '+time.toISOString().substring(0, 10)+' '+time.toISOString().substring(11, 19));
            connection.query(sqlquery, [user.id, req.body.servID, time.toISOString().substring(0, 10)+' '+time.toISOString().substring(11, 19) ], function (err, resu) {
                if (err) {console.log(err); return;}
                connection.release();
                res.json({ status:'success' });
                //res.redirect('/queue');
                console.log('Queue entry added: '+user.id+' * '+req.body.servID+' * '+time.toISOString().substring(0, 10)+' '+time.toISOString().substring(11, 19)+' * '+JSON.stringify(resu));
            });
        });
    });
}