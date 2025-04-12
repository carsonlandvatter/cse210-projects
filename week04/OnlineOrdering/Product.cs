public class Product
{
    private string _productName;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string productName, int productID, double price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}