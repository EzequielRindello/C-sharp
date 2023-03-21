public class Product
{
    private string _name;
    private int _productId;
    private decimal _price;
    private int _quantity;
    private List<Product> _products;

    public Product(string name, int productId, decimal price, int quantity, List<Product> products)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
        _products = products;
    }

    public decimal GetTotalPrice()
    {
        return _price * _quantity;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product._name}, {product._productId}\n";
        }
        return packingLabel;
    }
}