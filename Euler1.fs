// Learn more about F# at http://fsharp.net

//Problem 1
//05 October 2001
//
//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
//The sum of these multiples is 23.
//
//Find the sum of all the multiples of 3 or 5 below 1000.

namespace Euler

    module Euler1

        let divisibleNums (number) =

            let isDivisible (num, divisor) =
                num % divisor = 0

            [1..number]
            |> Seq.filter(fun x -> isDivisible (x, 3) || isDivisible (x, 5))
            |> Seq.sum

        divisibleNums(10)


        let shorterNums (number) =
            Seq.sum([1..number] |> Seq.filter(fun x -> (x % 3 = 0) || (x % 5 = 0)))

        shorterNums(9)
        // 233168