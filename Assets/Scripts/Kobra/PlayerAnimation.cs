using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("RunFoward", true);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetBool("ShiftRun", true);
            }
            else
            {
                anim.SetBool("ShiftRun", false);
            } 
        }
        else
        {
             anim.SetBool("RunFoward", false);           
        }

        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("RunBack", true);
        }
        else
        {
            anim.SetBool("RunBack", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("RunLeft", true);
        }
        else
        {
            anim.SetBool("RunLeft", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("RunRight", true);
        }
        else
        {
            anim.SetBool("RunRight", false);
        }

    }
}