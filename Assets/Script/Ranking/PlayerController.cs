using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float playerDistance;
    public GameObject[] points;
    public PositionManager master;
    public float speed;
   
    void Start()
    {
        
    }

    void Update()
    {
       
        FindPosition();
    }

    public void FindPosition()
    {
       
       playerDistance = Vector3.Distance(points[master.currentPoint].transform.position, this.transform.position);
     
      
    }

    public void Controls()
    {
     
        
    }
}
