
    var obj, xmlhttp, myObj, x, txtName = "", txtBranch = "", txtCity = "";
    obj = { table: companylist, limit: 20 };
    xmlhttp = new XMLHttpRequest();
    xmlhttp.onreadystatechange = function() 
    {
      if (this.readyState == 4 && this.status == 200) {
        myObj = JSON.parse(this.responseText);
        txtName += "<table border='1'>";
        txtBranch += "<table border='2'>";
        txtCity += "<table border='2'>";
        for (x in myObj) {
          txtName += "<tr><td>" + myObj[x].servName + "</td></tr>";
          txtBranch += "<tr><td>" + myObj[x].servBranch + "</td></tr>";
          txtCity += "<tr><td>" + myObj[x].servCity + "</td></tr>";
        }
        txt += "</table>"        
        document.getElementById("company-list").innerHTML = txt;
      }
    };
    xmlhttp.open("GET", "/admin/companylist", true);
    //xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    xmlhttp.send("admin2");
  