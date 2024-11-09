using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic; //Brings the namespace into the scope such as List<T>
using System.Text;


public class OrderManager : MonoBehaviour
{
    /*
     * - An order manager should be able to:
     * - Create a list of orders
     * - Take an order out of a queue if it is fulfilled
     * 
     */ 
    public List<Order> currentOrders = new List<Order>();
    public Text orderUIText; //Reference to a Text UI element in your Canvas

    //Generate a new order from a customer
    //new Order will return a new Order object, which you defined in the other script, consisting of the food item string and then its other components
    public Order CreateOrder(string foodItem)
    {
        Order newOrder = new Order(foodItem); //Creates new instance of the order class
        currentOrders.Add(newOrder); //Adds the newly created Order to a list of currentOrders
        UpdateOrderUI();
        return newOrder; //Stores a reference to the order just created

    }


    //Method to fulfill an order
    //It's a void function since we're not returning anything, just changing the value to one of the orders
    public void FulfillOrder(Order order) {
        order.isFulfilled = true;
        currentOrders.Remove(order); //You can use the Remove() method to remove the first occurence of the item in the list
        UpdateOrderUI();
        //Additional code for customer feedback
    }

    private void UpdateOrderUI()
    {
        StringBuilder sb = new StringBuilder();
        foreach (Order order in currentOrders)
        {
            sb.AppendLine(order.foodItem);
        }
        orderUIText.text = sb.ToString();
    }


    //Printing all the orders
    public void PrintCurrentOrders()
    {
        foreach (Order order in currentOrders)
        {
            Debug.Log("Order: " + order.foodItem);
        }
 
    }

    void Start()
    {
        //PrintCurrentOrders();
    }

    private void Update()
    {
        //PrintCurrentOrders();
    }

}
