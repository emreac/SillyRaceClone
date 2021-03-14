using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFocus : MonoBehaviour
{

    public bool isUsed;
    public PositionManager master;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="AI" && !isUsed || other.tag =="Player" && !isUsed)
        {
            isUsed = true;
            master.currentPoint++;
        }
    }

    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
}
