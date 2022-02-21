using NBG_CHSARP_C3_LINQ;

//Projection

IEnumerable<string> products = Product.Products
    .Select(p => p.ToString().ToLower());

IEnumerable<string> productsQ = from p in Product.Products
                                select p.ToString().ToLower();

//Product.Products.RemoveAt(0);

List<string> productsList = products.ToList();
string[] productsArray = products.ToArray();

//Selecting a Dictionary

Dictionary<int, string> productsDict = Product.Products
    .Where(p => p.Id>1)
    .ToDictionary(p => p.Id, p => p.Name);

//Deferred Execution

List<char> chars = new() { 'a', 'b', 'c' };
IEnumerable<char> charsQuery = chars.Select(c => c).Where(c => c!='d');
chars.Remove('b');
foreach(char character in charsQuery)
{
    Console.WriteLine(character);
}

//Specific Properties

List<Product> ProductIdsAndNames = Product.Products
    .Select(p => new Product() { Id = p.Id, Name = p.Name })
    .ToList();

//Anonymous Classes

var Anomymous_ProductIdsAndNames = Product.Products
    .Select(p => new { Id = p.Id, Name = p.Name })
    .ToList();

var Anomymous_ProductIdsAndNamesShorthand = Product.Products
    .Select(p => new { p.Id, p.Name });

//Ordering

var orderedProducts = Product.Products
    .Select(p => new { p.Id, p.Name, p.Color, p.Price })
    .OrderBy(p => p.Name)
    .ThenBy(p => p.Color)
    .ThenByDescending(p => p.Price)
    .ToList();


//SelectMany

var manufacturers = new[]
{
new
{
    CompanyName = "ThreeStars",
    ProductSeries = new[] {"Universe", "Nebula"}
},
new
{
    CompanyName = "Watermelon",
    ProductSeries = new[] {"uPhone", "uPad"}
}
};


var productSeries = manufacturers
    .SelectMany(m => m.ProductSeries)
    .ToList();

//Filtering

var filteredProducts = Product.Products
    .Where(p => p.Color == "Black")
    .ToList();

var filteredProductsQ =
    (from p in Product.Products
     where p.Color == "Black"
     select p).ToList();

var filretedProductsFromB = Product.Products
    .Where(p => p.Color.StartsWith('B'))
    .ToList();

var filteredProductsQFromB =
    (from p in Product.Products
     where p.Color.StartsWith('B')
     select p).ToList();

var filtedProductsAnd = Product.Products
    .Where(p => p.Color == "Black" && p.Price >= 1000);

var filtedProductsAndQ =
    (from p in Product.Products
     where p.Color.StartsWith('B') && p.Price >= 1000
     select p).ToList();

//Getting Unique Objects

Product? first = Product.Products
    .Where(p => p.Color == "Black")
    .LastOrDefault();

Product? single = Product.Products
    .Where(p => p.Name == "uPhone X" && p.Color=="Black")
    .SingleOrDefault();

//Grouping

var GroupBy = Product.Products
    .GroupBy(p => p.Color)
    .ToList();

//Aggregating

int CountOfProducts = Product.Products.Count();
int CountOfBlackProducts = Product.Products.Where(p => p.Color == "Black").Count();

decimal MinPrice = Product.Products.Min(p => p.Price);
decimal MaxPrice = Product.Products.Max(p => p.Price);
decimal MinBlackPrice = Product.Products.Where(p => p.Color == "Black").Min(p => p.Price);

decimal MinPriceQ =
    (from p in Product.Products
     select p.Price).Min();

decimal SumOfPrices = Product.Products.Sum(p => p.Price);
decimal AverageofPrices = Product.Products.Average(p => p.Price);

decimal SumOfPricesQ =
    (from p in Product.Products
     select p.Price).Sum();

decimal AverageOfPricesQ =
    (from p in Product.Products
     select p.Price).Average();

//Chaining Operators

var groupBywWhereSumF = Product.Products
    .GroupBy(p => p.Color)
    .Where(g => g.Count() >= 1)
    .Select(g => new
    {
        ColorProductsGroup = g,
        SumOfPrices = g.Sum(g => g.Price)
    })
    .Where(g => g.SumOfPrices > 1000)
    .ToList();

//Paritioning

List<Product> take = Product.Products
    .Take(2)
    .ToList();

List<Product> skip = Product.Products
    .Skip(2)
    .ToList();

List<string> DistintctProductNames = Product.Products
    .Select(p => p.Name)
    .Distinct()
    .ToList();

Console.WriteLine("End of execution");
