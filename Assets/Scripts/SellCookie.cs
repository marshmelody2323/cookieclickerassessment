using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCookie : MonoBehaviour
{
    //Initialises variables
    public GameObject textbox;
    public GameObject statusBox;
    public AudioSource cashOne;
    public AudioSource cashTwo;
    public int generateTone;

    public void ClickTheButton()
    {
        // Randomly plays a sound from a list
        generateTone = Random.Range(1, 3);
        if (GlobalCookies.CookieCount == 0)
        {
            //Plays animation if there isn't enough cookies
            statusBox.GetComponent<Text>().text = "Not enough cookies to sell.";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            if (generateTone == 1)
            {
                cashOne.Play();
            }
            if (generateTone == 2)
            {
                cashTwo.Play();
            }
            GlobalCookies.CookieCount -= 1;
            GlobalCash.CashCount += 1;
        }
    }





}
