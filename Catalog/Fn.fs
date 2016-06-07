module Retail.Fn

open Retail.Set
open Retail.Samples
open System

let searchProducts (q: String) = 
    getProducts
    |> List.filter (fun p -> p.Name.Contains(q))