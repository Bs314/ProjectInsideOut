using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScreen : MonoBehaviour
{
   
    void Start()
    {
      SceneManager.LoadScene("3GameScene");
    }

}
