
// ------------- CLASS SECTION -------------
class Column {
    constructor(id, nbElevator,nbFloors) {
        this.id = id;
        this.nbElevator = nbElevator
        this.elevatorList = [];
        this.floorList = [];
        this.callButtonList= [];
        
        for (var i = 1; i <= nbFloors; i++) {
            if (i != 1) {
                var callButton = new CallButtonClass ("down", i)
                    this.callButtonList.push(callButton)
                }
            if (i != nbFloors){
                var callButton = new CallButtonClass ("up", i)
                    this.callButtonList.push(callButton)
                }
            }

            for (var i = 1; i <= nbElevator; i++){
                var elevator = new Elevator (i, nbFloors)
                    this.elevatorList.push(elevator)
            }

        }
            RequestElevator(RequestedFloor, Direction){
                var bestElevator = this.FindElevator(RequestedFloor, Direction)
            }
            
            FindElevator(RequestedFloor, Direction){
                console.log("RequestedFloor is " + RequestedFloor + " and Direction is " + Direction + "\n");
                var scoreList = [];
                console.log("Elevator " + Column1.elevatorList[0].id + " : " + "Floor " + Column1.elevatorList[0].currentFloor + " going " + Column1.elevatorList[0].direction);
                var nearestElevator = Math.abs(Elevator.floor - RequestedFloor);

            // MoveElevator(RequestedFloor, Direction){

            }
}

class CallButtonClass {
    constructor(direction, floor){
        this.direction = direction;
        this.floor = floor;
        this.light = "off"
    }
}

class Elevator {
    constructor(id, floorRequestedButton) {
        this.id = id;
        this.floorRequestedButton = [];
        this.doors = "closed"
        this.direction = "idle"
        this.currentFloor = 2;
        this.requestList = [];
    }
        moveElevator(floorChoice){
            var x = Math.abs(this.currentFloor - floorChoice)
            for (var i = 0; i < x; i++){
                if (this.currentFloor < floorChoice){
                    console.log("this floor : ", this.currentFloor)
                    this.currentFloor ++
                    console.log("move up to floor : ", this.currentFloor)
                    console.log("up to this floor : ", floorChoice)   
                    console.log("\n")
                }
            }

            for (var i = 0; i <= x; i++){
                if (this.currentFloor > floorChoice){
                    console.log("this floor : ", this.currentFloor)
                    this.currentFloor --
                    console.log("move down to floor : ", this.currentFloor)
                    console.log("down to this floor : ", floorChoice)
                    console.log("\n")
                }
            }
    }
}

// ------------- FUNCTION SECTION -------------

// displayElevatorInfo() : Display the info of elevators to better pinpoint useful informations
function displayElevatorInfo(){
    for (var i = 0; i < Column1.nbElevator; i++){
    console.log("id : ", Column1.elevatorList[i].id);
    console.log("floorRequestedButton : ", Column1.elevatorList[i].floorRequestedButton);
    console.log("doors : ", Column1.elevatorList[i].doors);
    console.log("direction : ", Column1.elevatorList[i].direction);
    console.log("currentFloor : ", Column1.elevatorList[i].currentFloor);
    console.log("requestList : ", Column1.elevatorList[i].requestList);
    console.log("\n");
    }
}

// displayColumnInfo() : Display the info of Column to better pinpoint useful informations
function displayColumnInfo(){
    console.log("Column id : ", Column1.id);
    console.log("Column nbElevator : ", Column1.nbElevator);
    console.log("Column elevatorList : ", Column1.elevatorList);
    console.log("Column floorList : ", Column1.floorList);
    console.log("Column callButtonList : ", Column1.callButtonList);
    console.log("\n");
}

// displayCallButtonList() : Display the info of Button to better pinpoint useful informations
function displayCallButtonList(){
    for (var i = 0; i < Column1.callButtonList.length; i++){
    console.log("Button " , i , " direction : ", Column1.callButtonList[i].direction);
    console.log("Button " , i , " floor : ", Column1.callButtonList[i].floor);
    // console.log("Button " , i , " light : ", Column1.callButtonList[i].light);
    console.log("\n")
    }
}

// displayInfo() : Display all the info of display functions
function displayInfo(){
    displayElevatorInfo()
    displayColumnInfo()
    displayCallButtonList()
}

// callElevator() : call the elevator when the callButton is activat
function callElevator(){
    if (Column1.elevatorList[1].currentFloor == Column1.callButtonList[0].floor){
        console.log("callElevator if statement ")
    } else{
        console.log("callElevator else statement")
    } 
}

// ------------- CREATION SECTION -------------
var Column1 = new Column (1, 2, 10);

// ------------- ON SCREEN DISPLAY SECTION -------------

// displayInfo()
// callElevator()
Column1.elevatorList[0].currentFloor = 4;       Column1.elevatorList[0].direction = "UP";
Column1.elevatorList[1].currentFloor = 2;       Column1.elevatorList[1].direction = "UP";

Column1.RequestElevator(5, 'Down');
// Column1.elevatorList[1].moveElevator(5)