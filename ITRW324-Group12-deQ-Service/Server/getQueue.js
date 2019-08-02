module.exports = function(req, res, con, jwt) {

    var token = req.cookies['auth'];
    if (token == undefined) {
        console.log('************ GET QUEUE ** APP *************');//+req.headers['authentication']);
        if (req.headers['authentication'] == undefined) {
            res.json({'result':'Token is required!'});
            return;
        } else {
            token = req.headers['authentication'];
        }
    }
    var user = jwt.verify(token, 'lets_allow_them_in_deqisgreat').user;
    console.log("User for queue: "+user.id);
    var sqlquery = "SELECT * FROM master_queue A INNER JOIN service B ON A.ServiceID = B.ServiceID WHERE A.UserID = "+user.id;

    con.getConnection(function(err, connection){
        if (err) {
            console.log(err);
            connection.release();
            res.json({"code" : 100, "status" : "Error in connection database"});
            return;
        }
console.log('test1');
        connection.query(sqlquery, function (err, result) {
            if (err) {res.json(err); console.log(err); connection.release(); return;}
            else if (result[0] == undefined) {res.json({'status':'No queue exists'}); return;}
            var sql2 = "SELECT COUNT(QueueId) AS pos FROM master_queue WHERE Time BETWEEN SYSDATE AND ? AND WHERE ServiceID = ? GROUP BY ServiceID";
console.log('test2');

            connection.query(sql2, [result[0].Time,result[0].ServiceId], function(err, resul) {
                if (resul == undefined) {
                    console.log('We have one person in the queue!');
                    console.log('queue info:'+JSON.stringify({ servID:result[0].ServiceId, servName:result[0].ServiceName, servLoc:result[0].Location, queueTime:result[0].Time, queuePos:1}));
                    res.send(JSON.stringify([{ servID:result[0].ServiceId, servName:result[0].ServiceName, servLoc:result[0].Location, queueTime:result[0].Time, queuePos:1}]));
                } else {
                    console.log('We have '+resul[0].pos+' people in the queue.');
                    console.log('queue info: '+JSON.stringify({ servID:result[0].ServiceId, servName:result[0].ServiceName, servLoc:result[0].Location, queueTime:result[0].Time, queuePos:resul[0].pos}));
                    res.send(JSON.stringify([{ servID:result[0].ServiceId, servName:result[0].ServiceName, servLoc:result[0].Location, queueTime:result[0].Time, queuePos:resul[0].pos}]));
                }
                connection.release();
            })
        });
    });
}