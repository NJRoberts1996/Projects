
module.exports = function(sql, val, con, res){
  con.getConnection(function(err, connection){
    if (err) {
      connection.release();
      res.json({"code" : 100, "status" : "Error in connection database"});
      return;
    }

    console.log('connected as id ' + connection.threadId);

    connection.query(sql,val,function(err,result){
      connection.release();
      if(err){
        res.json(err);
      }
      else if(result[0] === undefined){
        res.json({
          username: 'available'
        });
      }
      else {
        res.json({
          username: 'taken'
        });
      }
    });
  });
}
