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

    // Update is called once per frame
    void Update()
    {
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
