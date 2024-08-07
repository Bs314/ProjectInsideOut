using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScreenLoader : MonoBehaviour
{
   
    public void LoadScreen(int index)
    {
        if(index == 1)
        {
            SceneManager.LoadScene("1MainScene");
        }
        else if(index == 2)
        {
            SceneManager.LoadScene("2Intro");
        }
        else if(index == 3)
        {
            SceneManager.LoadScene("3GameScene");
        }
        
    }
}
