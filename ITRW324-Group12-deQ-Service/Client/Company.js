/*//--receive cookie with token inside
const cookieparser = require('cookie-parser');
const token = req.cookies['auth'];
var company = jwt.verify(token,'lets_allow_them_in_deqisgreat');

    res.json(company);*/

//--receive cookie with token inside
/*    module.exports = function(req, res, jwt) {
        const cookieparser = require('cookie-parser');
        const jwt = require('jsonwebtoken');
        const token = req.cookies['auth'];
        var profile = jwt.verify(token,'lets_allow_them_in_deqisgreat');
        res.send(JSON.stringify(jwt.verify(token, 'lets_allow_them_in_deqisgreat').user));   
   
*/
/*
//--hardcoded json values for display on profile page
var jcontent = {
    "CName":"Hellcom",
    "CTellers":2,
    "CBName":"Hellcom Potch",
    "CLocation":"666 Hell Street",
    "City":"Potchefstroom",
    "Opend":"Mondat-Friday",
    "COpen":"07:00",
    "CClosed":"17:00"
}
*/
//--Create variables that link to the id on labels on the html page
    var Service = document.getElementById('service');
    var CName = document.getElementById('cname');
    var CName2 = document.getElementById('ServiceName');
    var CTellers = document.getElementById('CTellers');
    var CTellers2 = document.getElementById('NoOfTellers');
    var CBName = document.getElementById('CBName');
    var CBName2 = document.getElementById('BranchName');
    var CLocation = document.getElementById('CLocation');
    var CLocation2 = document.getElementById('Location');
    var City = document.getElementById('City');
    var Opend = document.getElementById('Opend');
    var Opend2 = document.getElementById('DaysOpen');
    var COpen = document.getElementById('COpen');
    var COpen2 = document.getElementById('OpenTime');
    var CClosed = document.getElementById('CClosed');
    var CClosed2 = document.getElementById('CloseTime');

//--Create xml format variable
    var xmlhttp = new XMLHttpRequest();
    xmlhttp.onreadystatechange = function() 
    {
        if (this.readyState == 4 && this.status == 200) {
            var myObj = JSON.parse(this.responseText);
    
            //--use variable names created and assign the json values to it
            Service.value = myObj.servID;
            CName.innerHTML = myObj.servName;
            CTellers.innerHTML = myObj.servTellers;
            CBName.innerHTML = myObj.servBranch;
            CLocation.innerHTML = myObj.servLoc;
            City.innerHTML = myObj.servCity;
            Opend.innerHTML = myObj.servDaysOpen;
            COpen.innerHTML = myObj.servOpen;
            CClosed.innerHTML = myObj.servClosed;
            CName2.value = myObj.servName;
            CTellers2.text = myObj.servTellers;
            CBName2.value = myObj.servBranch;
            CLocation2.value = myObj.servLoc;
            City.value = myObj.servCity;
            Opend2.value = myObj.servDaysOpen;
            COpen2.text = myObj.servOpen;
            CClosed2.text = myObj.servClosed;
    
    
    
        }
    };
    //--
    xmlhttp.open("GET", "company/info", true);
    //--
    xmlhttp.send();





    
 //--Create variables that link to the id on input (for labels) the html page
/*CName.innerHTML = company.servName;
    CTellers.innerHTML = company.servTellers;
    CBName.innerHTML = company.servBranch;
    City.innerHTML = company.servCity;
    Opend.innerHTML = company.servDaysOpen;
    COpen.innerHTML = company.servOpen;
    CClosed.innerHTML = company.servClosed;

    }*/