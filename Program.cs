using System.IO.Enumeration;
using System;
using System.Collections.Generic;

namespace Rocket_Elevators_Controllers
{
  class Controller
  {
    public int id;
    public int nbColumn;

    public List<Column> columns;

    public Controller(int id, int nbColumn, int nbElevator, int nbFloor)
    {
      this.id = id;
      this.nbColumn = nbColumn;

      columns = new List<Column>();

      //  Creating the column
      for (var i = 0; i < nbColumn; i++)
      {
        if (i == 0)
        {
          Column column = new Column(i + 1, nbElevator, nbFloor);
          columns.Add(column);
          Console.WriteLine("Column id : " + columns[i].id + "\n");

        }
        else if (i == 1)
        {
          Column column = new Column(i + 1, nbElevator, nbFloor);
          columns.Add(column);
          Console.WriteLine("Column id : " + columns[i].id + "\n");
        }
        else if (i == 2)
        {
          Column column = new Column(i + 1, nbElevator, nbFloor);
          columns.Add(column);
          Console.WriteLine("Column id : " + columns[i].id + "\n");
        }
        else if (i == 3)
        {
          Column column = new Column(i + 1, nbElevator, nbFloor);
          columns.Add(column);
          Console.WriteLine("Column id : " + columns[i].id + "\n");
        }
      }
    }

    // Finding the column
    public void findColumn(int requestedFloor)
    {
      if (requestedFloor < 1)
      {
        System.Console.WriteLine("findColumn : " + columns[0] + " " + columns[0].id);
        columns[0].findElevator(requestedFloor);
      }
      else if (requestedFloor > 1 && requestedFloor <= 20)
      {
        System.Console.WriteLine("findColumn : " + columns[1] + " " + columns[1].id);
        columns[1].findElevator(requestedFloor);
      }
      else if (requestedFloor > 20 && requestedFloor <= 40)
      {
        System.Console.WriteLine("findColumn : " + columns[2] + " " + columns[2].id);
        columns[2].findElevator(requestedFloor);
      }
      else if (requestedFloor > 40 && requestedFloor <= 60)
      {
        System.Console.WriteLine("findColumn : " + columns[3] + " " + columns[3].id);
        columns[3].findElevator(requestedFloor);
      }
      // else if (requestedFloor == 7)
      // {
      //   System.Console.WriteLine("findColumn : " + columns[2].id);
      //   columns[3].findElevator(requestedFloor);
      // }
      System.Console.WriteLine("end of requestedFloor # : " + requestedFloor + "\n");
    }
  }

  class Column
  {
    public int id;
    public int nbElevator;
    public int nbFloor;

    public List<Elevator> elevators;
    public List<Floor> floors;

    public Column(int id, int nbElevator, int nbFloor)
    {
      this.nbFloor = nbFloor;
      this.id = id;
      this.nbElevator = nbElevator;
      elevators = new List<Elevator>();
      floors = new List<Floor>();

      for (var i = 0; i < nbElevator; i++)
      {
        Elevator elevator = new Elevator(i + 1, 1, "idle");
        elevators.Add(elevator);
        // Console.WriteLine("Elevator id : " + elevators[i].id + " on elevatorFloor : " + elevators[i].elevatorFloor);
      }

      // for (var i = 0; i < nbFloor; i++)
      // {
      //   Floor floor = new Floor(i + 1);
      //   floors.Add(floor);
      //   System.Console.WriteLine("Floor # : " + floors[i].id);
      // }
    }

    // Find the best elevator
    public void findElevator(int requestedFloor)
    {
      foreach (var elevator in elevators)
      {
        if (elevator.elevatorFloor == requestedFloor)
        {
          elevator.score = 1;
          System.Console.WriteLine("Elevator score : " + elevator.score);
        }
        else if (elevator.elevatorFloor != requestedFloor)
        {
          elevator.score = 2;
          System.Console.WriteLine("Elevator score : " + elevator.score);
        }


      }
      // if (requestedFloor < 20)
      // {
      //   foreach (var elevator in elevators)
      //   {

      //     System.Console.WriteLine("findElevator with this id : " + elevators[0].id);
      //   }
      // }
      // else if (requestedFloor >= 20)
      // {
      //   System.Console.WriteLine("findElevator with this id : " + elevators[1].id);
      // }
    }
  }

