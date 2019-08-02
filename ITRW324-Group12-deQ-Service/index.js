//packages
var https = require('https');
var bodyParser = require('body-parser');
var express = require('express');
var mysql = require('mysql');
var jwt = require('jsonwebtoken');
var randtoken = require('rand-token');
var cookieParser = require('cookie-parser');
var fs = require('fs');
var path = require('path');
const multer = require('multer');



const storage = multer.diskStorage({
    destination: function(req, file, cb) {
        cb(null, "./uploads/");
    },
    filename: function(req, file, cb) {
        var uploadedFileName = file.fieldname + "+" + new Date().toJSON().replace(new RegExp(':', 'g'),'-') + path.extname(file.originalname);
        cb(null, uploadedFileName);
        var filesname = __dirname + "/uploads/" + uploadedFileName;
        console.log("The file is saved as " + filesname);
        console.log("The file name is " + uploadedFileName);
        const token = req.cookies['auth'];
        var user = jwt.verify(token, 'lets_allow_them_in_deqisgreat').user;
        var sql;

        var fileNamess = uploadedFileName.split("+");
        /*switch (file.fieldname) {
            case "idDoc": sql = "UPDATE user_file SET File_LocationID = ? WHERE UserID = ?";
                break;
            case "driversLicense": sql = "UPDATE user_file SET File_LocationID = ? WHERE UserID = ?";
                break;
            case "proofOfResidence": sql = "UPDATE user_file SET File_LocationLicense = ? WHERE UserID = ?";
                break;
            case "BankStatement": sql = "UPDATE user_file SET File_LocationBankStatement = ? WHERE UserID = ?";
                break;
        }*/


        if(fileNamess[0] == "idDoc")
        {
            var idDoc = filesname;
            console.log("ID DOCUMENT: " + idDoc);
            sql = "UPDATE user_file SET File_LocationID = ? WHERE UserID = ?";
            //sql = "SET @id = ?; SET @file = ?; INSERT INTO user_file VALUES(@id, @file, NULL, NULL, NULL) ON DUPLICATE KEY UPDATE File_LocationID = @file; UPDATE user_file SET File_LocationID = @file WHERE UserID = @id";
        }//driversLicense+2018-10-20T11-12-00.944Z.jpg
        if(fileNamess[0] == "driversLicense")
        {
            var driversLicenseDoc = filesname;
            console.log("Drivers license : " + driversLicenseDoc);
            sql = "UPDATE user_file SET File_LocationID = ? WHERE UserID = ?";
            //sql = 'SET @id = ?; SET @file = ?; INSERT INTO user_file VALUES(@id, NULL, @file, NULL, NULL) ON DUPLICATE KEY UPDATE File_LocationLicense = @file; UPDATE user_file SET File_LocationLicense = @file WHERE UserID = @id;';
        }
        if(fileNamess[0] == "proofOfResidence")
        {
            var por = filesname;
            console.log("Proof of residence : " + por);
            sql = "UPDATE user_file SET File_LocationLicense = ? WHERE UserID = ?";
            //sql = 'SET @id = ?; SET @file = ?; INSERT INTO user_file VALUES(@id, NULL, NULL, @file, NULL) ON DUPLICATE KEY UPDATE File_LocationProofOfResidence = @file; UPDATE user_file SET File_LocationProofOfResidence = @file WHERE UserID = @id';
        }
        if(fileNamess[0] == "BankStatement")
        {
            var BankStatmentDoc = filesname;
            console.log("Bank statement: " + BankStatmentDoc);
            sql = "UPDATE user_file SET File_LocationBankStatement = ? WHERE UserID = ?";
            //sql = 'SET @id = ?; SET @file = ?; INSERT INTO user_file VALUES(@id, NULL, NULL, NULL, @file) ON DUPLICATE KEY UPDATE File_LocationBankStatement = @file; UPDATE user_file SET File_LocationBankStatement = @file WHERE UserID = @id';
        }
        con.getConnection(function(err, connection) {
            if (err) {
                console.log('error in db connection');
                connection.release();
                return;
            }
            connection.query(sql, [uploadedFileName, user.id], function (err, result) {
                if (err){
                    console.log(err); 
                } else  {
                    console.log('insert success: '+ [user.id, uploadedFileName]);
                }
                connection.release();
            });
        });
    }
});


//create express object
const app = express();

                

//==================== HTTPS SSL Certificates =====================//
var options = {
    key: fs.readFileSync("SSL\ certificates\\www.funky.co.za.key"),
    cert: fs.readFileSync("SSL\ certificates\\www_funky_co_za.crt"),
    ca:[
        fs.readFileSync("SSL\ certificates\\AddTrustExternalCARoot.crt"),
        fs.readFileSync("SSL\ certificates\\COMODORSAAddTrustCA.crt")
    ]
};
/*
var server = https.createServer(options, app).listen(443, function(){
    console.log('Server is active on port 443');
}); //============= END OF SSL =============//*/

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));
app.use(cookieParser());


