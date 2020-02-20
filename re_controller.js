
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

    for (var i = 1; i <= nbElevator; i++) {
      this.elevatorList.push(new Elevator(i, ""));
    }

  }
  requestElevator(requestedFloor, Direction) {
    var bestElevator = this.findElevator(requestedFloor, Direction);
  }

  findElevator(requestedFloor, Direction) {
    console.log("requestedFloor is " + requestedFloor + " and Direction is " + Direction);
    let scoreList = [];
    this.elevatorList.forEach(Elevator => {
      console.log("Elevator.id:" + Elevator.id + " Elevator.currentFloor:" + Elevator.currentFloor + " Elevator.direction:" + Elevator.direction)
      if (Elevator.currentFloor == requestedFloor && Elevator.direction == Direction) {
        Elevator.score = 1;
      }
      else if (Elevator.currentFloor < requestedFloor && Elevator.direction == Direction) {
        Elevator.score = 2;
      }
      else if (Elevator.currentFloor > requestedFloor && Elevator.direction == Direction) {
        Elevator.score = 3;
      }
      else if (Elevator.direction == "idle") {
        Elevator.score = 4;
      }
      else if (Elevator.currentFloor == requestedFloor && Elevator.direction !== Direction) {
        Elevator.score = 5;
      }
      else if (Elevator.currentFloor < requestedFloor && Elevator.direction !== Direction) {
        Elevator.score = 6;
      }
      else if (Elevator.currentFloor > requestedFloor && Elevator.direction !== Direction) {
        Elevator.score = 7;
      }
      if (Elevator.score <= 99){
      scoreList.push(Elevator.score, Elevator.id);
      }
    });
    // scoreList.sort();
    console.log(`scoreList: ${scoreList}`)

    // MoveElevator(requestedFloor, Direction){
    console.log(`Return this elevator: ${scoreList[0]}`)
    console.log(`\n`)
    return scoreList[0]
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
        console.log("this floor : ", this.currentFloor)
        this.currentFloor++
        console.log("move up to floor : ", this.currentFloor)
        console.log("up to this floor : ", floorRequestedButton)
        console.log("\n")
      }
    }

    for (var i = 0; i <= x; i++) {
      if (this.currentFloor > floorRequestedButton) {
        console.log("this floor : ", this.currentFloor)
        this.currentFloor--
        console.log("move down to floor : ", this.currentFloor)
        console.log("down to this floor : ", floorRequestedButton)
        console.log("\n")
      }
    }
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

// callElevator() : call the elevator when the callButton is activat
function callElevator() {
  if (Column1.elevatorList[1].currentFloor == Column1.callButtonList[0].floor) {
    console.log("callElevator if statement ")
  } else {
    console.log("callElevator else statement")
  }
}

// ------------- CREATION AND ON SCREEN DISPLAY SECTION -------------
var Column1 = new Column(1, 2, 10);

// callElevator()

// ------------- CREATION AND ON SCREEN DISPLAY SECTION -------------

var floorRandom1 = Math.ceil(Math.random() * 10)
var floorRandom2 = Math.ceil(Math.random() * 5)
var directionArray = ["idle", "up", "down"];
var x1 = Math.floor(Math.random() * 3)
var x2 = Math.floor(Math.random() * 3)
var directionRandom1 = directionArray[x1];
var directionRandom2 = directionArray[x2];

Column1.elevatorList[0].currentFloor = floorRandom1; Column1.elevatorList[0].direction = directionRandom1;
Column1.elevatorList[1].currentFloor = floorRandom2; Column1.elevatorList[1].direction = directionRandom2;

// ------------- TEST SECTION -------------


Column1.requestElevator(floorRandom1, 'down');
// Column1.requestElevator(10, 'up');
// Column1.requestElevator(1, 'down');
// Column1.requestElevator(8, 'down');
// Column1.requestElevator(8, 'up');
// Column1.requestElevator(6, 'down');
// Column1.requestElevator(6, 'up');
// Column1.requestElevator(4, 'down');
// Column1.requestElevator(4, 'up');
// Column1.requestElevator(2, 'down');
// Column1.requestElevator(2, 'up');


displayInfo()
// Column1.findElevator();
// Column1.elevatorList[1].moveElevator(5)
