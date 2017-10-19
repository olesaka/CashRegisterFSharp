
// set "PATH=%PATH%;C:\Program Files (x86)\Microsoft SDKs\F#\4.0\Framework\v4.0"

// opens the system to allow IO functionality
open System

// create the amount added for tax
let tax = 0.06

// calculates the total including tax of all amounts entered
let calcTotal subTotal = 
    (tax*subTotal) + subTotal

// use recursion to continually ask for input from user
let rec checkout currentAmount =
    let currentAmount = currentAmount|> float
    Console.Write("Please enter an amount or type 'END' to checkout: \n")
    let input = Console.ReadLine()
    match input with
    |"END" ->
        Console.Write("Subtotal: {0}\n", currentAmount)
        Console.Write("Tax: {0}\n", tax)
        Console.Write("Total: {0}\n", calcTotal currentAmount)
        Console.Write("Please enter in a payment: ")
        let payment = Console.ReadLine()
        let change = ((calcTotal currentAmount) - (payment|>float))
        Console.Write("Your change is: {0}", change)

    | _ -> 
        let newAmount = input |> float
        checkout (currentAmount + newAmount)
let start = checkout 0.0


// code clips for the term paper, esentially uselessness

// since x is added to an integer, the return must
// be an integer as well as the parameter x
let addOne x = 
    x + 1


// x cannot change
let x = 5
// y can change
let mutable y = 3

// Correct F# syntax by using "match"
// instead of "if"
let isOne x =
    match x with
    | 1 -> true
    | _ -> false


// sums up a list of numbers between 1 and 5
let sum = Seq.sum [1..5]

// normal function syntax
let doubled x =
    x*x
// recursive function
let rec five x =
    match x with
    |5 -> true
    | _ -> five 5
//add two numbers using a lambda function
let add = fun x y -> x+y












