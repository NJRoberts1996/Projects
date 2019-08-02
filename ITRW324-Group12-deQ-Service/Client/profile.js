/*
//--hardcoded json values for display on profile page
var jcontent = {
    "profileName": "Ahmed",
    "surname": "Patel",
    "profileID":"1234567890123",
    "profileTel": "0634483161",
    "email":"armeepatel@gmail.com",
    "physicalAddress1":"123 NWU street", 
    "physicalAddress2":"Potchefstroom", 
    "physicalAddress3":"South Africa" ,
    "postalCode" : "2520"
}
//--Create variables that link to the id on labels on the html page
    var profileName = document.getElementById('profileName');
    var surname = document.getElementById('profileSurname');
    var idNum = document.getElementById('profileID');
    var telNum = document.getElementById('profileTel');
    var email = document.getElementById('profileEmail');
    var physicalAddress1 = document.getElementById('profileAddress1');
    var physicalAddress2 = document.getElementById('profileAddress2');
    var physicalAddress3 = document.getElementById('profileAddress3');
    var postalCode = document.getElementById('profilePostal');


    //res.json({userObject: {username: "profileName", surname: "profileSurname", email: "profileEmail", id: "userID", said: "profileID", tel: "profileTel", address1: "physicalAddress1", address2: "physicalAddress2", address3: "physicalAddress3", postal: "profilePostal" }, iat: "iat"});
//--use variable names created and assign the json values to it
    profileName.innerHTML = jcontent.profileName;
    surname.innerHTML = jcontent.surname;
    idNum.innerHTML = jcontent.profileID;
    telNum.innerHTML = jcontent.profileTel;
    email.innerHTML = jcontent.email;
    physicalAddress1.innerHTML = jcontent.physicalAddress1;
    physicalAddress2.innerHTML = jcontent.physicalAddress2;
    physicalAddress3.innerHTML = jcontent.physicalAddress3;
    postalCode.innerHTML = jcontent.postalCode;




*/


//--receive cookie with token inside
//const cookieparser = require('cookie-parser');
//const token = req.cookies['auth'];
/*
//--hardcoded json values for display on profile page
console.log("Hello, this is Ahmed testing if this works");
var jcontent = {
    "profileName":"Ahmed",
    "surname":"Patel",
    "idNum":"1234567891234",
    "telNum":"0123456789",
    "email":"abc@deq.com",
    "physicalAddress1":"123 street", 
    "physicalAddress2":"Potchefstroom", 
    "physicalAddress2":"South Africa" ,
    "postalCode" : "1234"
   
 }
*/

/*
//--Get cookie with token
module.exports = function(req, res, jwt) {
    const cookieparser = require('cookie-parser');
    const jwt = require('jsonwebtoken');
    const token = req.cookies['auth'];
    var user = jwt.verify(token,'lets_allow_them_in_deqisgreat').user;

    request(options, function (err, res, user) {
        if (err) {
          console.log(err)
          return
        }
        let jsonData = JSON.parse(user); 
        console.log(jsonData); 
      
      });
    //--hardcoded json values for display on profile page
    var jcontent = {
        "profileName": user.name,
        "surname": user.surname,
        "email":user.email,
        "id": user.id,
        "said":user.said,
        "tel": user.tel,
        "address1":user.address1, 
        "address2":user.address2, 
        "address3":user.address3 ,
        "postal" : user.postal
    }*/

//--Create variables that link to the id on labels on the html page
    var profileName = document.getElementById('profileName');
    var surname = document.getElementById('profileSurname');
    var idNum = document.getElementById('profileID');
    var telNum = document.getElementById('profileTel');
    var email = document.getElementById('profileEmail');
    var physicalAddress1 = document.getElementById('profileAddress1');
    var physicalAddress2 = document.getElementById('profileAddress2');
    var physicalAddress3 = document.getElementById('profileAddress3');
    var postalCode = document.getElementById('profilePostal');

//--Create variables that link to the id on input (textboxes to edit) the html page
    var tprofileName = document.getElementById('given-name');
    var tsurname = document.getElementById('family-name');
    var tidNum = document.getElementById('said');
    var ttelNum = document.getElementById('tel');
    var temail = document.getElementById('email');
    var tphysicalAddress1 = document.getElementById('address-line1');
    var tphysicalAddress2 = document.getElementById('address-line2');
    var tphysicalAddress3 = document.getElementById('address-line3');
    var tpostalCode = document.getElementById('postal-code');

//--Create xml format variable
var xmlhttp = new XMLHttpRequest();

xmlhttp.onreadystatechange = function() 
{
    if (this.readyState == 4 && this.status == 200) {
        var myObj = JSON.parse(this.responseText);//'profile/info');

        //--use variable names created and assign the json values to it
        profileName.innerHTML = myObj.name;
        surname.innerHTML = myObj.surname;
        idNum.innerHTML = myObj.said;
        telNum.innerHTML = myObj.tel;
        email.innerHTML = myObj.email;
        physicalAddress1.innerHTML = myObj.address1;
        physicalAddress2.innerHTML = myObj.address2;
        physicalAddress3.innerHTML = myObj.address3;
        postalCode.innerHTML = myObj.postal;
        
        //--use variable names created and assign the json values to it
        tprofileName.value = myObj.name; 
        tsurname.value = myObj.surname; 
        tidNum.value = myObj.said; 
        ttelNum.value = myObj.tel;
        temail.value = myObj.email; 
        tphysicalAddress1.value = myObj.address1;
        tphysicalAddress2.value = myObj.address2;
        tphysicalAddress3.value = myObj.address3;
        tpostalCode.value = myObj.postal;



    }
};
//--
xmlhttp.open("GET", "profile/info", true);
xmlhttp.send();


    //res.json({userObject: {username: "profileName", surname: "profileSurname", email: "profileEmail", id: "userID", said: "profileID", tel: "profileTel", address1: "physicalAddress1", address2: "physicalAddress2", address3: "physicalAddress3", postal: "profilePostal" }, iat: "iat"});
    
//} 



//--Create variables that link to the id on input (for labels) the html page
    /*var profileName = document.getElementById('profileName');
    var surname = document.getElementById('profileSurname');
    var idNum = document.getElementById('profileID');
    var telNum = document.getElementById('profileTel');
    var email = document.getElementById('profileEmail');
    var physicalAddress1 = document.getElementById('profileAddress1');
    var physicalAddress2 = document.getElementById('profileAddress2');
    var physicalAddress3 = document.getElementById('profileAddress3');
    var postalCode = document.getElementById('profilePostal');*/
    



