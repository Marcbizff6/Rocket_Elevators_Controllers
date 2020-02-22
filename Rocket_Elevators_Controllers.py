import random
import math

lineBreak = '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
bestElevator = []

# ------------- CLASS SECTION -------------
class Column:
  def __init__ (self, id, nbElevator, nbFloors):
    self.id = id
    self.nbElevator = nbElevator
    self.elevatorList = []
    self.floorList = []
    self.callButtonList = []

    for i in range(1, nbFloors+1):
      if i != 1:
        self.callButtonList.append(CallButtonClass("down", i))

      if i != nbFloors:
        self.callButtonList.append(CallButtonClass("up", i))

    for i in range(nbElevator):
      self.elevatorList.append(Elevator(i, ""))

  def requestElevator(self, requestedFloor, direction):
    thebestelevator = self.findElevator(requestedFloor, direction)
    print(thebestelevator)
    print("\n")
    thebestelevator.moveElevator(requestedFloor)
    return thebestelevator

  def requestFloor(self, elevator, requestedFloor):
    thebestelevator.moveElevator(requestedFloor)

  def findElevator(self, requestedFloor, direction):

    print(lineBreak);
    print(requestedFloor, "is", requestedFloor, "\nand direction is ", direction, "\n")
    print(lineBreak, "\n")

    scoreList = [9999]
    bestElevator = [9999]
    bestElevatorCurrentFloor = [9999]
    gap = []

    for elevator in self.elevatorList:
      if(elevator.currentFloor == requestedFloor and elevator.direction == direction):
        Elevator.score = 1
      elif(elevator.currentFloor != requestedFloor and elevator.direction == direction):
        Elevator.score = 2
      elif(elevator.direction == "idle"):
        Elevator.score = 3
      elif(elevator.currentFloor == requestedFloor and elevator.direction != direction):
        Elevator.score = 4
      elif(elevator.currentFloor != requestedFloor and elevator.direction != direction):
        Elevator.score = 5

      scoreList.append(elevator) 
      print(scoreList)
    
    scoreList.sort(key=lambda x: x.score)
    lowestScore = scoreList[0]
    return lowestScore

    if (elevator.score < scoreList[0]):
        scoreList.shift()
        scoreList.append(elevator.score)
        #print("scoreList :", scoreList)

        bestElevator.shift()
        bestElevator.append(elevator.id)
        #print("bestElevator :", bestElevator}`)

        bestElevatorCurrentFloor.shift()
        bestElevatorCurrentFloor.append(elevator.currentFloor)
        #print("bestElevatorCurrentFloor :", bestElevator)

        gap.shift()
        gap.append(abs(elevator.currentFloor - requestedFloor))

        print(lineBreak)
        print("Elevator.id =", Elevator.id, "\nElevator.currentFloor =", Elevator.currentFloor,"\nElevator.direction =", Elevator.direction, "\nElevator.score =", Elevator.score, "\ngap =", gap, "\n")
        print(lineBreak, "\n")
        return elevator

        if (elevator.score == scoreList[0]):
          gap.append(abs(Elevator.currentFloor - requestedFloor));
          print("Gap", gap)
      
        if (gap[0] > gap[1]):
          gap.shift()

          bestElevator.shift()
          bestElevator.append(elevator.id)

        print(lineBreak)
        print("Elevator.id =", Elevator.id, "\nElevator.currentFloor =", Elevator.currentFloor,"\nElevator.direction =", Elevator.direction, "\nElevator.score =", Elevator.score, "\ngap =", gap, "\n")
        print(lineBreak, "\n")

        return elevator

    print("Best Elevator", bestElevator, "\n")
    
    chosenElevator = self.elevatorList.find(elevator in elevator.id == bestElevator[0])
    return chosenElevator



class CallButtonClass:
  def __init__ (self, direction, floor):
    self.direction = direction
    self.floor = floor
    self.light = "off"

class Elevator:
  def __init__ (self, id, currentFloor):
    self.id = id
    self.floorRequestedButton = []
    self.doors = "closed"
    self.direction = "idle"
    self.currentFloor = currentFloor
    self.requestList = []
    self.score = None

  def moveElevator(self, floorRequestedButton):
    x = abs(self.currentFloor - floorRequestedButton)
    for i in range(floorRequestedButton):
      if self.currentFloor < floorRequestedButton:
        self.direction = "up"
        print("self floor : ", self.currentFloor)
        self.currentFloor +=1
        print("move up to floor : ", self.currentFloor)
        print("up to self floor : ", floorRequestedButton)
        print("\n")
        self.direction = "idle" 


    for i in range(1, x+1):
      if (self.currentFloor > floorRequestedButton):
        self.direction = "down"
        print("self floor : ", self.currentFloor)
        self.direction -= 1
        print("move down to floor : ", self.currentFloor)
        print("down to self floor : ", floorRequestedButton)
        print("\n")
        self.direction = "idle"     
        print("door_open")
        print("close_open \n")

