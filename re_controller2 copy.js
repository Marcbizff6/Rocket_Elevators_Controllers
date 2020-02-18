class Column {
    constructor(totalFloor, nbElevator) {
        this.totalFloor = totalFloor;
        this.nbElevator = nbElevator;
        this.elevatorList = [];
        
        for(var i = 0; i<nbElevator; i++) { 
            this.elevatorList.push(new Elevator(totalFloor, nbElevator));
        }
    }
}

class Elevator {
    constructor(firstFloor, lastFloor) {
        this.firstFloor = firstFloor;
        this.lastFloor = lastFloor;
        this.floorList = [];
        for(var i = 0; i < lastFloor; i++ ) {
           
        this.floorList.push(firstFloor);
        }
    }
}

class Floor{
    constructor(firstFloor){
        this.firstFloor = firstFloor
    }
}

const Column1 = new Column (10, 2);
const Elevator1 = new Elevator(10,20)
console.log(Column1)
console.log(Elevator1)
