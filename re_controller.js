
// Variables : elevators related
let elevator = [];
let totalElevator = 2;

//Variables : floors related
let firstFloor = 1;
let lastFloor = 10;
let floorTotal = lastFloor - firstFloor + 1;
let floorList = [];

// Variables : position
let userFloor = 0;
let elevatorFloor = 0;

// Variables : directions

// Functions

// Function to push the number of floor in the array
let addFloorList = function () {
    for (i = firstFloor; i < (lastFloor+1); i++)
    floorList.push(i);
    //Show the elevator array in the console
    console.log("floorTotal : " + floorTotal)
    console.log("floorList : " + floorList)
};

// Push the function to the array
addFloorList();


let moveElevator = function (){
    if (userFloor === elevatorFloor)
        elevatorFloor += 11
        console.log("elevatorFloor : " + elevatorFloor);
}

moveElevator();



class Column {
    constructor(totalFloor, nbElevator) {
       this.totalFloor = totalFloor;
       this.nbElevator = nbElevator;
       this.elevatorList = [];
       for(var i = 0; i<nbElevator; i=i+1) {
           
           this.elevatorList.push(new Elevator(totalFloor, nbElevator));
    }       
    }
}

class Elevator {
    constructor(firstFloor, lastFloor) {
       this.firstFloor = firstFloor;
       this.lastFloor = lastFloor;
        this.floorList
       for(var i = 0; i < lastFloor; i++ ) {
           
        this.elevatorList.push(new Elevator(totalFloor, nbElevator));
 }       

    }
}


const Column1 = new Column (10, 2);
console.log(Column1)