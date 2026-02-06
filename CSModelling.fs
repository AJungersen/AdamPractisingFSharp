Module CSModelling

//Vending Machine DFA in F#
let lstActionsVMDFA1 = ["FiveKr"; "FiveKr"; "Tea"] 

let rec coffeeMachine input state =
    match state with
    |"Zero" ->
        match input with
        |head :: tail -> 
            if head="FiveKr" then coffeeMachine tail "Five"
            elif head="TenKr" then coffeeMachine tail "Ten"
            else coffeeMachine tail "Error"
        |[] ->
            "Program terminated in state zero"
    |"Five" ->
        match input with
        |head :: tail -> 
            if head="FiveKr" then coffeeMachine tail "Ten"
            elif head="TenKr" then coffeeMachine tail "Fifteen"
            else coffeeMachine tail "Error"
        |[] ->
            "Program terminated in state five"
    |"Ten" ->
        match input with
        |head :: tail -> 
            if head="FiveKr" then coffeeMachine tail "Fifteen"
            elif head="TenKr" then coffeeMachine tail "Error"
            elif head="Tea" then coffeeMachine tail "Zero"
            else coffeeMachine tail "Error"
        |[] ->
            "Program terminated in state ten"
    |"Fifteen" ->
        match input with
        |head :: tail -> 
            if head="FiveKr" then coffeeMachine tail "Error"
            elif head="TenKr" then coffeeMachine tail "Error"
            elif head="Coffee" then coffeeMachine tail "Zero"
            else coffeeMachine tail "Error"
        |[] ->
            "Program terminated in state fifteen"
    |"Error" ->
        match input with
        |head :: tail -> 
            if head="FiveKr" then coffeeMachine tail "Error"
            elif head="TenKr" then coffeeMachine tail "Error"
            elif head="Coffee" then coffeeMachine tail "Error"
            else coffeeMachine tail "Error"
        |[] ->
            "Program terminated in state Error"
