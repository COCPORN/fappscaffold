namespace Program

open Fuse
open Fable.Core

module Module1 =    

    if (Environment.iOS) then Console.log("Running on iOS")
    if (Environment.android) then Console.log("Running on Android")
    if (Environment.preview) then Console.log("Running in preview mode")
    if (Environment.mobile) then Console.log("Running on iOS or Android")
    if (Environment.desktop) then Console.log("Running on desktop")

    Lifecycle.onEnteringForeground <- fun () -> Console.log("Entering foreground, new style")
    Lifecycle.onEnteringBackground <- fun () -> Console.log("Entering background, new style")

    InterApp.onReceivedUri <- fun str -> Console.log ("Received: " + str)

    let counter = Observable.createWith 0

    let timer = Timer.create (fun () -> counter.value <- counter.value + 1) 1000 true

    counter.addSubscriber(fun c -> 
        Console.log(sprintf "Counter changed: %d" c.value)
        if (c.value >= 10) then Timer.delete timer)

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