using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionManager : MonoBehaviour
{
    public float[] char_positons;
    public GameObject Player;
    public float PlayerPosition;
    public GameObject[] AI;
    public int currentPos;
    public int currentPoint;
    public Text posText;
    //   public Text posText;


    void Start()
    {
        
    }

   
    void Update()
    {
        PositionCal();
        posText.text = currentPos.ToString();
    }

    public void PositionCal()
    {
        char_positons[0] = Player.GetComponent<PlayerController>().playerDistance;
        char_positons[1] = AI[0].GetComponent<AiController>().aiDistance;
        char_positons[2] = AI[1].GetComponent<AiController>().aiDistance;
        char_positons[3] = AI[2].GetComponent<AiController>().aiDistance;
    
        char_positons[4] = AI[3].GetComponent<AiController>().aiDistance;
        char_positons[5] = AI[4].GetComponent<AiController>().aiDistance;
        char_positons[6] = AI[5].GetComponent<AiController>().aiDistance;
        char_positons[7] = AI[6].GetComponent<AiController>().aiDistance;
        char_positons[8] = AI[7].GetComponent<AiController>().aiDistance;
        char_positons[9] = AI[8].GetComponent<AiController>().aiDistance;
        char_positons[10] = AI[9].GetComponent<AiController>().aiDistance;
      
      
    
      
        PlayerPosition = Player.GetComponent<PlayerController>().playerDistance;

        Array.Sort(char_positons);
       // Array.Reverse(car_positons);

        int x = Array.IndexOf(char_positons, PlayerPosition);

        switch (x)
        {
            case 0:
                currentPos = 1;
                break;
            case 1:
                currentPos = 2;
                break;
            case 2:
                currentPos = 3;
                break;
            case 3:
                currentPos = 4;
                break;
               
            case 4:
                currentPos = 5;
                break;
            case 5:
                currentPos = 6;
                break;
            case 6:
                currentPos = 7;
                break;
            case 7:
                currentPos = 8;
                break;
            case 8:
                currentPos = 9;
                break;
            case 9:
                currentPos = 10;
                break;
            case 10:
                currentPos = 11;
                break;
           
        }

    }
}



