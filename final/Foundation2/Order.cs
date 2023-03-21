public class Order
{
    private Customer _customer;
    public List<Product> _products;
    private string _place;

    public Order(Customer customer, List<Product> products, string place)
    {
        _customer = customer;
        _products = products;
        _place = place;
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalPrice();
        }
        if (_place == "USA")
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }
}