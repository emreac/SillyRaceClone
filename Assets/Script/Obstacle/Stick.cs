using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    public GameObject stick;
    public float power = 10.0f;
    public float radius = 5.0f;
    public float upforce = 1.0f;

    void FixedUpdate()
    {
        //Hits any collider in the game
        if(stick == enabled)
        {
            Hit();
        }
       
    }

    void Hit()
    {
        Vector3 explosionPos = stick.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(power, explosionPos, radius, upforce, ForceMode.Impulse);
            }

        }


    }

}
