using System;
using System.Collections.Generic; // Required for List<T>

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;

        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost(); // Assuming this method exists in Product
        }

        // Add shipping cost
        totalCost += _customer.LivesInUSA() ? 5 : 35;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n"; // Assuming these methods exist in Product
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}"; // Assuming these methods exist
    }
}
