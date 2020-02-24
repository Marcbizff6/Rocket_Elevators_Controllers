using System.Net.WebSockets;
using System;

namespace Rocket_Elevators_Controllers
{

  public class Column {
    public int id;
    public int numberOfFloors;
    public int numberOfElevator;
    public int elevatorList;

    public void Info()
    {
      System.Console.WriteLine("Hello, my id is " + id + " and my number of floors is " + numberOfFloors);
    }
  }








  
  class Program
  {
    static void Main(string[] args)

  {
  // int[]totalFloors = {};
  Column columnA = new Column();
  columnA.id = 1;
  columnA.numberOfFloors = 2;
  columnA.Info();
      // var columnTotal = 4;
      // var columnAboveGround = 3;
      // var columnBasement = 1;
      // var elevatorByColumn = 5;<
      // var totalFloors = 66;
      // var floorNumber = [66];
      // var basementTotal = 6;
      // var aboveGroundFloor = totalFloors - basementTotal;
      // var packOfFloor = aboveGroundFloor / columnAboveGround;
      // var RC = 1;
      // int[] ColumnARange = {1, 2};
      // System.Console.WriteLine(ColumnARange[1]);
      // ColumnAboveGroundA deserve RC + basement // array = [firstBasement TO lastBasement + RC]
      // ColumnAboveGroundB deserve RC + packOfFloor // array = [RC + 2 TO 20]
      // ColumnAboveGroundB deserve RC + packOfFloor // array = [RC + 21 TO 40]
      // ColumnAboveGroundB deserve RC + packOfFloor // array = [RC + 41 TO 60]
      // floorID [-5, -4, ... 59, 60]
      // basement = totalFloor[0 to 5]

      // // Creation of floorNumber array
      // int[] basementNumber = new int[totalFloors];
      // for (var i = 0; i < basementTotal; i++)
      // {
      //   basementNumber[i] = i;
      //   System.Console.WriteLine("Basement Number is : " + basementNumber[i]);
      // }

      // int[] rcNumber = new int[totalFloors];
      // for (var i = basementTotal; i == basementTotal; i++)
      // {
      //   rcNumber[i] = i;
      //   System.Console.WriteLine("Rc Number is : " + rcNumber[i]);
      // }

      // int[] aboveGroundFloorNumber = new int[totalFloors];
      // for (var i = basementTotal+1; i < totalFloors; i++)
      // {
      //   aboveGroundFloorNumber[i] = i;
      //   System.Console.WriteLine("Above ground floor Number is : " + aboveGroundFloorNumber[i]);
      // }

      // for (var i = 0; i < floorNumber.Length; i++)
      // {
      //   floorNumber[i] = i;
      //   System.Console.WriteLine("Floor Number is : " + floorNumber[i]);
      // }
      // System.Console.WriteLine(basementNumber[1]);
      // System.Console.WriteLine(rcNumber[1]);
      // System.Console.WriteLine(totalFloors[1]);
   }
  }
}