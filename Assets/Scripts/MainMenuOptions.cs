using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour
{
    //Initialises variables
    public static bool isLoading = false;

    //Loads the scenes
    public void newGame()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadGame()
    {
        isLoading = true;
        SceneManager.LoadScene(2);
    
    }



}
