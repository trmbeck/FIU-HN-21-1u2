let express = require('express');
let app = express();
let formidable = require('formidable');

// URL: http://hostname.dnsSLD.dnsTLD/start.html
app.use(express.static(__dirname + '/wwwroot',{index: false}));

// URL: http://hostname.dnsSLD.dnsTLD/path1/path2/file.html
app.get("/", (request,response) => {
    console.log("URL: " + request.url);
    // console.log("Strasse: ");
    // console.log(request.query.Strasse);
    // console.log(request.query.ort);
    //response.send("Hello FIU HN 21 - 1 und 2");
    response.sendFile(__dirname + '/wwwroot/index.html');
});

app.get("/kontaktformular", (request,response)=>{
    console.log("Thema: " + request.query.thema);
    console.log("Beschreibung: " + request.query.beschreibung);
    console.log("E-Mail: " + request.query.email);
    response.send("Vielen Dank für die Info");
});

app.post("/kontaktformular", (request,response)=>{
    let form = new formidable.IncomingForm();
    form.parse(request,(Fehlerobjekt, FelderDesFormulars) => {
        if (Fehlerobjekt) {
            response.writeHead(500);
            response.end();
            console.log(Fehlerobjekt);
        }
        else {
            console.log(FelderDesFormulars);
            response.writeHead(200,{"Content-Type":"text/html;charset=utf-8"});
            response.write("Hallo " + FelderDesFormulars.email + "!<br>");
            response.end("Haben sie einen schönen Tag!");
            console.log("Anfrage von " + FelderDesFormulars.email + " bearbeitet!");
        }
    });
});


app.get('/addition', (request,response)=>{
    let x = Number(request.query.x); // 10
    let y = Number(request.query.y); // 20
    let result = x + y; // 30
    response.writeHead(200,{'Content-Type': 'application/json'});
    response.end('{ "ergebnis" : ' + result + '}'); // -> {"result": 30}               , "x":10, "y":20}
    console.log("API request handled for x="+x+" and y=" + y + "\n result = " + result);
})

app.listen(8080);
console.log("Listening on port 8080");