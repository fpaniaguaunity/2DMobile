using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimadorPlayer : MonoBehaviour
{
    public Joystick joystick;

    [Header("Marcar si se desea utilizar el pad analógico de XBOX en lugar del digital")]
    public bool padAnalogicoXBOX = false;
    float horizontal;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if (joystick){
            horizontal = joystick.Horizontal;
        }
        if (padAnalogicoXBOX)
        {
            horizontal = Input.GetAxis("HorizontalXBox");
        }
        animator.SetFloat("Horizontal",Math.Abs(horizontal));
    }
}
