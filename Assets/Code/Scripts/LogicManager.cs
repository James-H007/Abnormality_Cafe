using UnityEngine;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject hostingArea;
    public GameObject kitchenArea;
    public GameObject servingArea;

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
