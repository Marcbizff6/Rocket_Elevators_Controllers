
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

}
