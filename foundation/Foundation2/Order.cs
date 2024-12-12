public class Order 
{
    private List<Product> _products = new List<Product>();

    private Customer _customer;


    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddItem(string name, int id, double price, int quantity)
    {
        Product newProduct = new Product(name, id, price, quantity);
        _products.Add(newProduct);
    }

    public string GetPackingLabel()
    {
        string packingLabel ="";
        foreach (Product product in _products)
        {
            packingLabel +=  product.GetProductInfo() + ", ";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = _customer.GetCustomerInfo();
        return shippingLabel;
    }

    public double TotalCost()
    {
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.TotalPrice();
        }

        if (_customer.IsInUSA() == false)
        {
            totalPrice += 35;
        }
        else   
        {
            totalPrice += 5;
        }

        return totalPrice;
    }

    public void DisplayAll()
    {
        Console.WriteLine();
        Console.WriteLine("Order Info :");
        Console.WriteLine();
        Console.WriteLine(GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${TotalCost()}");
        Console.WriteLine();
        Console.WriteLine("__________________________________");
    
    }

}