using Domain.Entities;
using Infrastructure.Services;
var productService = new ProductService();
var custumerService = new CustomerService();
var orderService = new OrderService();


ShowOrder();



void ShowCustomer()
{
    var allCustomers = custumerService.GetCustomer();

    System.Console.WriteLine("Id  firstname");
    foreach (var st in allCustomers)
    {
        System.Console.WriteLine($"{st.Id}    {st.FirstName}");
    }
}

void AddCustomer()
{
    Console.WriteLine("Add Customer :");
    var st = new Customer()
    {
        FirstName = Convert.ToString(Console.ReadLine()),
    };
    custumerService.AddCustomer(st);
}

void UpdateCustomer()
{
    Console.WriteLine("Update Customer :");
    var st = new Customer()
    {
        Id = Convert.ToInt32(Console.ReadLine()),
        FirstName = Convert.ToString(Console.ReadLine()),

    };
    var result = custumerService.UpdateCustomer(st);
    if (result) System.Console.WriteLine("Updated");
    else System.Console.WriteLine("Not found");
}

void DeleteCustomer(int id)
{
    custumerService.DeleteCustomer(id);
}



void ShowProduct()
{
    var allProducts = productService.GetProducts();

    System.Console.WriteLine("Id  ProductName   Company    ProductCount     Price");
    foreach (var st in allProducts)
    {
        System.Console.WriteLine($"{st.Id}    {st.ProductName}   {st.Company}    {st.ProductCount}     {st.Price}");
    }
}

void AddProduct()
{
    Console.WriteLine("Add Product :");
    var st = new Product()
    {
        ProductName = Convert.ToString(Console.ReadLine()),
        Company = Convert.ToString(Console.ReadLine()),
        ProductCount = Convert.ToInt32(Console.ReadLine()),
        Price = Convert.ToInt32(Console.ReadLine()),
    };
    productService.AddProducts(st);
}

void UpdateProduct()
{
    Console.WriteLine("Update Product :");
    var st = new Product()
    {

        Id = Convert.ToInt32(Console.ReadLine()),
        ProductName = Convert.ToString(Console.ReadLine()),
        Company = Convert.ToString(Console.ReadLine()),
        ProductCount = Convert.ToInt32(Console.ReadLine()),
        Price = Convert.ToInt32(Console.ReadLine()),
    };
    var result = productService.UpdateProducts(st);
    if (result) System.Console.WriteLine("Updated");
    else System.Console.WriteLine("Not found");
}

void DeleteProduct(int id)
{
    productService.DeleteProduct(id);
}



void ShowOrder()
{
    var allOrders = orderService.GetOrders();

    System.Console.WriteLine("Id   ProductId       CustomerId     CreatedAt     ProductCount   Price");
    foreach (var st in allOrders)
    {
        System.Console.WriteLine($"{st.Id}    {st.ProductId}   {st.CustomerId}    {st.CreatedAt}     {st.ProductCount}  {st.Price}");
    }
}

void AddOrder()
{
    Console.WriteLine("Add Orders :");
    var st = new Order()
    {

        ProductId = Convert.ToInt32(Console.ReadLine()),
        CustomerId = Convert.ToInt32(Console.ReadLine()),
        CreatedAt = DateTime.Today,
        ProductCount = Convert.ToInt32(Console.ReadLine()),
        Price = Convert.ToInt32(Console.ReadLine()),
    };
    orderService.AddOrders(st);
}

void UpdateOrder()
{
    Console.WriteLine("Update Orders :");
    var st = new Order()
    {

        Id = Convert.ToInt32(Console.ReadLine()),
        ProductId = Convert.ToInt32(Console.ReadLine()),
        CustomerId = Convert.ToInt32(Console.ReadLine()),
        CreatedAt = DateTime.Today,
        ProductCount = Convert.ToInt32(Console.ReadLine()),
        Price = Convert.ToInt32(Console.ReadLine()),
    };
    var result = orderService.UpdateOrders(st);
    if (result) System.Console.WriteLine("Updated");
    else System.Console.WriteLine("Not found");
}

void DeleteOrder(int id)
{
    orderService.DeleteOrders(id);
}