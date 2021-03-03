module Assignment

// DO NOT MODIFY LEFT PART OF `LET` OPERATOR

// Define following distance unit transformations
let inchToMillimeter v =
    25.4 * v// write your code here

let footToInch x =
    12.0 * x // write your code here

let yardToFoot v =
    3.0 * v // write your code here

let mileToYard mile =
    1760.0 * mile // write your code here

(*
Use ONLY above functions and the forward pipe operator, `|>`,  to define the following unit transformation

Forward pipe operator passes the result of the left side to the function on the right side.
*)
let yardToMillimeter y =
    y * 3.0 * 12.0 * 25.4 // write your code here

// Define the curried function `divBy1000` that has the signature `float -> float -> float`
let divBy1000 =
    fun x->x/1000.0
    // write your code here
(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)
let millimeterToMeter n =
    n/1000.0 // write your code here

let meterToKilometer =
    fun x->x/1000.0 // write your code here
(*
Use above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)
let millimeterToKilometer =
    fun x->x/1000.0/1000.0 // write your code here

let inchToMeter =
    fun x->x*0.0254 // write your code here

let yardToKilometer =
    fun x->x/1093.6132983 // write your code here

let mileToMeter =
    fun x->x*1609.344  // write your code here


// Define following weight unit transformations
let ounceToGram v =
    v * 28.349523125 // write your code here

let poundToOunce p =
    p * 16.0 // write your code here

let shortTonToPound t =
    t * 2000.0 // write your code here


(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)

let gramToKilogram g =
    g/1000.0 // write your code here

(*
Use ONLY above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)

let gramToMetricTon =
    fun x->x/1000000.0 // write your code here

let poundToKilogram =
    fun x->x*0.45359237 // write your code here

let shortTonToMetricTon =
    fun x->x/1.10231131 // write your code here
