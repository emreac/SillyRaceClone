using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoytickController : MonoBehaviour
{
    
    public Rigidbody rb;
  

    public DynamicJoystick moveJoystick;
    public DynamicJoystick lookJoystick;

    void Update()
    {
        
        updateMoveJoystick();
        updateLookJoystick();
       
    }
     
    void updateMoveJoystick()
    {
        float hoz = moveJoystick.Horizontal;
        float ver = moveJoystick.Vertical;
        Vector3 direction = new Vector3(hoz, 0, ver).normalized;
        transform.Translate(direction * 0.04f, Space.World);

    }
   
    void updateLookJoystick()
    {
        float hoz = moveJoystick.Horizontal;
        float ver = moveJoystick.Vertical;
        Vector3 direction = new Vector3(hoz, 0, ver).normalized;
        Vector3 lookAtPosition = transform.position + direction;
        transform.LookAt(lookAtPosition);
    }
    private void FixedUpdate()
    {
        if (rb.position.y < -4)
        {
           FindObjectOfType<GameController>().EndGame();
        }
    }
}
