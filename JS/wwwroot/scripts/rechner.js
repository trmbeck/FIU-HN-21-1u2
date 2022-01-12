function add(){
    let x = document.getElementById('x').value;
    let y = document.getElementById('y').value;
    let xmlhttp = new XMLHttpRequest();
    xmlhttp.open("GET","/addition?x="+ x + "&y=" + y, false);
    xmlhttp.send();
    let jsObject = JSON.parse(xmlhttp.response);
    console.log(jsObject.ergebnis);
}