namespace Retail

module RetailTypes =

    open System

    type Product = 
        {
            SkuId: String;
            Name: String;
        }