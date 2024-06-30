using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    [SerializeField] private Animator animator;


    private void Start()
    {
        
    }

    private void Update()
    {

        SetAnimation();
    }

    void SetAnimation()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (Mathf.Abs(horizontalInput) > 0.1f || Mathf.Abs(verticalInput) > 0.1f)
        {
            animator.SetBool("PlayerInputAnimation", true);
        }
        else
        {
            animator.SetBool("PlayerInputAnimation", false);
        }
    }
}
