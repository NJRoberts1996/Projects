module.exports = function(req, res, con) {

    var sqlquery = "SELECT * FROM service";

    con.getConnection(function(err, connection){
        if (err) {
          connection.release();
          res.json({"code" : 100, "status" : "Error in connection database"});
          return;
        }

        connection.query(sqlquery, function (err, result) {
            if(err) { res.json(err);
                return;
            } else {
                var objs = [];
                for (var i = 0;i < result.length; i++) {
                    objs.push({servID: result[i].ServiceId,
                        servName: result[i].ServiceName,
                        servLoc: result[i].Location,
                        timeOpen: result[i].OpenTime,
                        timeClose: result[i].CloseTime,
                        daysOpen: result[i].DaysOpen
                    });
                }
                connection.release();
                res.end(JSON.stringify(objs));
            };
        });
    });
};