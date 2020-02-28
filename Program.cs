﻿using System;
using System.Collections.Generic;
using System.IO.Enumeration;

namespace Rocket_Elevators_Controllers
{
  class Controller
  {
    public int id;
    public int nbColumn;

    public List<Column> columns;

    public Controller(int id, int nbColumn, int nbElevator, int totalFloor, int totalBasement)
    {
      this.id = id;
      this.nbColumn = nbColumn;

      columns = new List<Column>();

      // *************** Creating the column ***************\\
      for (var i = 0; i < nbColumn; i++)
      {
        if (i == 0)
        {
          Column column = new Column(i + 1, nbElevator, totalFloor, totalBasement);
          columns.Add(column);
          // Console.WriteLine("Column id : " + columns[i].id + "\n");

        }
        else if (i == 1)
        {
          Column column = new Column(i + 1, nbElevator, totalFloor, totalBasement);
          columns.Add(column);
          // Console.WriteLine("Column id : " + columns[i].id + "\n");
        }
        else if (i == 2)
        {
          Column column = new Column(i + 1, nbElevator, totalFloor, totalBasement);
          columns.Add(column);
          // Console.WriteLine("Column id : " + columns[i].id + "\n");
        }
        else if (i == 3)
        {
          Column column = new Column(i + 1, nbElevator, totalFloor, totalBasement);
          columns.Add(column);
          // Console.WriteLine("Column id : " + columns[i].id + "\n");
        }
      }
    }

    public Elevator assignElevator(int RequestedFloor)
    {
      var foundColumn = findColumn(RequestedFloor);
      var foundElevator = foundColumn.findElevator(RequestedFloor);
      System.Console.WriteLine("assignElevator : " + foundElevator);
      return foundElevator;
    }

    // *************** Finding the column ***************\\
    public Column findColumn(int requestedFloor)
    {
      Column bestColumn = this.columns[0];
      if (requestedFloor < 1)
      {
        bestColumn = this.columns[0];
        System.Console.WriteLine(this.columns[0] + " " + this.columns[0].id);
      }
      else if (requestedFloor > 1 && requestedFloor <= 20)
      {
        bestColumn = this.columns[1];
        System.Console.WriteLine(this.columns[1] + " " + this.columns[1].id);
      }
      else if (requestedFloor > 20 && requestedFloor <= 40)
      {
        bestColumn = this.columns[2];
        System.Console.WriteLine(this.columns[2] + " " + this.columns[2].id);
      }
      else if (requestedFloor > 40 && requestedFloor <= 60)
      {
        bestColumn = this.columns[3];
        System.Console.WriteLine(this.columns[3] + " " + this.columns[3].id);
      }
      return bestColumn;
    }
  }

  class Column
  {
    public int id;
    public int nbElevator;
    public int totalFloor;
    public int totalBasement;

    public List<Elevator> elevators;
    public List<Floor> floors;

    public Column(int id, int nbElevator, int totalFloor, int totalBasement)
    {
      this.totalFloor = totalFloor;
      this.id = id;
      this.nbElevator = nbElevator;
      this.totalBasement = totalBasement;
      elevators = new List<Elevator>();
      floors = new List<Floor>();

      // *************** creating the elevators ***************\\
      for (var i = 0; i < nbElevator; i++)
      {
        Elevator elevator = new Elevator(i + 1, 1, "idle");
        elevators.Add(elevator);
        // Console.WriteLine("Elevator id : " + elevators[i].id + " on elevatorFloor : " + elevators[i].elevatorFloor);
      }

      //*************** Creation of the floor list ***************\\
      // *************** Setting the id and the direction of each floor ***************\\

      for (var i = 0; i < totalBasement; i++)
      {
        Floor floor = new Floor(i - totalBasement + 1, "up");
        floors.Add(floor);
        // System.Console.WriteLine("Floor id : " + floors[i].id + ", Floor direction : " + floors[i].floorDirection);
      }

      for (var i = totalBasement; i == totalBasement; i++)
      {
        Floor floor = new Floor(i - totalBasement + 1, "idle");
        floors.Add(floor);
        // System.Console.WriteLine("Floor id : " + floors[i].id + ", Floor direction : " + floors[i].floorDirection);
      }

      for (var i = totalBasement + 1; i < totalFloor; i++)
      {
        Floor floor = new Floor(i - totalBasement + 1, "down");
        floors.Add(floor);
      }
    }


