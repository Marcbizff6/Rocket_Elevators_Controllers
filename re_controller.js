
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