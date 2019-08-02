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
    var sqlquery = "DELETE FROM master_queue WHERE UserID = ?";

    con.getConnection(function(err, connection){
        if (err) {
          connection.release();
          res.json({"code" : 100, "status" : "Error in connection database"});
          return;
        }

        connection.query(sqlquery, user.id, function (err, result) {
            if (err){res.json({'status':'error in removing queue entry'});}
            res.json({ 'status':'success'
            });
        });
    });

}