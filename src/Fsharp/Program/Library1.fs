namespace Program

open Fuse
open Fable.Core

module Module1 = 
    //// generate an infinite Fibonacci sequence
    //let fibSeq = Seq.unfold (fun (a,b) -> Some( a+b, (b, a+b) ) ) (0,1)
    //// take the first few numbers in the sequence and convert the sequence to a list
    //let fibList = fibSeq |> Seq.takeWhile (fun x -> x<=400 ) |> Seq.toArray
    //let stringList = 
    //    fibList 
    //    |> Array.map string 
    //    |> System.String.Concat
    //Observable.init
    #if false
    let o1 = Observable()
    let o2 = Observable.create "PenguinFucker"
    let private o3 = Observable.create ""
    //let o3 = Observable.create (1, 2, 3)
    //let o4 = Observable.createMany 1 2 5 7 8

    //Observable.replaceAll o3 [|1,2,3,4|]
    //Observable.replaceAll o2 [|"Hei", "din", "faen"|]
    //Observable.replaceAll' o1 (1, "HELLO", 1.45)

    Console.log ("o1: " + Json.stringify o1)
    Console.log ("o2: " + Json.stringify o2)
    Console.log ("o3: " + Json.stringify o3)
    
    Console.log ("o1 val: " + Json.stringify (Observable.value o1))

    let add a b = a + b
    //
    let buttonClicked args =
        Console.log ("BUTTON CLICKED! " + Json.stringify args)        
        Observable.setValue "CLICKED!" o1

    let seq = Seq.init 5 (fun n -> n * 10)

    let seqOdd = 
        seq
        |> Seq.filter (fun n -> n > 20)
        |> Seq.map string
        |> String.concat ", "
        |> Observable.create
 

    let stringResult = seq 
                        |> Seq.fold (fun acc elem -> acc + elem) 0
                        |> string
 #endif

    let obsX = Observable.createString "Heia!"
    let obsY = Observable.createFloat 89.

    let obsZ = obsY.map(fun old -> old + 1.)
    let obsU = obsZ.map(fun oldold -> oldold + 3. |> string)

    let buttonClicked args =
        Console.log (Json.stringify args)
        
    Console.log (obsX.value)
    Console.log (obsY.value)

    let X = "Hello again again from F#!" 