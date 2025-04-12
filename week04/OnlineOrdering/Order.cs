public class Order
{
    private Customer _customer;
    private List<Product> _products;
    
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _products)
        {
            packingLabel += $"Product: {product.GetProductName()} (ID: {product.GetProductID()})\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string name = _customer.GetCustomerName();
        Address address = _customer.GetAddress();

        return $"{name}\n{address.GetStreetAddress()}\n{address.GetCity()}\n{address.GetState()}\n{address.GetCountry()}";
    }

    public double GetTotalCost()
    {
        double total = 0;
        
        foreach (Product product in _products)
        {
            //sets total to the total cost method set in the product class. 
            total += product.GetTotalCost();
        }

        //if the customer lives in the USA, $5 is added for shipping, else $35 is added to the total.
        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }
}