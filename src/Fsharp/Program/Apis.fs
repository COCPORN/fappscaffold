namespace Fuse

open System
open Fable.Core
open Fable.Import.JS        

module Console =
    [<Emit("console.log($0)")>]
    let log line = failwith "JS only"
    
module Json = 
    [<Emit("JSON.stringify($0)")>]
    let stringify obj = failwith "JS only"

module Args =
    let toString arg =
        sprintf "%O" arg

//[<Import("", "FuseJS/Promises")>]
//module Promises =
//    type Promise<'T, 'R> = 
//        abstract member ``then`` : Action<'T> -> Promise<'T, 'R>
//        abstract member ``then`` : Action<'T> * Action<'R> -> Promise<'T, 'R>        
//        abstract member catch : ('R -> unit)

//    type Promise<'T, 'R> = 
//        inherit IPromise<'T, 'R>


[<Import("", "FuseJS/Lifecycle")>]
module Lifecycle =
    
    let mutable (onEnteringForeground : unit -> unit) = failwith "JS only"
    let mutable (onEnteringBackground : unit -> unit) = failwith "JS only"
    let mutable (onEnteringInteractive : unit -> unit) = failwith "JS only"
    let mutable (onExitingInteractive : unit -> unit) = failwith "JS only"


[<Import("", "FuseJS/Phone")>]
module Phone = 
    let call number = 
        failwith "JS only"

[<Import("", "FuseJS/Timer")>]
module Timer = 
    type Timer = interface end
        
    let create (action: unit -> unit) (interval:int) (repeat:bool) : Timer =
        failwith "JS only"
    let delete (timer: Timer) =
        failwith "JS only"


[<Import("", "FuseJS/Vibration")>]
module Vibration =
    let vibrate (duration:float) =
        failwith "JS only"

[<Import("", "FuseJS/InterApp")>]
module InterApp =
    let launchUri (uri:string) =
        failwith "JS only"

    let mutable (onReceivedUri : string -> unit) = failwith "JS only"


[<Import("", "FuseJS/Storage")>]
module Storage =
    let write (filename:string) (data:string) =
        failwith "JS only"

    let read (filename:string) : string =
        failwith "JS only"

[<Import("", "FuseJS/Environment")>]
module Environment =
    let mutable iOS : bool = failwith "JS only"
    let mutable android : bool = failwith "JS only"
    let mutable preview : bool = failwith "JS only"
    let mutable mobile : bool = failwith "JS only"
    let mutable desktop : bool = failwith "JS only"

[<Import("", "FuseJS/Camera")>]
module Camera =
    type Result =
        member this.path with get() : string = failwith "JS only"
        member this.name with get() : string = failwith "JS only"            
    
    type IThenable = 
        abstract member ``then`` : (obj -> Result) -> IThenable
        abstract member catch : (obj -> unit) -> unit
            
    type PictureSettings =                 
        member this.targetWidth with set(value:int) = failwith "JS only"
        member this.targetHeight with set(value:int) = failwith "JS only"
        member this.correctOrientation with set(value:bool) = failwith "JS only"
        
    let takePicture (configuration:PictureSettings) : IThenable =
        failwith "JS only"

module Fetch =
    type Headers = 
        abstract member get : string with get

    type Body = 
        abstract member body : string with get
        

    type Response =
        abstract member ``type`` : string with get
        abstract member url : string with get
        abstract member useFinalUrl : bool with get
        abstract member status : int with get
        abstract member ok : bool with get
        abstract member statusText : string with get
        abstract member headers : Headers with get
        abstract member body : Body with get

    type Error = 
        abstract member description : string with get

    type Request =
        abstract member data : string with get

    let fetch (uri: string) (request : string) : Promise<Response> =
        failwith "JS only"