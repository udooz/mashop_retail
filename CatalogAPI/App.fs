open Suave
open Suave.WebPart
open Suave.Successful
open Suave.RequestErrors
open Suave.Operators
open Suave.Filters // for path
open Retail.RetailTypes
open Retail.RetailFn

let cfg =
  { defaultConfig with
      bindings = [ HttpBinding.mk HTTP (System.Net.IPAddress.Parse "0.0.0.0") 8083us  ] }

// default port: 8803
let catalogSearch = 
    request (fun r ->
        match r.queryParam "q" with
        | Choice1Of2 q -> OK (sprintf "<h2> Search term is: %s </h2>" q)
        | Choice2Of2 msg -> BAD_REQUEST msg)

let webPart = 
    choose [
        path "/" >=> (OK "<h1> Ramadan Kareem </h1>")
        path "/catalog" >=> catalogSearch
    ]

startWebServer cfg webPart