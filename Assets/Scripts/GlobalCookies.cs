using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCookies : MonoBehaviour
{
    //Initialises variables
    public static int CookieCount;
    public GameObject CookieDisplay;
    public int InternalCookie;
    // Update is called once per frame
    void Update()
    {
        //Internally counted cookie amount
        InternalCookie = CookieCount;
        //Text component for cookie amount on the screen
        CookieDisplay.GetComponent<Text>().text = "Cookie: " + InternalCookie;
    }
}
