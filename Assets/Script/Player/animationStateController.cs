using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();    
    }


    void Update()
    {
        //Player animation controller
        if (Input.GetMouseButton(0))
        {
            animator.SetBool("isRunning", true);
        }
        if (!Input.GetMouseButton(0))
        {
            animator.SetBool("isRunning", false);
        }
    }
    
}
