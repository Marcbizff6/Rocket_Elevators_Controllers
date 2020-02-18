
    class User {
        constructor(firstname, lastname, credit){
            this.firstname = firstname
            this.lastname = lastname
            this.credit = credit
        }
        getFullName(){
            let fullname = this.firstname + " " + this.lastname;
            return fullname
        }
    }

    const john = new User("John", "Anderson", 34)
    console.log(john.credit)
    console.log(john.getFullName())

class controller {
    constructor(elevator, floor, direction){
        this.elevator = elevator
        this.floor = floor
        this.direction = direction
    }
        move(x){
            this.floor = x;
            console.log("x : " + this.x)
            console.log("elevator : " + this.elevator)
            console.log("direction : " + this.direction)
            console.log("moving to : " + this.floor)
        }
}

    const controller1 = new controller ("elevator1", 1, "up")
    console.log(controller1)
    console.log(controller1.elevator)
    console.log(controller1.move)

class elevator {
    constructor(elevator, floor, direction){
        this.elevator = elevator
        this.floor = floor
        this.direction = direction
    }
}

controller1.move(22)