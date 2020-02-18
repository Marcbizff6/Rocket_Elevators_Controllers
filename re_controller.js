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

            for (var i = 0; i < nbElevator; i++){
                var elevator = new Elevator (i, nbFloors)
                    this.elevatorList.push(elevator)
            }
    }
}

class CallButtonClass {
    constructor(direction, floor){
        this.direction = direction;
        this.floor = floor;
        this.light = "off"
    }
}

class FloorButtonClass {
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


        for (var i = 1; i <= floorRequestedButton; i++) {
            var FloorButton = new FloorButtonClass (i, i)
                this.floorRequestedButton.push(FloorButton)
            }

    }
}

var Column1 = new Column (1, 2, 10);

console.log(Column1)
