namespace NBG_CHSARP_C3_LINQ
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public decimal? Cost { get; set; }

        public static List<Product> Products { get; set; } = new()
        {
            new Product()
            {
                Id = 1,
                Name = "uPhone X",
                Color = "Black",
                Price = 1200.99m,
                Cost = 800.10m
            },
            new Product()
            {
                Id = 2,
                Name = "uPhone X",
                Color = "Blue",
                Price = 1200.99m,
                Cost = 800.10m
            },
            new Product()
            {
                Id = 3,
                Name = "uPhone X",
                Color = "Red",
                Price = 1200.99m,
                Cost = 800.10m
            },
            new Product()
            {
                Id = 4,
                Name = "uPad Air",
                Color = "Black",
                Price = 899.99m,
                Cost = 400.50m
            },
            new Product()
            {
                Id = 5,
                Name = "uPad Air",
                Color = "Silver",
                Price = 899.99m,
                Cost = 400.50m
            },
            new Product()
            {
                Id = 6,
                Name = "uPad Air",
                Color = "Grey",
                Price = 899.99m,
                Cost = 400.50m
            }
        };

        public static List<Product> ProductsCopy { get; set; } = new()
        {
            new Product()
            {
                Id = 1,
                Name = "uPhone X",
                Color = "Black",
                Price = 1200.99m,
                Cost = 800.10m
            },
            new Product()
            {
                Id = 2,
                Name = "uPhone X",
                Color = "Blue",
                Price = 1200.99m,
                Cost = 800.10m
            },
            new Product()
            {
                Id = 3,
                Name = "uPhone X",
                Color = "Red",
                Price = 1200.99m,
                Cost = 800.10m
            },
            new Product()
            {
                Id = 4,
                Name = "uPad Air",
                Color = "Black",
                Price = 899.99m,
                Cost = 400.50m
            },
            new Product()
            {
                Id = 5,
                Name = "uPad Air",
                Color = "Silver",
                Price = 899.99m,
                Cost = 400.50m
            },
            new Product()
            {
                Id = 6,
                Name = "uPad Air",
                Color = "Grey",
                Price = 899.99m,
                Cost = 400.50m
            }
        };

        public static List<Product> UPhonesOnlyList = new()
        {
            new Product()
            {
                Id = 1,
                Name = "uPhone X",
                Color = "Black",
                Price = 1200.99m,
                Cost = 800.10m
            },
            new Product()
            {
                Id = 2,
                Name = "uPhone X",
                Color = "Blue",
                Price = 1200.99m,
                Cost = 800.10m
            },
            new Product()
            {
                Id = 3,
                Name = "uPhone X",
                Color = "Red",
                Price = 1200.99m,
                Cost = 800.10m
            }
        };

        public override string ToString()
        {
            return $"Product Name: {Name} (Id: {Id}) \n Color: {Color} Price: {Price} \n (Cost: {Cost})";
        }

        public class Sale
        {
            public int SaleId { get; set; }
            public int ProductId { get; set; }
            public int Quantity { get; set; }

            public static List<Sale> Sales = new()
            {
                new Sale()
                {
                    SaleId = 1,
                    ProductId = 1,
                    Quantity = 5
                },
                new Sale()
                {
                    SaleId = 2,
                    ProductId = 1,
                    Quantity = 3
                },
                new Sale()
                {
                    SaleId = 3,
                    ProductId = 2,
                    Quantity = 4
                }
            };
        }

    }
}