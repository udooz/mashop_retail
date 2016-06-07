open Suave
open Suave.Successful
open Retail.RetailTypes
open Retail.RetailFn

let products =
    request (fun r ->
        match r.queryParam "q" with
        | Choice1Of2 q -> OK (Retail.RetailFn.searchProducts q)
        | _ -> OK "bad")
let webPart =
    choose [
        path "/" >=> OK "Ramadan Kareem"
        path "/products" >=> products
    ]