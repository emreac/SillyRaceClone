using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform cam;

    void LateUpdate()
    {
        //Green icon on the player that looks at camera
        transform.LookAt( transform.position+cam.forward);
    }
}
