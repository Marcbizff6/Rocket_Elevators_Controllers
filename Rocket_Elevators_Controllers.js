const lineBreak = '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
let bestElevator = [];


// ------------- CLASS SECTION -------------
class Column {
  constructor(id, nbElevator, nbFloors) {
    this.id = id;
    this.nbElevator = nbElevator;
    this.elevatorList = [];
    this.floorList = [];
    this.callButtonList = [];

    for (var i = 1; i <= nbFloors; i++) {
      if (i != 1) {
        this.callButtonList.push(new CallButtonClass("down", i));
      }
      if (i != nbFloors) {
        this.callButtonList.push(new CallButtonClass("up", i));
      }
    }

    for (var i = 0; i < nbElevator; i++) {
      this.elevatorList.push(new Elevator(i, ""));
    }

  }

  requestElevator(requestedFloor, Direction) {
    var thebestelevator = this.findElevator(requestedFloor, Direction);
    console.log(thebestelevator)
    console.log("\n")
    thebestelevator.moveElevator(requestedFloor)
    return thebestelevator
  }

  findElevator(requestedFloor, Direction) {

    console.log(lineBreak);
    console.log(`requestedFloor is ${requestedFloor}\nand direction is ${Direction}\n`);
    console.log(`${lineBreak} \n`);

    let scoreList = [9999];
    let bestElevator = [9999];
    let bestElevatorCurrentFloor = [9999];
    let gap = [];
    this.elevatorList.forEach(Elevator => {

      if (Elevator.currentFloor == requestedFloor && Elevator.direction == Direction) {
        Elevator.score = 1;
      }
      else if (Elevator.currentFloor != requestedFloor && Elevator.direction == Direction) {
        Elevator.score = 2;
      }
      else if (Elevator.direction == "idle") {
        Elevator.score = 3;
      }
      else if (Elevator.currentFloor == requestedFloor && Elevator.direction !== Direction) {
        Elevator.score = 4;
      }
      else if (Elevator.currentFloor != requestedFloor && Elevator.direction !== Direction) {
        Elevator.score = 5;
      }

      if (Elevator.score < scoreList[0]) {
        scoreList.shift();
        scoreList.push(Elevator.score);
        // console.log(`scoreList : ${scoreList}`)

        bestElevator.shift();
        bestElevator.push(Elevator.id);
        // console.log(`bestElevator : ${bestElevator}`)

        bestElevatorCurrentFloor.shift();
        bestElevatorCurrentFloor.push(Elevator.currentFloor);
        // console.log(`bestElevatorCurrentFloor : ${bestElevator}`)

        gap.shift();
        gap.push(Math.abs(Elevator.currentFloor - requestedFloor));

        console.log(lineBreak);
        console.log(`Elevator.id = ${Elevator.id};\nElevator.currentFloor = ${Elevator.currentFloor};\nElevator.direction = ${Elevator.direction};\nElevator.score = ${Elevator.score};\ngap = ${gap}\n`)
        console.log(`${lineBreak} \n`);
        return Elevator

      } if (Elevator.score == scoreList[0])
        gap.push(Math.abs(Elevator.currentFloor - requestedFloor));
      // console.log(`gap : ${gap} \n`)
      if (gap[0] > gap[1]) {
        gap.shift();

        bestElevator.shift();
        bestElevator.push(Elevator.id);

        console.log(lineBreak);
        console.log(`Elevator.id = ${Elevator.id};\nElevator.currentFloor = ${Elevator.currentFloor};\nElevator.direction = ${Elevator.direction};\nElevator.score = ${Elevator.score};\ngap = ${gap}\n`)
        console.log(`${lineBreak} \n`);
        return Elevator
      }
    });
    console.log(`Best Elevator ${bestElevator} \n`)

    var chosenElevator = this.elevatorList.find(elevator => elevator.id == bestElevator[0])
    return chosenElevator
  }

  requestFloor(elevator, requestedFloor) {
    elevator.moveElevator(requestedFloor);
  }
}

class CallButtonClass {
  constructor(direction, floor) {
    this.direction = direction;
    this.floor = floor;
    this.light = "off"
  }
}

class Elevator {
  constructor(id, currentFloor) {
    this.id = id;
    this.floorRequestedButton = [];
    this.doors = "closed"
    this.direction = "idle"
    this.currentFloor = currentFloor;
    this.requestList = [];
    this.score = null;
  }
  moveElevator(floorRequestedButton) {
    var x = Math.abs(this.currentFloor - floorRequestedButton)
    for (var i = 0; i < x; i++) {
      if (this.currentFloor < floorRequestedButton) {
        this.direction = "up"
        console.log("this floor : ", this.currentFloor)
        this.currentFloor++
        console.log("move up to floor : ", this.currentFloor)
        console.log("up to this floor : ", floorRequestedButton)
        console.log("\n")
        this.direction = "idle"
      }
    }

    for (var i = 0; i <= x; i++) {
      if (this.currentFloor > floorRequestedButton) {
        this.direction = "down"
        console.log("this floor : ", this.currentFloor)
        this.currentFloor--
        console.log("move down to floor : ", this.currentFloor)
        console.log("down to this floor : ", floorRequestedButton)
        console.log("\n")
        this.direction = "idle"
      }
    }
    console.log("door_open")
    console.log("close_open \n")
  }
}

