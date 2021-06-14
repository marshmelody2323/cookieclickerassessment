using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    //Initialises variables

    public bool SellingCookie = false;
    public static int CashIncrease = 1;
    public int InternalIncrease;

    // Update is called once per frame
    void Update()
    {
        CashIncrease = GlobalShop.shopPerSec;
        InternalIncrease = CashIncrease;
        if (SellingCookie == false)
        {
            SellingCookie = true;
            StartCoroutine(SellTheCookie());
        }
    }


    //Sells a cookie for money automatically every (1) second
    IEnumerator SellTheCookie()
    {
        if (GlobalCookies.CookieCount == 0)
        {
            yield return new WaitForSeconds(1);
            SellingCookie = false;
        }
        else
        {
            GlobalCash.CashCount += InternalIncrease;
            GlobalCookies.CookieCount -= 1;
            yield return new WaitForSeconds(1);
            SellingCookie = false;
        }
    }
}
