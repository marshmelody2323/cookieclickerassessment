using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisasterScript : MonoBehaviour
{
    public GameObject statusBox;
    public float cookieCheck;
    public int genChance;
    public bool disasterActive = false;
    public int cookieLoss;

    // Update is called once per frame
    void Update()
    {
        cookieCheck = GlobalCookies.CookieCount / 10;
        if (disasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }
    }

    //Generates a random "disaster" in a calculated interval when cookies are clicked
    IEnumerator StartDisaster()
    {
        disasterActive = true;
        genChance = Random.Range(1, 20);
        //Checks and calculates if a disaster should happen or not
        if (cookieCheck >= genChance)
        {
            cookieLoss = Mathf.RoundToInt(GlobalCookies.CookieCount * 0.25f);
            statusBox.GetComponent<Text>().text = "You lost " + cookieLoss + " cookies in a factory fire";
            GlobalCookies.CookieCount -= cookieLoss;
            yield return new WaitForSeconds(3);
            //Plays text animation for losing cookies in a factory fire
            statusBox.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1);
            statusBox.SetActive(false);
            statusBox.SetActive(true);
        }
        yield return new WaitForSeconds(10);
        disasterActive = false;
    }
}