// ------------- FUNCTION SECTION -------------

// displayElevatorInfo() : Display the info of elevators to better pinpoint useful informations
function displayElevatorInfo() {
  for (var i = 0; i < Column1.nbElevator; i++) {
    console.log("id : ", Column1.elevatorList[i].id);
    console.log("floorRequestedButton : ", Column1.elevatorList[i].floorRequestedButton);
    console.log("doors : ", Column1.elevatorList[i].doors);
    console.log("direction : ", Column1.elevatorList[i].direction);
    console.log("currentFloor : ", Column1.elevatorList[i].currentFloor);
    console.log("requestList : ", Column1.elevatorList[i].requestList);
    console.log("score : ", Column1.elevatorList[i].score);
    console.log("\n");
  }
}

// displayColumnInfo() : Display the info of Column to better pinpoint useful informations
function displayColumnInfo() {
  console.log("Column id : ", Column1.id);
  console.log("Column nbElevator : ", Column1.nbElevator);
  console.log("Column elevatorList : ", Column1.elevatorList);
  console.log("Column floorList : ", Column1.floorList);
  console.log("Column callButtonList : ", Column1.callButtonList);
  console.log("\n");
}

// displayCallButtonList() : Display the info of Button to better pinpoint useful informations
function displayCallButtonList() {
  for (var i = 0; i < Column1.callButtonList.length; i++) {
    console.log("Button ", i, " direction : ", Column1.callButtonList[i].direction);
    console.log("Button ", i, " floor : ", Column1.callButtonList[i].floor);
    // console.log("Button " , i , " light : ", Column1.callButtonList[i].light);
    console.log("\n")
  }
}

// displayInfo() : Display all the info of display functions
function displayInfo() {
  displayElevatorInfo()
  // displayColumnInfo()
  // displayCallButtonList()
}

// ------------- CREATION AND ON SCREEN DISPLAY SECTION -------------


// callElevator()

// ------------- CREATION AND ON SCREEN DISPLAY SECTION -------------

var floorRandom1 = Math.ceil(Math.random() * 10)
var floorRandom2 = Math.ceil(Math.random() * 10)
var floorRandom3 = Math.ceil(Math.random() * 10)
var directionArray = ["idle", "up", "down"];
var x1 = Math.floor(Math.random() * 3)
var x2 = Math.floor(Math.random() * 3)
var directionRandom1 = directionArray[x1];
var directionRandom2 = directionArray[x2];

// ----------------------------------------
// ------------- TEST SECTION -------------
// ----------------------------------------

// Column1.elevatorList[0].currentFloor = floorRandom1; Column1.elevatorList[0].direction = directionRandom1;
// Column1.elevatorList[1].currentFloor = floorRandom2; Column1.elevatorList[1].direction = directionRandom2;
// Column1.elevatorList[2].currentFloor = floorRandom3; Column1.elevatorList[1].direction = directionRandom2;

// ------------- SCENE #1  -------------
// var Column1 = new Column(1, 2, 10);
// Column1.elevatorList[0].currentFloor = 2; Column1.elevatorList[0].direction = "idle";
// Column1.elevatorList[1].currentFloor = 6; Column1.elevatorList[1].direction = "idle";
// Column1.requestElevator(3, 'up');

// ------------- SCENE #2.1  -------------
// var Column1 = new Column(1, 2, 10);
// Column1.elevatorList[0].currentFloor = 10; Column1.elevatorList[0].direction = "idle";
// Column1.elevatorList[1].currentFloor = 3; Column1.elevatorList[1].direction = "idle";

// var elevatorscenario2_1 = Column1.requestElevator(1, 'up');
// Column1.requestFloor(elevatorscenario2_1, 6);

// var elevatorscenario2_2 = Column1.requestElevator(3, 'up');
// Column1.requestFloor(elevatorscenario2_2, 5);

// var elevatorscenario2_3 = Column1.requestElevator(9, 'down');
// Column1.requestFloor(elevatorscenario2_2, 2);

// ------------- SCENE #3.1  -------------
var Column1 = new Column(1, 2, 10);
Column1.elevatorList[0].currentFloor = 10; Column1.elevatorList[0].direction = "idle";
Column1.elevatorList[1].currentFloor = 3; Column1.elevatorList[1].direction = "up";

var elevatorscenario3_1 = Column1.requestElevator(3, 'down');
Column1.requestFloor(elevatorscenario3_1, 2);

var elevatorscenario3_0 = Column1.requestElevator(3, 'up');
Column1.requestFloor(elevatorscenario3_0, 6);

var elevatorscenario3_2 = Column1.requestElevator(10, 'down');
Column1.requestFloor(elevatorscenario3_2, 3);

displayInfo()