# ------------- FUNCTION SECTION -------------

# displayElevatorInfo() : Display the info of elevators to better pinpoint useful informations
def displayElevatorInfo(self):
  for i in Column1.nbElevator:
    print("id : ", Column1.elevatorList[i].id)
    print("floorRequestedButton : ", Column1.elevatorList[i].floorRequestedButton)
    print("doors : ", Column1.elevatorList[i].doors)
    print("direction : ", Column1.elevatorList[i].direction)
    print("currentFloor : ", Column1.elevatorList[i].currentFloor)
    print("requestList : ", Column1.elevatorList[i].requestList)
    print("score : ", Column1.elevatorList[i].score)
    print("\n")

# displayColumnInfo() : Display the info of Column to better pinpoint useful informations
def displayColumnInfo(self):
  print("Column id : ", Column1.id)
  print("Column nbElevator : ", Column1.nbElevator)
  print("Column elevatorList : ", Column1.elevatorList)
  print("Column floorList : ", Column1.floorList)
  print("Column callButtonList : ", Column1.callButtonList)
  print("\n");

# displayCallButtonList() : Display the info of Button to better pinpoint useful informations
def displayCallButtonList(self):
  for i in range(len(Column1.callButtonList)):
    print("Button ", i, " direction : ", Column1.callButtonList[i].direction)
    print("Button ", i, " floor : ", Column1.callButtonList[i].floor)
    # print("Button " , i , " light : ", Column1.callButtonList[i].light)
    print("\n")

# displayInfo() : Display all the info of display functions
def displayInfo(self):
  displayElevatorInfo(self)
  displayColumnInfo(self)
  displayCallButtonList(self)

# ------------- CREATION AND ON SCREEN DISPLAY SECTION -------------


# callElevator()

# ------------- CREATION AND ON SCREEN DISPLAY SECTION -------------

# floorRandom1 = math.ceil(random() * 10)
# floorRandom2 = math.ceil(math.random() * 10)
# floorRandom3 = math.ceil(math.random() * 10)
# directionArray = ["idle", "up", "down"]
# x1 = math.floor(math.random() * 3)
# x2 = math.floor(math.random() * 3)
# directionRandom1 = directionArray[x1]
# directionRandom2 = directionArray[x2]

# ----------------------------------------
# ------------- TEST SECTION -------------
# ----------------------------------------

# Column1.elevatorList[0].currentFloor = floorRandom1; Column1.elevatorList[0].direction = directionRandom1;
# Column1.elevatorList[1].currentFloor = floorRandom2; Column1.elevatorList[1].direction = directionRandom2;
# Column1.elevatorList[2].currentFloor = floorRandom3; Column1.elevatorList[1].direction = directionRandom2;

# ------------- SCENE #1  -------------
Column1 = Column(1, 2, 10)
Column1.elevatorList[0].currentFloor = 2
Column1.elevatorList[0].direction = "idle"
Column1.elevatorList[1].currentFloor = 6
Column1.elevatorList[1].direction = "idle"
thebestelevator = Column1.requestElevator(3, "up")
Column1.requestFloor(thebestelevator, 7)
# Column1.requestElevator(3, 'up')

# ------------- SCENE #2.1  -------------
# Column1 = Column(1, 2, 10)
# Column1.elevatorList[0].currentFloor = 10
# Column1.elevatorList[0].direction = "idle"
# Column1.elevatorList[1].currentFloor = 3
# Column1.elevatorList[1].direction = "idle"

# elevatorscenario2_1 = Column1.requestElevator(1, 'up')
# Column1.requestFloor(elevatorscenario2_1, 6)

# elevatorscenario2_2 = Column1.requestElevator(3, 'up')
# Column1.requestFloor(elevatorscenario2_2, 5)

# elevatorscenario2_3 = Column1.requestElevator(9, 'down')
# Column1.requestFloor(elevatorscenario2_2, 2)

# ------------- SCENE #3.1  -------------
# Column1 = Column(1, 2, 10)
# Column1.elevatorList[0].currentFloor = 10
# Column1.elevatorList[0].direction = "idle";
# Column1.elevatorList[1].currentFloor = 3
# Column1.elevatorList[1].direction = "up"

# elevatorscenario3_1 = Column1.requestElevator(3, 'down')
# Column1.requestFloor(elevatorscenario3_1, 2)

# elevatorscenario3_0 = Column1.requestElevator(3, 'up')
# Column1.requestFloor(elevatorscenario3_0, 6)

# elevatorscenario3_2 = Column1.requestElevator(10, 'down')
# Column1.requestFloor(elevatorscenario3_2, 3)

displayInfo()
