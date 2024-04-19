using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimadorPlayer : MonoBehaviour
{
    public Joystick joystick;
    float horizontal;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if (joystick)
        {
            horizontal = joystick.Horizontal;
        }
        animator.SetFloat("Horizontal",Math.Abs(horizontal));
    }
}
