using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour
{

    public static bool isLoading = false;
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
