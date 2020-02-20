
// ------------- CLASS SECTION -------------
class Column {
    constructor(id, nbElevator, nbFloors) {
        this.id = id;
        this.nbElevator = nbElevator
        this.elevatorList = [];
        this.floorList = [];
        this.callButtonList = [];

        for (var i = 1; i <= nbFloors; i++) {
            if (i != 1) {
                var callButton = new CallButtonClass("down", i)
                this.callButtonList.push(callButton)
            }
            if (i != nbFloors) {
                var callButton = new CallButtonClass("up", i)
                this.callButtonList.push(callButton)
            }
        }

        for (var i = 1; i <= nbElevator; i++) {
            var elevator = new Elevator(i, nbFloors)
            this.elevatorList.push(elevator)
        }

    }
    RequestElevator(RequestedFloor, Direction) {
        var bestElevator = this.FindElevator(RequestedFloor, Direction)
    }

    FindElevator(RequestedFloor, Direction) {
        console.log("RequestedFloor is " + RequestedFloor + " and Direction is " + Direction + "\n");

        console.log("\n")
        var scoreList = [];
        this.elevatorList.forEach(Elevator => {
            console.log("Elevator # " + Elevator.id + ", on floor " + Elevator.currentFloor + ", going " + Elevator.direction)
            console.log("test : " + Column1.elevatorList[0].currentFloor)
            console.log("\n")

            if (Elevator.currentFloor == RequestedFloor && Elevator.direction == Direction) {
                console.log("Score : 1");
                console.log("\n")
                Elevator.score = 1;
            }

            if (Elevator.currentFloor !== RequestedFloor && Elevator.direction !== Direction) {
                console.log("Score : 2");
                console.log("\n")
                Elevator.score = 2;
            }

        });


        // MoveElevator(RequestedFloor, Direction){
        console.log("\n")
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
    constructor(id, currentFloor, floorRequestedButton) {
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
    displayColumnInfo()
    displayCallButtonList()
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

displayInfo()
// callElevator()
Column1.RequestElevator(5, 'Down');
Column1.elevatorList[0].currentFloor = 12; Column1.elevatorList[0].direction = "DOWN";
Column1.elevatorList[1].currentFloor = 2; Column1.elevatorList[1].direction = "UP";

console.log("\n")
console.log(Column1.elevatorList[0].currentFloor)
console.log("\n")

Column1.elevatorList[1].moveElevator(5)