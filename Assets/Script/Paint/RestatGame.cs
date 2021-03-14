using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestatGame : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
      
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Level1");
    }
}
