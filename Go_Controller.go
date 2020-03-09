package main

import (
	"fmt"
)

// package Go

// "math"
// "sort"

// *************** STRUCTURES ***************
type controller struct {
	id             int
	numberOfColumn int
	columnList     []column
}
type column struct {
	id            string
	nbElevator    int
	totalFloor    int16
	totalBasement int
	elevatorList  []elevator
	floorList     []floors
}

type elevator struct {
	id                string
	elevatorFloor     int
	elevatorDirection string
	score             int
}

type floors struct {
	id             int
	floorDirection string
}

func newController(nbElevator, totalFloor, numberOfColumn, totalBasement int) *controller {
	controller1 := controller{}
	controller1.numberOfColumn = numberOfColumn

	// *************** CREATING COLUMNS ***************
	for i := 1; i <= numberOfColumn; i++ {
		columns1 := column{
			id:           "Column# " + string(i+48),
			elevatorList: []elevator{},
			floorList:    []floors{}}

		// *************** CREATING ELEVATORS ***************

		for j := 0; j < nbElevator; j++ {
			elev := elevator{
				id:                "elevator# " + string(j+48),
				elevatorFloor:     1,
				elevatorDirection: "idle"}
			columns1.elevatorList = append(columns1.elevatorList, elev)
		}

		// *************** CREATING FLOORS ***************
		// for m := 0; m < 4; m++ {
		for k := 0; k < totalFloor; k++ {
			floorsNum := floors{
				id:             k,
				floorDirection: "down"}
			columns1.floorList = append(columns1.floorList, floorsNum)
		}
		// }
		controller1.columnList = append(controller1.columnList, columns1)
	}

	// for i := 0; i < numberColumn; i++ {
	// 	for k := 1; k <= floorsPerColumn; k++ {
	// 		if i == 0 {
	// 			if k == 1 {
	// 				//                               *****ADDING RC TO COLUMN DEDICATED TO BASEMENT *****
	// 				b.columnList[i].floorList = append(b.columnList[i].floorList, k)
	// 			}
	// 			if k <= numberOfBasement {
	// 				//                                     ***** BASEMENT FLOOR LIST TO COLUMN 0 *****
	// 				b.columnList[i].floorList = append(b.columnList[i].floorList, -k)
	// 			}
	// 		} else if i == 1 {
	// 			//                                            ***** FLOOR 1 TO 20 FOR 1ST COLUMN *****
	// 			b.columnList[i].floorList = append(b.columnList[i].floorList, k)
	// 		} else {
	// 			//                            ***** ADD RC TO EVERY COLUMN THAT ISN'T IN INDEX 0 AND 1 *****
	// 			if k == 1 {
	// 				b.columnList[i].floorList = append(b.columnList[i].floorList, 1)
	// 			}
	// 			//       ***** ADDING FLOORS TO EVERY OTHER COLUMN, FloorsPerColumn BEING THE RANGE OF FLOORS PER COLUMN *****

	// 			b.columnList[i].floorList = append(b.columnList[i].floorList, k+((i-1)*floorsPerColumn))

	// 		}
	// 	}
	// }

	return &controller1
}

func newColumn(id string, nbElevator int, totalFloor int, totalBasement int) {

}

func main() {

	var totalFloor = 66
	var nbElevator = 5
	var totalBasement = 6
	var numberOfColumn = 4
	var numberOfFloorByColumn = 20

	controller1 := newController(nbElevator, totalFloor, numberOfColumn, totalBasement)

	// for using nd testing the controller1 func newController
	controller1.columnList[0].elevatorList[0].elevatorFloor = 2

	fmt.Println(controller1)

	fmt.Println("numberOfFloorByColumn", numberOfFloorByColumn)
}
