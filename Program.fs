module FSharpAdventCalendar2016.Day10.LambdaFunction

open Amazon.Lambda.Core
open Amazon.Lambda.Serialization.Json
open Newtonsoft.Json

type InputValue = {
    [<JsonProperty("question")>]
    Question : string
}

type ResultValue = {
    [<JsonProperty("answer")>]
    Answer : int
}

[<CompiledName("FunctionHandler")>]
let handle (input:InputValue) (context:ILambdaContext) =
    match input.Question.ToLower () with
    | "the answer to the ultimate question of life the universe and everything"
    | "the answer to life the universe and everything" -> { Answer = 42 }
    | _ -> { Answer = 0 }
