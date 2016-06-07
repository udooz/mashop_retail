namespace Retail 


module Samples =
    open RetailTypes

    let private Products = [
            {SkuId = "DetGel";
            Name = "Dettol Kitchen Dish and Slab Gel - 750 ml (Lemon Fresh)";
            };

            {SkuId = "Boost";
            Name = "Boost Plus Jar - 450 g";
            };

            {SkuId = "MOV";
            Name = "Moov Ointment - 25 g";
            };

            {SkuId = "DetGelHand";
            Name = "Dettol Foam Handwash Rose and Cherry - 250ml";
            };

        ]

    let getProducts = Products;
