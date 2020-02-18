class Column {
    constructor(id, nbElevator,nbFloors) {
        this.id = id;
        this.nbElevator = nbElevator
        this.elevatorList = [];
        this.floorList = [];
        this.callButtonList= [];
        
        for (var i = 1; i <= nbFloors; i++) {
            if (i != 1) {
                var callButton = new CallButton ("down", i)
                    this.callButtonList.push(callButton)
                }
            if (i != nbFloors){
                var callButton = new CallButton ("up", i)
                    this.callButtonList.push(callButton)
                }
            }

            for (var i = 0; i < nbElevator; i++){
                var elevator = new Elevator (i, nbFloors)
                    this.elevatorList.push(elevator)
            }
    }
}

class CallButton {
    constructor(direction, floor){
        this.direction = direction;
        this.floor = floor;
        this.light = "off"
    }
}

class FloorButton {
    constructor(id, floor){
        this.id = id;
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
        this.currentFloor = 1;
        this.requestList = [];

        for (var i = 1; i <= floorRequestedButton; i++){
                this.floorRequestedButton.push(i)

        }
    }
}

var Column1 = new Column (1, 2, 10);
var Column2 = new Column (2, 3, 4);

console.log(Column1)
console.log(Column2)
