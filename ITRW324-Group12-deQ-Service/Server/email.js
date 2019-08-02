
// node.js - email //
module.exports = function(req, res) {
  const nodemailer = require('nodemailer');
  require('dotenv').config();
  
  let mailOpts, smtpTrans;
  smtpTrans = nodemailer.createTransport({
    service: 'gmail',
    auth: {
      user: process.env.GMAIL_USER,	
      pass: process.env.GMAIL_PASSWORD
    }
  });
    
  mailOpts = {
    from: req.body.name + ' &lt;' + req.body.email + '&gt;',
    to: "testdeq191@gmail.com",
    subject: 'New message from contact form',
    text: `${req.body.name} (${req.body.email}) says: ${req.body.message}`
  };

  smtpTrans.sendMail(mailOpts, function (error, response) {
    if (error) {
      console.log("Email Failure: %s\n%s\n%s",error, mailOpts.text);
      res.send("Email not sent");
    }
    else {
      res.send("Email sent successfully");
    }
  });
}