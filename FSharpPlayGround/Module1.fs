namespace FSharpPlayGround

module Module1 =
    
    open System

    let createItem1 =
        Console.WriteLine("Hello from method createItem1")

    let createItem2 =
        Console.WriteLine("Hello from method createItem2")
        Seq.empty<string>

