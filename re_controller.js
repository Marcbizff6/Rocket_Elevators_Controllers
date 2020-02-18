class Column {
    constructor(id, nbFloors) {
        this.id = id;
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

    }
}

class CallButton {
    constructor(direction, floor){
        this.direction = direction;
        this.floor = floor;
        this.light = "off"
    }
}

class Elevator {
    constructor(id, nbFloors) {
        this.id = id;
        this.floorRequestedButton = [];
        this.doors = "closed"
        this.direction = "idle"
        this.currentFloor = 1;
        this.requestList = [];
        }
}

var Column1 = new Column (1, 10);

var Column2 = new Column (1, 10);
var Elevator1 = new Elevator(10,20)
console.log(Column1)
console.log()
console.log(Elevator1)
