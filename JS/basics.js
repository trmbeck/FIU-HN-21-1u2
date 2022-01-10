// Kommentare
// Type: Number 64-Bit

let a = 10 + "Hallo";
console.log(a);

a = 10 + "20";
console.log(a);

a = 10 - "20";
console.log(a);

// spezielle Werte von Number
// NaN -> Not a Number
a = 10 - "Hallo";
console.log(a);

if (isNaN(a)){
    console.log("a ist kein Zahlenwert");
}

//  Infinity -> größer als ca 1,8 * 10 hoch 10308
// -Infinity -> kleiner als ca. -1,8 * 10 hoch 10308

a = 10_000;
console.log(a);

let b = -10;
for (let i=0; i < 10000; i++){
    a *= a;
    b = b * b * b;
}

console.log(a); // +unendlich
console.log(b); // -unendlich

// undefined
let c;
console.log(c);

c = 10 - 5 * 4 - 2; // Klammer vor Punkt, Punkt vor Strich

// Zeichenfolgen
// Literale

let zeichenfolge = "Hallo FIU";    console.log(zeichenfolge);
zeichenfolge = 'Hallo FIU';         console.log(zeichenfolge);
zeichenfolge = "Hallo \"FIU\"";     console.log(zeichenfolge);
zeichenfolge = 'Hallo \'FUI\'';     console.log(zeichenfolge);
zeichenfolge = "Hallo 'FIU'";       console.log(zeichenfolge);
zeichenfolge = 'Hallo "FIU"';       console.log(zeichenfolge);
console.log(zeichenfolge[1]);

//Boolean Type
let big = 10000;
let small = "10000";
console.log(big > small);
console.log(big == small);  //keine Typprüfung
console.log(big === small); //mit Typprüfung

function meineFunktion(){
    console.log("Funktionsaufruf erfolgt");
}

meineFunktion();

meine2teFunktion(10); //funktioniert, wegen function hoisting

function meine2teFunktion(param1){
    console.log("Funktionsaufruf mit Parameter " + param1);
}

function add(x, y){
    return x + y;
}

let result = add(2,3);
console.log(result);

result = add(3,4,5);
console.log(result);

result = add(2)
console.log(result);

let Addiere = add; // Delegate
console.log(Addiere(4,5));


let plusFunktion = function(x,y){           //anonyme Funktionen
    return x + y;
}

plusFunktion = (x,y) => { return x + y }    //lambda expressioned function

console.log(plusFunktion(234,325));

//Prüfen, ob eine Variable einen Wert aufweist
let wert;
if (wert){ //false, wenn Wert: 0, "", isNaN, null, undefined
    console.log("Die Variable hat einen Wert");
}else{
    console.log("Die Variable hat keinen Wert");
}

// coalescing operators (sich vereinigend)
let customer = ""; //Eingabe des Anwenders
let company = "";
console.log("Hello " + (customer || company || "Kunde"));

// nullish coalescing operators
let student = "Susi";
let s = student ?? 'hans';
console.log(s);

// ternary operator
let kundenStatus = customer === "Hans" ? "VIP" : "normaler Kunde";

try{
    undefinedFunction(bla, fasel);
    console.log("Ausgabe");
}catch(ex){
    console.log(ex.message);
}finally{
    console.log("Finalisieren");
}
inf = Infinity;

