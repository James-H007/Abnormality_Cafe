using JetBrains.Annotations;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public string desiredFood;
    private OrderManager orderManager;
    private Order myOrder;

    /*
     * A customer should be able to:
     * - Order food
     * - Check if the food they received is correct
    */ 

    void Start()
    {
        //orderManager = FindObjectOfType<OrderManager>(); <- Depreciated
        orderManager = Object.FindFirstObjectByType<OrderManager>();
        PlaceOrder();
    }

    public void PlaceOrder()
    {
        if (orderManager != null)
        {
            myOrder = orderManager.CreateOrder(desiredFood);
            Debug.Log($"Customer ordered: {desiredFood}");
        }
    }

    public bool CheckOrder(string servedFood) //Make sure to show what data type you want to return when making a function
    {
        if(myOrder != null && myOrder.foodItem == servedFood)
        {
            orderManager.FulfillOrder(myOrder);
            return true;
        }
        else
        {
            return false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
