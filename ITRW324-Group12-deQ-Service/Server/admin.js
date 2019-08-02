module.exports = function(req, res, con){

    var sql = 'INSERT INTO service (ServiceName, NoOfTellers, BranchName, Location, City, DaysOpen, OpenTime, CloseTime, Email, Password) VALUES(?,?,?,?,?,?,?,?,?,?)';
    var sql2 = 'INSERT INTO users (EMAIL, PASSWORD) VALUES (?, ?)';
    var val = [
        req.body.ServiceName,
        req.body.NoOfTellers,
        req.body.BranchName,
        req.body.Location,
        req.body.City,
        req.body.DaysOpen,
        req.body.OpenTime,
        req.body.CloseTime,
        req.body.comEmail,
        req.body.comPass
    ];
    // create Request object
    con.getConnection(function(err, connection){
        if (err) {
          connection.release();
          res.json({"code" : 100, "status" : "Error in connection database"});
          return;
        }

        connection.query(sql, val, function (err, result) {
            if (err){console.log(err); connection.release(); return;}
            console.log('A company has been added: '+req.body.ServiceName);
            res.redirect('/admin');
            });
    });
}