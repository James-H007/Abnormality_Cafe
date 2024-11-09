using UnityEngine;

public class Player : MonoBehaviour
{
    public void ServeFood(Customer customer, string foodItem)
    {
        bool orderCorrect = customer.CheckOrder(foodItem);
        if (orderCorrect)
        {
            Debug.Log("Order completed successfully!");
        }
        else
        {
            Debug.Log("Wrong Order!");
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
