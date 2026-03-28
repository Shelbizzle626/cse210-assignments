

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private const float DOMESTIC_SHIPPING = 5f;
    private const float INTERNATIONAL_SHIPPING = 35f;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float GetTotalCost()
    {
        float total = 0f;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }

        total += _customer.LivesInUSA() ? DOMESTIC_SHIPPING : INTERNATIONAL_SHIPPING;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "--- Packing Label ---\n";
        foreach (Product p in _products)
        {
            label += $" {p.GetName()} (ID: {p.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "--- Shipping Label ---\n";
        label += $" {_customer.GetName()}\n";

        foreach (string line in _customer.GetAddress().GetFullAddress().Split('\n'))
        {
            label += $" {line}\n";
        }
        return label;
    }
}