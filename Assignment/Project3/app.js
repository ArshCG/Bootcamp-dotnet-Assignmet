function byid(){
    document.getElementById("getbyid1").style.display="block";
}
function insert(){
    document.getElementById("insert1").style.display="block";
}
function search(){
    document.getElementById("search1").style.display="block";
}


function getitems() {
   
    var url="http://localhost:53557/api/Employee";
    fetch(url)
    .then((res) => res.text())
    .then(ans => showData(ans))  
    }
       
      
  function showData(data)
  {
      document.getElementById('table').innerHTML=data;
  }

  function getitems1() {
   
    var id=document.getElementById("getid").value;
    var url="http://localhost:53557/api/Employee/"+id;
    fetch(url)
    .then((res) => res.text())
    .then(ans => showData(ans))  
    }
       
      
  function showData(data)
  {
      document.getElementById('table').innerHTML=data;
  }



  function getitems2(){

    let empname = document.getElementById("empname");

    let empgender = document.getElementById("empgender");

    let emppos = document.getElementById("emppos");
    let emppro = document.getElementById("emppro");


    let xhr = new XMLHttpRequest();

    let url = "http://localhost:53557/api/Employee";
    xhr.open("POST", url, true);

    xhr.setRequestHeader("Content-Type", "application/json");

    xhr.onreadystatechange = function () {

        if (xhr.readyState === 4 && xhr.status === 200) {

            result.innerHTML = this.responseText;



        }

    };

    var data = JSON.stringify({  "empName": empname.value , "empGender":empgender.value, "empPos":emppos.value,"empProject":emppro.value });
    xhr.send(data);

}

function getitems3() {
   
    var id=document.getElementById("like").value;
    var url="http://localhost:53557/api/Employee/Employee/"+id;
    fetch(url)
    .then((res) => res.text())
    .then(ans => showData(ans))  
    }
       
      
  function showData(data)
  {
      document.getElementById('table').innerHTML=data;
  }


      
      


  

