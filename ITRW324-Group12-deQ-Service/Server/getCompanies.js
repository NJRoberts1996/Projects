module.exports = function(req, res, con) {

    var sql = 'SELECT ServiceName, BranchName, City FROM service';

    con.getConnection(function(err, connection){
        if (err) {
          connection.release();
          res.json({"code" : 100, "status" : "Error in connection database"});
          return;
        }

        connection.query(sql, function (err, result) {
            if(err) { res.json(err);
                return;
            } else {
                var objs = [];
                for (var i = 0;i < result.length; i++) {
                    objs.push({servName: result[i].ServiceName,
                        servBranch: result[i].BranchName,
                        servCity: result[i].City
                    });
                };
                connection.release();
                res.send(JSON.stringify(objs));
            }
        });
    });
}