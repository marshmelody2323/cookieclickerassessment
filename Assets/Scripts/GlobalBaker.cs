using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalBaker : MonoBehaviour
{
    //Initialises variables
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int bakerValue = 50;
    public static bool turnOffButton = false;
    public GameObject bakerStats;
    public static int numberOfBakers;
    public static int bakePerSec;

    // Update is called once per frame
    void Update()
    {
        //Cash amount variable
        currentCash = GlobalCash.CashCount;
        // Text components which are going to be changed/used
        bakerStats.GetComponent<Text>().text = "Bakers: " + numberOfBakers + " @ " + bakePerSec + " per second";
        fakeText.GetComponent<Text>().text = "Buy Baker - $" + bakerValue;
        realText.GetComponent<Text>().text = "Buy Baker - $" + bakerValue;
        //Basically just a shoddy way of making the buy buttons usable, no idea why i did it like that instead of just disabling and enabling one button
        //but I guess I didn't have that hindsight at the time
        if (currentCash >= bakerValue)
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
