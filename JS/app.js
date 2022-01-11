let http = require("http");
let server = http.createServer(anfrageHandling);
let ip="localhost", port = 8080
server.listen(port,ip); //Socket: IP + Port -> localhost:8080
console.log("Sever running at http://" + ip + ":" + port);


function anfrageHandling(request, response){
    response.writeHead(200,{"Content-Type":"text/plain"});
    response.write("Hällo FIU\n");
    response.end("from Node.js web server");
    console.log("Handled request!");
}