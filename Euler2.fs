﻿module Euler2

//Each new term in the Fibonacci sequence is generated by adding the previous two terms.
//By starting with 1 and 2, the first 10 terms will be:

//1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

//By considering the terms in the Fibonacci sequence whose values do not exceed four million,
//find the sum of the even-valued terms.
    let evenFibs = []

    let fib = Seq.unfold (fun state ->
        if (snd state > 4000000) then None
        else Some(fst state + snd state, (snd state, fst state + snd state))) (1,1)

    let rec fibby (twoNums, max) =
        if ((fst twoNums) + (snd twoNums) > max)
        then snd twoNums 
        else fibby ((snd twoNums, fst (twoNums) + (snd twoNums)), max)

    let rec evenFibby (twoNums, runningTotal, max) =
        if ((fst twoNums) + (snd twoNums) > max)
        then evensList
        else
            let newEvens = 
                if (snd twoNums % 2 = 0) 
                then 
                    printfn "%d" (snd twoNums)
                    let newTotal = (runningTotal + (snd twoNums))
                else runningTotal
            evenFibby ((snd twoNums, fst (twoNums) + (snd twoNums)), runningTotal, max)

    let evens numbers = 
        let evens, odds = List.partition (fun number -> number % 2 = 0) numbers
        evens

    let numbers = evens [1 .. 10]
    printfn "numbers: %A" numbers


    let result = evenFibby ((0,1), 0, 4000000) |> Seq.sum

    