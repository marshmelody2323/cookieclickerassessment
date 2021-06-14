using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    //Initialises variables
    public static int CashCount;
    public GameObject CashDisplay;
    public int InternalCash;


    // Update is called once per frame
    void Update()
    {
        //Internally counted total cash amount
        InternalCash = CashCount;
        //Displays cash total on screen
        CashDisplay.GetComponent<Text>().text = "$" + InternalCash;
    }
}
