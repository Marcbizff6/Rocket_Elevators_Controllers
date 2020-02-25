using System;
using System.Collections.Generic;

namespace Rocket_Elevators_Controllers
{
  class Controller
  {
    public int id;
    public int nbColumn;

    public List<Column> columns;
    // public List<Floor> floors;

    public Controller(int id, int nbColumn, int nbElevator, int nbFloor)
    {
      this.id = id;
      this.nbColumn = nbColumn;

      columns = new List<Column>();

      for (var i = 0; i < nbColumn; i++)
      {
        Column column = new Column(i + 1, nbElevator, nbFloor);
        columns.Add(column);
        Console.WriteLine("Column id : " + columns[i].id + "\n");
      }
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
        Elevator elevator = new Elevator(i + 1, 1);
        elevators.Add(elevator);
        Console.WriteLine("Elevator id : " + elevators[i].id + " on currentFloor : " + elevators[i].currentFloor);

      }
      for (var j = 0; j < 4; j++)
      {
        for (var i = 0; i < nbFloor; i++)
        {
          Floor floor = new Floor(i + 1);
          floors.Add(floor);
          System.Console.WriteLine("Floor # : " + floors[i].id);
        }
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
    public int currentFloor;

    public Elevator(int id, int currentFloor)
    {
      this.id = id;
      this.currentFloor = currentFloor;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {

      var totalFloor = 66;

      // Creation of the floor list
      int[] floorList = new int[totalFloor];
      for (int i = 0; i < totalFloor; i++)
      {
        floorList[i] = i + 1;
        // Console.WriteLine("Floor id : " + floorList[i]);
      }

      // Elevator Elevator1 = new Elevator(1, 20);
      // Console.WriteLine("Elevator id : " + Elevator1.id);
      // Console.WriteLine("Elevator currentFloor : " + Elevator1.currentFloor + "\n" );

      // Column Column1 = new Column(1, 5, 20);
      Controller Controller1 = new Controller(1, 4, 5, 20);

    }
  }
}

