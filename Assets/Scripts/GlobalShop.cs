using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalShop : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int shopValue = 50;
    public static bool turnOffButton = false;
    public GameObject shopStats;
    public static int numberOfShops;
    public static int shopPerSec;

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        shopStats.GetComponent<Text>().text = "Shops: " + numberOfShops + " @ " + shopPerSec + " per second";
        fakeText.GetComponent<Text>().text = "Buy Shop - $" + shopValue;
        realText.GetComponent<Text>().text = "Buy Shop - $" + shopValue;
        if (currentCash >= shopValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        else
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }

        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
