using System.Net.WebSockets;
using System;

namespace Rocket_Elevators_Controllers
{
  class Program
  {
    static void Main(string[] args)
    {
      // var columnTotal = 4;
      // var columnAboveGround = 3;
      // var columnBasement = 1;
      // var elevatorByColumn = 5;
      var totalFloors = 66;
      var basementTotal = 6;
      var aboveGroundFloor = totalFloors - basementTotal;
      // var packOfFloor = aboveGroundFloor / columnAboveGround;
      // var RC = 1;
      // int[] ColumnARange = {1, 2};
      // System.Console.WriteLine(ColumnARange[1]);
      // ColumnAboveGroundA deserve RC + basement // array = [firstBasement TO lastBasement + RC]
      // ColumnAboveGroundB deserve RC + packOfFloor // array = [RC + 2 TO 20]
      // ColumnAboveGroundB deserve RC + packOfFloor // array = [RC + 21 TO 40]
      // ColumnAboveGroundB deserve RC + packOfFloor // array = [RC + 41 TO 60]
      // floorID [-5, -4, ... 59, 60]

      // Creation of floorNumber array
      int[] floorNumber = new int[totalFloors];
      for (var i = 0; i < floorNumber.Length; i++)
      {
        floorNumber[i] = i;
        System.Console.WriteLine("Floor Number is : " + floorNumber[i]);
      }

      // Creation of basementNumber array
      int[] basementNumber = new int[basementTotal];
      for (var i = 0; i < basementNumber.Length; i++)
      {
        basementNumber[i] = i;
        System.Console.WriteLine("Basement floor number is : " + basementNumber[i]);
      }

      // Creation of basementNumber array
      int[] aboveGroundFloorNumber = new int[aboveGroundFloor];
      for (var i = 0; i < aboveGroundFloorNumber.Length; i++)
      {
        aboveGroundFloorNumber[i] = i;
        System.Console.WriteLine("Above the ground floor number is : " + aboveGroundFloorNumber[i]);
      }
    }
  }
}