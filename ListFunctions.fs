module ListFunctions
//Basic functions
//Function to double integer intput
let doubleNumber x = x * 2

//function to return absolut value
let absNumber x = 
    if x<0 then -x
    else x

//return greatest number
let greatestNumber x y =
    if x>y then x
    else y

//Lists
//Compute sum of list
let list123 = [1; 2; 3]
let rec sumOfList a b =
    match b with
    | head :: tail -> sumOfList (a+head) tail
    | [] -> a

//compute length of list
let rec lengthOfList a b =
    match b with
    |head :: tail -> lengthOfList (a+1) tail
    |[] -> a

//find largest element in a non-empty list
let rec largestElement a b =
    match b with
    |head :: tail ->
        if head>a then largestElement head tail
        else largestElement a tail
    |head :: [] -> 
        if head>a then head
        else a

    
    