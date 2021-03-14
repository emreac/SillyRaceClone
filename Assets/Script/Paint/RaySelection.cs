using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RaySelection : MonoBehaviour
{
    public int maxAmount = 100;
    public int currentAmount;
    public GameObject congrat;
    public GameObject paintRoller;

    public ProgressBar bar;

    private void Start()
    {
        currentAmount = maxAmount;
        bar.SetMaxAmount(maxAmount);
    }

    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            if (currentAmount == -8)
            {
                congrat.SetActive(true);
                paintRoller.SetActive(false);
            }
            //Use raycast to click triggers
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 10000f))
            {
                if (hit.transform.tag == "TriggerBar")
                {
                    //There are 9 triggers on the painting wall
                    //Reduce 12 for each triggers
                    ReduceAmmount(12);
                    Destroy(hit.transform.gameObject);
                    Debug.Log(currentAmount);
                    
                }
                
            }      
        }
    }

    //Reduce Amount From Bar 
    void ReduceAmmount(int reduce)
    {
        currentAmount -= reduce;
        bar.SetAmount(currentAmount);
    }
 

}

