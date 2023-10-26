using Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.Update();

        ProductManager productManager = new ProductManager();
        productManager.Add();
        productManager.Update();

        Customer customer = new Customer();
        customer.City = "Ankara";
        customer.Id = 1;
        customer.FirstName = "Test";
        customer.Lastname = "Test2";

        Customer customer2 = new Customer
        {
            Id = 2,
            City= "İstanbul",
            FirstName = "Hasan",
            Lastname = "ÖZMEN",
        };
        Console.WriteLine(customer2.FirstName);
                
          
    }
}
/*
class CustomerManager
{
    public void Add()
    {
        Console.WriteLine("Customer Added");
    }
    public void Update()
    {
        Console.WriteLine("Customer Updated");
    }
}

class ProductManager
{
    public void Add()
    {
        Console.WriteLine("product Added");
    }
    public void Update()
    {
        Console.WriteLine("product Updated");
    }
}*/