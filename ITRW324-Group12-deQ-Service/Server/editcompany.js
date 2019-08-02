module.exports = function(req, res, con){
    console.log(JSON.stringify(req.body));
    var sql = 'UPDATE service SET ServiceName=?, NoOfTellers=?, BranchName=?, Location=?, City=?, DaysOpen=?, OpenTime=?, CloseTime=? WHERE ServiceId = ?';
    var val = [
        req.body.companyName,
        parseInt(req.body.NoOfTellers),
        req.body.BranchName,
        req.body.Location,
        req.body.City,
        req.body.DaysOpen,
        req.body.OpenTime,
        req.body.CloseTime,
        parseInt(req.body.service)
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
            console.log('update success');
            res.redirect('/company');
            });
    });
}