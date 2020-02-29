package main

import "fmt"

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
	totalFloor    int
	totalBasement int
	elevatorList  []elevator
	floorList     []int
}

type elevator struct {
	id                int
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

	// *************** CREATING COLUMN ***************
	for i := 1; i <= numberOfColumn; i++ {
		columns1 := column{
			id:           "Column# " + string(i),
			elevatorList: []elevator{},
			floorList:    []int{}}

	}
	return &controller1
}
func main() {

	// var totalFloor = 20
	// var numberFloorsTotal = 60
	// var numberOfBasement = 6
	// var numberColumn = 4

	controller1 := newController(1, 2, 3, 4)

	fmt.Println("hello worl")
}
