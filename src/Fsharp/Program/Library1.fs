namespace Program

open Fuse
open Fable.Core

module Module1 =    
    let observableString = Observable.createWith "Testing"    
    let observableNumber = observableString.map(fun s -> s.Length)
    
    let obsX = Observable.createWith "Heia!"
    let unsafeObsX = Observable.createUnsafeWith "Hoheya!"
    unsafeObsX.valueOverride <- 15
    let obsY = Observable.createWith 89.
    
    // Doesn't work, the JavaScript doesn't map to the right format.
    // It should be Observable('Paul', 'Ace'), but insists on being Observable(['Paul', 'Ace'])
    let kiss = Observable.createList [| "Paul"; "Ace" |] 

    type Player = { name: string; age: int }

    let names = Observable.createTyped<Player>    
    names.replaceAll(
            [| 
                { name = "John"; age = 71 }
                { name = "Ringo" ; age = 45 }
                { name = "Paul"; age = 69 }
            |])    

    let numNames = names.countWhere(fun n -> n.name.Length > 4)

    let obsZ = obsY.map(fun old -> old + 1.)
    
    let untypedObservable = Observable.create ()
    untypedObservable.value <- "WOHEY!"

    let untypedProjection = 
        untypedObservable.map(fun o -> 
            match o with
            | :? string as str -> str + " matched"
            | _ -> failwith "Didn't expect that, no sir")

    // Doesn't work because the callback uses two parameters and creates
    // a curried function. For it to work with Fuse it needs to be a
    // normal function call with two parameters
    let private obsU = obsZ.mapi(fun (p, idx) -> p + (idx |> float))

    let buttonClicked args =     
        Console.log (Json.stringify args)
        //let x = Args.toString args?x
        //Console.log (x)
        
    Console.log (obsX.value)
    Console.log (obsY.value)

    let X = "Hello again from F#!" 