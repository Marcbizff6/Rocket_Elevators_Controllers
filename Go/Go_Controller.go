package main

// package Go

import (
	"fmt"
	// "math"
	// "sort"
)

//                                      *****STRUCTURES*****
type controller struct {
	id         int
	nbColumn   int
	columnList []column
}
type column struct {
	id            int
	nbElevator    int
	totalFloor    int
	totalBasement int
	elevatorList  []elevator
	floorList     []floors
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

func calc(x, y int) (out1, out2 int) {
	out1 = x + y
	out2 = x - y
	return
}

func main() {
	fmt.Println("Hello World")

	num1 := 5
	num2 := 4

	result1, result2 := calc(num1, num2)
	fmt.Println(result1, result2)

}
