namespace Program

open Fuse
open Fable.Core

module Module1 = 


    let observableString = Observable.createWith "Testing"
    let observableNumber = observableString.map(fun s -> s.Length)
    
    let obsX = Observable.createWith "Heia!"
    let obsY = Observable.createWith 89.
    
    let kiss = Observable.createList [| "Paul"; "Ace" |] // Doesn't work

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
    
    let plainObservable = Observable.create ()

    plainObservable.value <- "Fuckfaaaace2"

    let private obsU = obsZ.mapi(fun (p, idx) -> p + (idx |> float)) // Doesn't work

    let buttonClicked args =
        Console.log (Json.stringify args)
        
    Console.log (obsX.value)
    Console.log (obsY.value)

    let X = "Hello again from F#!" 