using UnityEngine;

public class Order : MonoBehaviour
{
    /*
     * Order should be able list what the food item is called
     */ 
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public string foodItem;
    public bool isFulfilled = false;
    
    public Order(string item)
    {
        foodItem = item;
    }
}
