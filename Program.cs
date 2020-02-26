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

      for (var i = 0; i < nbColumn; i++)
      {
        Column column = new Column(i + 1, nbElevator, nbFloor);
        columns.Add(column);
        // Console.WriteLine("Column id : " + columns[i].id + "\n");
      }

    }
    public void findColumn(int requestedFloor)
    {
      if (requestedFloor < 7)
      {
        System.Console.WriteLine("Column : " + columns[0] + " " + columns[0].id);
        columns[0].findElevator(requestedFloor);
      }
      else if (requestedFloor > 7 && requestedFloor <= 20)
      {
        System.Console.WriteLine("Column : " + columns[1] + " " + columns[1].id);
        columns[1].findElevator(requestedFloor);
      }
      else if (requestedFloor > 20 && requestedFloor <= 40)
      {
        System.Console.WriteLine("Column : " + columns[2] + " " + columns[2].id);
        columns[2].findElevator(requestedFloor);
      }
      else if (requestedFloor > 40 && requestedFloor <= 60)
      {
        System.Console.WriteLine("Column : " + columns[3] + " " + columns[3].id);
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

      for (var k = 0; k < 1; k++)
      {
        for (var i = 0; i < nbElevator; i++)
        {
          Elevator elevator = new Elevator(i + 1, 1);
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
    }
    public void findElevator(int requestedFloor)
    {
      if (requestedFloor < 7 && requestedFloor <= 20)
      {
        System.Console.WriteLine("findElevator with this id : " + elevators[0].id);
      }
      else if (requestedFloor < 20 && requestedFloor <= 40)
      {
        System.Console.WriteLine("findElevator with this id : " + elevators[1].id);
      }
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

    public Elevator(int id, int elevatorFloor)
    {
      this.id = id;
      this.elevatorFloor = elevatorFloor;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {

      var totalFloor = 6;

      Controller Controller1 = new Controller(1, 4, 5, 2);

      // Creation of the floor list
      int[] floorList = new int[totalFloor];
      for (int i = 0; i < totalFloor; i++)
      {
        floorList[i] = i + 1;
        // Console.WriteLine("Floor id : " + floorList[i] + "\n");
      }

      Controller1.findColumn(1);
      // Controller1.findColumn(7);
      Controller1.findColumn(19);
      Controller1.findColumn(20);
      Controller1.findColumn(21);
      Controller1.findColumn(39);
      Controller1.findColumn(40);
      Controller1.findColumn(41);
      Controller1.findColumn(60);
    }
  }
}

