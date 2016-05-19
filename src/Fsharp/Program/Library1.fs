namespace Program

open Fuse
open Fable.Core

module Module1 =    

    Lifecycle.onEnteringForeground (fun () -> Console.log("Entering foreground"))
    Lifecycle.onEnteringBackground (fun () -> Console.log("Entering background"))

    let counter = Observable.createWith 0

    Timer.create (fun () -> counter.value <- counter.value + 1) 1000 true

    let observableString = Observable.createWith "Testing"    
    let observableNumber = observableString.map(fun s -> s.Length)
    
    let obsX = Observable.createWith "Heia!"
    let unsafeObsX = Observable.createUnsafeWith "Hoheya!"
    unsafeObsX.valueOverride <- 15
    let obsY = Observable.createWith 89.
        
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

    let obsU = obsZ.mapi(fun p idx -> p + (idx + 1 |> float))

    let buttonClicked args =     
        Console.log (Json.stringify args)
        
    Console.log (obsX.value)
    Console.log (obsY.value)

    let X = "Hello again from F#!" 