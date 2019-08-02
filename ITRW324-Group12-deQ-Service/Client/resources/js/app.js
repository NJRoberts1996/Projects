var express = require('express');
var app = express();
var bodyParser = require('body-parser');
 


// create application/json parser
var jsonParser = bodyParser.json();
 
// create application/x-www-form-urlencoded parser
var urlencodedParser = bodyParser.urlencoded({ extended: false })



app.post('/', urlencodedParser, function (req, res) 
{
    
    console.body(req.body);
  if (!req.body) return res.sendStatus(400)
  res.send('welcome, ' + req.body.username)
});