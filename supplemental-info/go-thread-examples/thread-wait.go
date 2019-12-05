package main

import (
	"fmt"
	"sync"
	"time"
)

func doSomething(seconds time.Duration, wg *sync.WaitGroup) {
	defer wg.Done()

	time.Sleep(time.Second * seconds)
	fmt.Println(seconds)
}

func main() {
	var wg sync.WaitGroup

	wg.Add(1)
	go doSomething(4, &wg)

	wg.Add(1)
	go doSomething(3, &wg)

	wg.Add(1)
	go doSomething(2, &wg)

	wg.Add(1)
	go doSomething(1, &wg)

	wg.Add(1)
	go doSomething(5, &wg)

	wg.Wait()

	fmt.Println("Done")
}