  class Floor
  {
    public int id;

    public Floor(int id)
    {
      this.id = id;
    }
  }

  class Elevator
  {
    public int id;
    public int elevatorFloor;
    public int score;
    public string elevatorDirection;

    public Elevator(int id, int elevatorFloor, string elevatorDirection)
    {
      this.id = id;
      this.elevatorFloor = elevatorFloor;
      this.elevatorDirection = elevatorDirection;
    }

    // Moving elevator
    public void moveElevator(int requestedFloor)
    {
      // Move up
      if (this.elevatorFloor < requestedFloor)
      {
        Console.WriteLine("Elevator going : ", this.elevatorDirection);
        while (this.elevatorFloor < requestedFloor)
        {
          this.elevatorFloor++;
          Console.WriteLine("Elevator going : ", this.elevatorFloor);
        }
      }

      // Moving down
      if (this.elevatorFloor > requestedFloor)
      {
        Console.WriteLine("MOVING : Elevator is moving", this.elevatorDirection);
        while (this.elevatorFloor > requestedFloor)
        {
          Console.WriteLine("MOVING : Elevator is now at floor", this.elevatorFloor);
          this.elevatorFloor--;
        }
      }

      // At the current floor
      if (this.elevatorFloor == requestedFloor)
      {
        Console.WriteLine("MOVING : Elevator arrived at floor", requestedFloor);
      }
    }
    public void openDoors()
    {
      Console.WriteLine("DOORS  : Opening the doors to Narnia");
    }

    public void closeDoors()
    {
      Console.WriteLine("DOORS  : Closing the doors to Narnia");
    }
  
}

class Program
{
  static void Main(string[] args)
  {

    var totalFloor = 66;
    var totalBasement = 6;
    var RC = totalFloor - totalBasement + 1;

    Controller Controller1 = new Controller(1, 4, 5, 2);

    // Creation of the floor list
    int[] floorList = new int[totalFloor];
    for (int i = 0; i < totalBasement; i++)
    {
      floorList[i] = i - totalBasement + 1;
      Console.WriteLine("Floor id (basement): " + floorList[i] + "\n");
    }
    for (int i = totalBasement; i == totalBasement; i++)
    {
      floorList[i] = i - totalBasement + 1;
      Console.WriteLine("RC Floor: " + floorList[i] + "\n");
    }
    for (int i = totalBasement + 1; i < totalFloor; i++)
    {
      floorList[i] = i - totalBasement + 1;
      Console.WriteLine("Floor id : " + floorList[i] + "\n");
    }

    // ____________TESTING____________

    // ____________SCENE #1____________
    // Scenario 1:
    // With second column (or column B) serving floors from 2 to 20,
    // with elevator B1 at 20th floor going to 5th,
    // B2 at 3rd floor going to 15th,
    // B3 at 13th floor going to 1st,
    // B4 at 15th floor going to 2nd,
    // and B5 at 6th floor going to 1st,
    // someone is at 1st floor and requests the 20th floor,
    // elevator B5 is expected to be sent
    Controller1.columns[1].elevators[0].elevatorFloor = 20;
    Controller1.columns[1].elevators[1].elevatorFloor = 3;
    Controller1.columns[1].elevators[2].elevatorFloor = 13;
    Controller1.columns[1].elevators[3].elevatorFloor = 15;
    Controller1.columns[1].elevators[4].elevatorFloor = 6;

    Controller1.findColumn(20);

    System.Console.WriteLine(Controller1.columns[1].elevators[0].elevatorFloor);

    // ____________SCENE #2____________
    // ____________SCENE #3____________
    // ____________SCENE #4____________

    // Controller1.findColumn(2);
    // Controller1.findColumn(7);
    // Controller1.findColumn(19);
    // Controller1.findColumn(20);
    // Controller1.findColumn(21);
    // Controller1.findColumn(39);
    // Controller1.findColumn(40);
    // Controller1.findColumn(41);
    // Controller1.findColumn(60);












  }
}
}

