using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalShop : MonoBehaviour
{
    //Initialises variables
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
        //Cash variable
        currentCash = GlobalCash.CashCount;
        //Text components for shop systems on the screen
        shopStats.GetComponent<Text>().text = "Shops: " + numberOfShops + " @ " + shopPerSec + " per second";
        fakeText.GetComponent<Text>().text = "Buy Shop - $" + shopValue;
        realText.GetComponent<Text>().text = "Buy Shop - $" + shopValue;
        //Same as baker button, I really could have done this a better way but here we are
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
