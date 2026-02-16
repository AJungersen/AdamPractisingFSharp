//Exercise RL1.2 - Vending Machine in F#
type State = 
    | Zero 
    | Five 
    | Ten 
    | Fifteen 
    | Error
type Symbol = 
    | FiveKR 
    | TenKR 
    | Tea 
    | Coffee

let nextState state symbol =
    match state,symbol with
    | Error, FiveKR -> Error
    | Error, TenKR -> Error
    | Error, Tea -> Error
    | Error, Coffee -> Error
    | Zero, FiveKR -> Five
    | Zero, TenKR -> Ten
    | Zero, Tea -> Error
    | Zero, Coffee -> Error
    | Five, FiveKR -> Ten
    | Five, TenKR -> Fifteen
    | Five, Tea -> Error
    | Five, Coffee -> Error
    | Ten, FiveKR -> Fifteen
    | Ten, TenKR -> Error
    | Ten, Tea -> Zero
    | Ten, Coffee -> Error
    | Fifteen, FiveKR -> Error
    | Fifteen, TenKR -> Error
    | Fifteen, Tea -> Error
    | Fifteen, Coffee -> Zero

let rec run state input =
    match input with
    | [] -> state
    | head::tail -> run (nextState state head) tail
            
printfn "Running...\nFinished at state %A " (run Zero ( FiveKR :: TenKR :: Coffee ::[]))

//RL1.3 - Extension of the Vending Machine
type State13 = 
    | Zero 
    | Five 
    | Ten 
    | Fifteen 
    | Twenty
    | Error
type Symbol13 = 
    | FiveKR 
    | TenKR 
    | TwentyKR
    | Tea 
    | Coffee
    | Chocolate

let nextState13 state13 symbol13 =
    match state13,symbol13 with
    | Error, FiveKR -> Error
    | Error, TenKR -> Error
    | Error, TwentyKR -> Error
    | Error, Tea -> Error
    | Error, Coffee -> Error
    | Error, Chocolate -> Error

    | Zero, FiveKR -> Five
    | Zero, TenKR -> Ten
    | Zero, TwentyKR -> Twenty
    | Zero, Tea -> Error
    | Zero, Coffee -> Error
    | Zero, Chocolate -> Error

    | Five, FiveKR -> Ten
    | Five, TenKR -> Fifteen
    | Five, TwentyKR -> Error
    | Five, Tea -> Error
    | Five, Coffee -> Error
    | Five, Chocolate -> Error

    | Ten, FiveKR -> Fifteen
    | Ten, TenKR -> Twenty
    | Ten, TwentyKR -> Error
    | Ten, Tea -> Zero
    | Ten, Coffee -> Error
    | Ten, Chocolate -> Error

    | Fifteen, FiveKR -> Twenty
    | Fifteen, TenKR -> Error
    | Fifteen, TwentyKR -> Error
    | Fifteen, Tea -> Error
    | Fifteen, Coffee -> Zero
    | Fifteen, Chocolate -> Error

    | Twenty, FiveKR -> Error
    | Twenty, TenKR -> Error
    | Twenty, TwentyKR -> Error
    | Twenty, Tea -> Error
    | Twenty, Coffee -> Error
    | Twenty, Chocolate -> Zero
    
let rec run13 state13 input13 =
    match input13 with
    | [] -> state13
    | head::tail -> run13 (nextState13 state13 head) tail

printfn "Running...\nFinished at state %A " (run13 Zero ( FiveKR :: TenKR :: FiveKR :: Chocolate :: []))
printfn "Running...\nFinished at state %A " (run13 Zero ( FiveKR :: TenKR :: TwentyKR :: Chocolate :: []))

