using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Thankyou : MonoBehaviour
{
    public GameManager reset;
    public void Start()
    {
        reset = FindObjectOfType<GameManager>();  
    }
    public void RestartGame()
    {
        reset.ResetTime();
        SceneManager.LoadScene("Menu");     
    }
}
