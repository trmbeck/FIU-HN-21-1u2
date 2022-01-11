const { request, response } = require('express');
let express = require('express');
let app = express();


// URL: http://hostname.dnsSLD.dnsTLD/start.html
app.use(express.static(__dirname + '/wwwroot',{index: false}));

// URL: http://hostname.dnsSLD.dnsTLD/path1/path2/file.html
app.get("/", (request,response) => {
    console.log("URL: " + request.url);
    console.log("Strasse: ");
    console.log(request.query.Strasse);
    console.log(request.query.ort);
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
    
});


app.listen(8080);
console.log("Listening on port 8080");