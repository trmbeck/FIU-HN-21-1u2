//console.log = () => {};
let x;
let y;

function getValues(){
    x = document.getElementById('x').value;
    y = document.getElementById('y').value;
}
function add(){
    getValues();
    let xmlhttp = new XMLHttpRequest();
    xmlhttp.open("GET","/addition?x="+ x + "&y=" + y, false);
    xmlhttp.send();
    let jsObject = JSON.parse(xmlhttp.response);
    console.log(jsObject.ergebnis);
    setResultInTableCell(jsObject.ergebnis);
}

function addAsync(){
    getValues();
    let xmlhttp = new XMLHttpRequest();
    console.log(xmlhttp.readyState);
    /*
        0 - Uninitialized -> open-Methode wurde noch nicht aufgerufen
        1 - Loading -> send-Methode wurde noch nicht aufgerufen
        2 - Loaded -> send-Methode wurde aufgerufen; headers und status sind verfügbar
        3 - Interactive -> Download der Antwort (XML oder JSON Stream)
        4 - Completed -> Alle Operationen sind beendet
    */
    xmlhttp.onreadystatechange = function () {
        console.log(xmlhttp.readyState);
        if (xmlhttp.readyState == 4 && xmlhttp.status == 200){
            let jsObject = JSON.parse(xmlhttp.response);
            console.log("Ergebnis: " + jsObject.ergebnis);
            setResultInTableCell(jsObject.ergebnis);
        }
    }
    
    xmlhttp.open("GET", "/addition?x="+ x + "&y=" + y, true);
    xmlhttp.send();
}

function setResultInTableCell(sum){
    let cell = document.getElementById('ergebnis');
    cell.innerHTML = sum;
}