namespace Retail

module RetailFn =

    open RetailTypes
    open Samples 
    open System

    let searchProducts (q: String) = 
        getProducts
        |> List.filter (fun p -> p.Name.Contains(q))