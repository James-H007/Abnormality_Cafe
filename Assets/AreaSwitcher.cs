using UnityEngine;

public class AreaSwitcher : MonoBehaviour
{
    public GameObject hostingArea;
    public GameObject kitchenArea;
    public GameObject servingArea;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowHostingArea()
    {
        hostingArea.SetActive(true);
        kitchenArea.SetActive(false);
        servingArea.SetActive(false);
    }

    public void ShowKitchenArea()
    {
        kitchenArea.SetActive(true);
        hostingArea.SetActive(false);
        servingArea.SetActive(false);
    }

    public void ShowServingArea()
    {
        servingArea.SetActive(true);
        kitchenArea.SetActive(false);
        hostingArea.SetActive(false);
    }
}
