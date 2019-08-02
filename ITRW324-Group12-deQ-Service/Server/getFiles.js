module.exports = function(req, res, con) {

    const token = req.cookies['auth'];
    var user = jwt.verify(token, 'lets_allow_them_in_deqisgreat');
    var sqlquery = "SELECT * FROM user_file WHERE UserID = ?";

    con.getConnection(function(err, connection){
        if (err) {
          connection.release();
          res.json({"code" : 100, "status" : "Error in connection database"});
          return;
        }

        connection.query(sqlquery, user.id, function (err, result) {
            res.json({ idDoc: result[0].File_LocationID,
                driversLicense: result[0].File_LocationLicense,
                proofOfResidence: result[0].File_LocationProofOfResidence,
                BankStatement: result[0].File_LocationBankStatement
            });
        });
    });
};