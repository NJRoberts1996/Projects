
const nodemailer = require('nodemailer');
const express = require('express');
const app = express();

const bodyParser = require('body-parser');

app.use(bodyParser.urlencoded({ extended: true }));

app.use(express.static('public'));
app.get('/indexTest.html', function (req, res) {
   res.sendFile( __dirname + "/" + "indexTest.html");
})

app.post('/process_post', function (req, res) {
	
	let mailOpts, smtpTrans;
	
  smtpTrans = nodemailer.createTransport({
    service: 'gmail',
    port: 8081,
    secure: false,
    auth: {
      user: 'testdeq191@gmail.com',
      pass: 'deq1234567'
    }
  });
  
  tls: { rejectUnauthorized: false }
  
  mailOpts = {
	  
    from: 'testdeq191@gmail.com',
    to: 'testdeq191@gmail.com',
    subject: 'There is a new message',
    text: req.body.firstName + ' says hello'
  };
  
  smtpTrans.sendMail(mailOpts, (error, info) => {
    if (error) {
      console.log(error);//res.json({error:error});
    }
		console.log("Your message was sent");
		console.log(info);
      //res.json({success: info.response});
  });
  
});

var server = app.listen(8081, function () {
   var host = server.address().address
   var port = server.address().port
   
   console.log("It is currently listening at http://%s:%s", host, port)

})
