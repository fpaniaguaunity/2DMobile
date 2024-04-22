using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class Muelle : MonoBehaviour
{
    public string tagPlayer = "Player";
    public float fuerza = 100;

    void OnTriggerEnter2D(Collider2D collider2D){
        if (collider2D.transform.CompareTag(tagPlayer)) {
            //1. Extender el muelle (activar animación)
           
            //2. Impulsar al Player hacia arriba
            collider2D.transform.GetComponent<Rigidbody2D>().velocity = Vector2.up * fuerza;
        }
    }
}
