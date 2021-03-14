using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiController : MonoBehaviour
{
    public float aiDistance;
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

        aiDistance = Vector3.Distance(points[master.currentPoint].transform.position, this.transform.position);


    }

    public void Move()
    {
       
    }
}
