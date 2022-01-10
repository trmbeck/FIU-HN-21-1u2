//Arrays

let items = new Array();
items[0] = "pepperoni";
items[1] = "onion";
items[2] = 10;

let elemente = new Array("pepperoni", "onion", 20);

let zutaten = ["pepper", "bacon", 40];

let item = items[1];

let belag = items.concat(zutaten, elemente);

console.log(belag);

console.log(belag.indexOf("bacon"));

console.log(belag.join());

console.log(belag.lastIndexOf("onion"));

console.log(belag.sort());

console.log(belag.reverse());

let stack = new Array(10,20,40);

stack.push(50);

console.log(stack);

let element = stack.pop(); 
console.log(element);
console.log(stack);


element = stack.shift(); // erste stelle entfernen
console.log(element);
console.log(stack);

stack.unshift(10);  //an erster stelle einfügen
console.log(stack);

stack.splice(1,1,15,20,25,30,35);  // entfernen/ersetzen von elementen
console.log(stack);

let neuesArray = stack.slice(2,5);
console.log(neuesArray);

console.log("Hallo Welt".slice(-4));


//Objekte

// object literal pattern
let car1 = {
    year: 2000,
    make: 'Ford',
    model: 'Fusion',
    repairs: ['repair1', 'repair2','repair3'],
    getInfo: function(){
        return 'Vehicle: ' + this.year + ' ' + this.make + ' ' + this.model;
    }
}

console.log(car1.getInfo());
console.log(typeof(car1));

// factory pattern
function getVehicle(theYear, theMake, theModel){
    let vehicle = new Object();
    vehicle.year = theYear;
    vehicle.make = theMake;
    vehicle.model = theModel;
    vehicle.getInfo = function(){
        return 'Vehicle: ' + this.year + ' ' + this.make + ' ' + this.model;
    }
    return vehicle;
}

let car2 = getVehicle(2010,"BMW","Z3");
console.log(car2.getInfo());
console.log(typeof(car2));

function Vehicle(theYear, theMake, theModel){
    let year = theYear;
    let make = theMake;
    let model = theModel;
    this.getInfo = function(){
        return 'Vehicle: ' + year + ' ' + make + ' ' + model;
    }
}

let car3 = new Vehicle(2020,"VW","Golf");
console.log(car3.getInfo());

let car4 = new Vehicle(1982,"deLoreen","deLoreen");
console.log(car4.getInfo());

