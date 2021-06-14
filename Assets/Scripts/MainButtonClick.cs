using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour
{
    public GameObject textbox;

    public void ClickTheButton()
    {
        //Clicks the buttons and makes cookies
        GlobalCookies.CookieCount += 1;
    }





}