    // *************** Find the best elevator ***************\\
    public Elevator findElevator(int requestedFloor) // object column à ajouter
    {
      int bestScore = 9999;
      Elevator bestElevator = null;
      int userFloor = 1;

      if (requestedFloor < 1)
      {
        userFloor = 1;
      }
      else if (requestedFloor > 1)
      {
        userFloor = 1;
      }
      else
      {
        userFloor = requestedFloor;
      }

      var gap = 9999;
      foreach (Elevator elevator in this.elevators)
      {

        // *************** User is on the RC floor ***************\\

        // *************** The elevator is on the same floor as the user ***************\\

        if (userFloor == 1 && elevator.elevatorFloor == userFloor && elevator.elevatorDirection == "up")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 100 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }
        else if (userFloor == 1 && elevator.elevatorFloor == userFloor && elevator.elevatorDirection == "down")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 120 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }
        else if (userFloor == 1 && elevator.elevatorFloor == userFloor && elevator.elevatorDirection == "idle")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 140 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }

        // *************** The elevator is under the user floor ***************\\

        else if (userFloor == 1 && elevator.elevatorFloor < userFloor && elevator.elevatorDirection == "up")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 160 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }
        else if (userFloor == 1 && elevator.elevatorFloor < userFloor && elevator.elevatorDirection == "idle")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 180 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }
        else if (userFloor == 1 && elevator.elevatorFloor < userFloor && elevator.elevatorDirection == "down")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 200 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }

        // *************** The elevator is above the user floor ***************\\

        else if (userFloor == 1 && elevator.elevatorFloor > userFloor && elevator.elevatorDirection == "down")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 220 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }
        else if (userFloor == 1 && elevator.elevatorFloor > userFloor && elevator.elevatorDirection == "idle")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 240 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }
        else if (userFloor == 1 && elevator.elevatorFloor > userFloor && elevator.elevatorDirection == "up")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 260 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }

        // *************** User is under the RC floor ***************\\

        // *************** The elevator is on the same floor as the user ***************\\

        else if (userFloor < 1 && elevator.elevatorFloor == userFloor && elevator.elevatorDirection == "up")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 280 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }
        else if (userFloor < 1 && elevator.elevatorFloor == userFloor && elevator.elevatorDirection == "idle")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 300 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }
        else if (userFloor < 1 && elevator.elevatorFloor == userFloor && elevator.elevatorDirection == "down")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 320 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }

        // *************** The elevator is under the user floor ***************\\

        else if (userFloor < 1 && elevator.elevatorFloor < userFloor && elevator.elevatorDirection == "up")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 340 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }
        else if (userFloor < 1 && elevator.elevatorFloor < userFloor && elevator.elevatorDirection == "idle")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 360 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }
        else if (userFloor < 1 && elevator.elevatorFloor < userFloor && elevator.elevatorDirection == "down")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 380 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }

        // *************** The elevator is above the user floor ***************\\

        else if (userFloor < 1 && elevator.elevatorFloor > userFloor && elevator.elevatorDirection == "idle")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 400 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }
        else if (userFloor < 1 && elevator.elevatorFloor > userFloor && elevator.elevatorDirection == "down")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 420 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }
        else if (userFloor < 1 && elevator.elevatorFloor > userFloor && elevator.elevatorDirection == "up")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 440 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }

        // *************** User is above the RC floor ***************\\

        // *************** The elevator is on the same floor as the user ***************\\

        else if (userFloor > 1 && elevator.elevatorFloor == userFloor && elevator.elevatorDirection == "down")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 460 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }
        else if (userFloor > 1 && elevator.elevatorFloor == userFloor && elevator.elevatorDirection == "idle")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 480 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }
        else if (userFloor > 1 && elevator.elevatorFloor == userFloor && elevator.elevatorDirection == "up")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 500 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }

        // *************** The elevator is under the user floor ***************\\

        else if (userFloor > 1 && elevator.elevatorFloor < userFloor && elevator.elevatorDirection == "idle")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 520 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }
        else if (userFloor > 1 && elevator.elevatorFloor < userFloor && elevator.elevatorDirection == "up")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 540 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }
        else if (userFloor > 1 && elevator.elevatorFloor < userFloor && elevator.elevatorDirection == "down")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 560 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }

        // *************** The elevator is above the user floor ***************\\

        else if (userFloor > 1 && elevator.elevatorFloor > userFloor && elevator.elevatorDirection == "down")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 300 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }
        else if (userFloor > 1 && elevator.elevatorFloor > userFloor && elevator.elevatorDirection == "idle")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 300 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }
        else if (userFloor > 1 && elevator.elevatorFloor > userFloor && elevator.elevatorDirection == "up")
        {
          gap = Math.Abs(elevator.elevatorFloor - userFloor);
          elevator.score = 300 + gap;
          System.Console.WriteLine("Elevator score : " + elevator.score);
          if (elevator.score < bestScore)
          {
            bestScore = elevator.score;
            bestElevator = elevator;
          }
          System.Console.WriteLine("bestScore : " + bestScore + "\n");
        }
      }
      return bestElevator;
    }
  }

  class Floor
  {
    public int id;
    public string floorDirection;

    public Floor(int id, string floorDirection)
    {
      this.id = id;
      this.floorDirection = floorDirection;
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

    // *************** Moving elevator ***************\\
    public void moveElevator(int requestedFloor)
    {
      // *************** Move up ***************\\
      if (this.elevatorFloor < requestedFloor)
      {
        this.elevatorDirection = "up";
        Console.WriteLine("Elevator going : " + this.elevatorDirection);
        while (this.elevatorFloor < requestedFloor)
        {
          this.elevatorFloor++;
          Console.WriteLine("Elevator going : " + this.elevatorFloor);
        }
      }

      // *************** Move down ***************\\
      if (this.elevatorFloor > requestedFloor)
      {
        this.elevatorDirection = "down";
        Console.WriteLine("Elevator going : " + this.elevatorDirection);
        while (this.elevatorFloor > requestedFloor)
        {
          this.elevatorFloor--;
          Console.WriteLine("Elevator going : " + this.elevatorFloor);
        }
      }

      // *************** At the current floor ***************\\
      if (this.elevatorFloor == requestedFloor)
      {
        // this.elevatorDirection = "idle";
        Console.WriteLine("Elevator is at destination : " + requestedFloor + "\n");
        openDoors();
        closeDoors();
      }
    }
    public void openDoors()
    {
      Console.WriteLine("Doors opening");
    }

    public void closeDoors()
    {
      Console.WriteLine("Doors closing");
    }
  }


  class Program
  {
    static void Main(string[] args)
    {
      {
        var totalFloor = 66;
        var totalBasement = 6;
        var RC = totalFloor - totalBasement + 1;

        Controller Controller1 = new Controller(1, 4, 5, totalFloor, totalBasement);

        // Creation of the floor list
        // int[] floorList = new int[totalFloor];
        // for (int i = 0; i < totalBasement; i++)
        // {
        //   floorList[i] = i - totalBasement + 1;
        //   Console.WriteLine("Floor id (basement): " + floorList[i] + "\n");
        // }
        // for (int i = totalBasement; i == totalBasement; i++)
        // {
        //   floorList[i] = i - totalBasement + 1;
        //   Console.WriteLine("RC Floor: " + floorList[i] + "\n");
        // }
        // for (int i = totalBasement + 1; i < totalFloor; i++)
        // {
        //   floorList[i] = i - totalBasement + 1;
        //   Console.WriteLine("Floor id : " + floorList[i] + "\n");
        // }

        // *************** TESTING ***************\\

        // *************** SCENE #1 ***************\\
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
        Controller1.columns[1].elevators[0].elevatorDirection = "down";
        Controller1.columns[1].elevators[1].elevatorFloor = 3;
        Controller1.columns[1].elevators[1].elevatorDirection = "up";
        Controller1.columns[1].elevators[2].elevatorFloor = 13;
        Controller1.columns[1].elevators[2].elevatorDirection = "down";
        Controller1.columns[1].elevators[3].elevatorFloor = 15;
        Controller1.columns[1].elevators[3].elevatorDirection = "down";
        Controller1.columns[1].elevators[4].elevatorFloor = 6;
        Controller1.columns[1].elevators[4].elevatorDirection = "down";
        Controller1.assignElevator(20);


        // *************** SCENE #2 ***************\\

        Controller1.columns[1].elevators[0].elevatorFloor = 20;
        Controller1.columns[1].elevators[0].elevatorDirection = "down";
        Controller1.columns[1].elevators[1].elevatorFloor = 3;
        Controller1.columns[1].elevators[1].elevatorDirection = "up";
        Controller1.columns[1].elevators[2].elevatorFloor = 13;
        Controller1.columns[1].elevators[2].elevatorDirection = "down";
        Controller1.columns[1].elevators[3].elevatorFloor = 15;
        Controller1.columns[1].elevators[3].elevatorDirection = "down";
        Controller1.columns[1].elevators[4].elevatorFloor = 6;
        Controller1.columns[1].elevators[4].elevatorDirection = "down";
        
        // *************** SCENE #3 ***************\\
        // *************** SCENE #4 ***************\\

      }
    }
  }
}