app.use(express.static(__dirname + '/Client'));
app.use(express.static(__dirname + '/Server'));

//==================== SET DB CONNECTION INFO
var con = mysql.createPool({
    host: "localhost",
    user: "root",
    password: "deQ@123456",
    database: "dequeuedb"
});


//==================== Main Page
app.get('/', function(req, res) {
    console.log('main page');
    res.sendFile(path.join(__dirname, 'deQ-Website-and-Server/', 'index.html'));
});

//==================== Send Email
app.post('/contactf', function (req, res) {
    var email = require('./Server/email')(req, res);
});

//==================== Handle Registration
app.post('/register', function(req, res) {
    var qry = require('./Server/register')(req, res, con, jwt, randtoken);
});

//post for admin page for company register
/*app.post('/admin', function(req, res) {
    var qry = require('./Server/admin')(req, res, con, jwt, randtoken);
});//*/

app.get('/checkemail', function(req, res) {
    var email = req.body.email;
    var sql = 'SELECT email FROM users WHERE email = ?';
    if (email !== undefined) {
        var qry = require('./Server/checkvalue')(sql, email, con, res);
    } else {
        if (err)
            console.log(err);
    }
})

//==================== Handle Login
app.post('/login', function(req, res) {
    require('./Server/login')(req, res, con, jwt);
});


            /*-----------------------------------------FILE UPLOADS --------------------------------*/
//ID file upload
app.post('/profile/uploadID',function(req,res){
    var upload = multer({ storage : storage}).single('idDoc');
    upload(req,res,function(err) {
        if(err) {
            return res.send(err);
        }
        res.redirect('/profile');
    });
});


//Drivers license upload
app.post('/profile/uploadDL',function(req,res){
    var upload = multer({ storage : storage}).single('driversLicense');
    upload(req,res,function(err) {
        if(err) {
            return res.end("Error uploading file.");
        }
        res.redirect('/profile');
    });
});



//Proof of residence file upload
app.post('/profile/uploadPOR',function(req,res){
    var upload = multer({ storage : storage}).single('proofOfResidence');
    upload(req,res,function(err) {
        if(err) {
            return res.end("Error uploading file.");
        }
        res.redirect('/profile');
    });
});


//Bank statement file upload
app.post('/profile/uploadBS',function(req,res){
    var upload = multer({ storage : storage}).single('BankStatement');
    upload(req,res,function(err) {
        if(err) {
            return res.end("Error uploading file.");
        }
        res.redirect('/profile');
    });
});
/*-----------------------------------------FILE UPLOADS END --------------------------------*/

app.get('/profile', function(req, res) {
    jwt.verify(req.cookies['auth'], 'lets_allow_them_in_deqisgreat', function(err, data) {
        if (err) {
          res.sendStatus(403);
          console.log("\n\n"+err);
        } else {
            res.sendFile(path.join(__dirname, "/Client/","profile.html"));
        }
      });
});

app.post('/profile', function(req, res) {
    require('./Server/profile')(req, res, con, jwt);
})

app.get('/profile/info', function(req, res) {
    var user = jwt.verify(req.cookies['auth'], 'lets_allow_them_in_deqisgreat').user;
    res.json(user);
});

app.get('/profile/files', function(req, res) {
    require('./Server/getFiles')(req, res, con);
});

app.get('/queue', function(req, res) {
    require('./Server/getQueue')(req, res, con, jwt);
});

app.post('/queue', function(req, res) {
    require('./Server/setQueue')(req, res, con, jwt);
});

app.delete('/queue', function(req, res) {
    require('./Server/dropQueue')(req, res, con, jwt);
});

app.get('/admin', function(req, res) {
    res.sendFile(path.join(__dirname, "/Client/","admin.html"));
})

app.get('/admin/companylist', function(req, res) {
    require('./Server/getCompanies')(req, res, com);
})

//post for admin page for company register
app.post('/admin', function(req, res) {
    require('./Server/admin')(req, res, con);
});

app.get('/services', function(req, res) {
    require('./Server/getServices')(req, res, con);
});

app.get('/company', function(req, res) {
    res.sendFile(path.join(__dirname, "/Client/","Company.html"));
});

//post for company page to change company details
app.post('/company', function(req, res) {
    var qry = require('./Server/editcompany')(req, res, con);
});

app.get('/company/info', function(req, res) {
    console.log('Show company info *****');
    console.log(JSON.stringify(jwt.verify(req.cookies['auth'], 'lets_allow_them_in_deqisgreat').company));
    res.send(JSON.stringify(jwt.verify(req.cookies['auth'], 'lets_allow_them_in_deqisgreat').company));
});

app.get('/test', function(req, res) {
    const token = req.cookies['auth'];
    var user = jwt.verify(token,'lets_allow_them_in_deqisgreat');
    res.send(user);
});

app.get('*', function(req, res) {
    res.redirect('/');
})

app.listen(3000);