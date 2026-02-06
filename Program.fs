// For more information see https://aka.ms/fsharp-console-apps
//open ListFunctions
open CSModelling

[<EntryPoint>]

let main _ =
(*    printfn "%d" (doubleNumber 2)
    printfn "%d" (absNumber -2)
    printfn "%d" (greatestNumber 2 3)
    printfn "%d" (sumOfList 0 list123)
    printfn "%d" (lengthOfList 0 list123)
    printfn "%d" (largestElement None list123) *)
    printfn "%s" (CSModelling.coffeeMachine lstActionsVMDFA1 "Zero")
    0