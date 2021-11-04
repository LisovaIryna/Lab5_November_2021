using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationplatform : MonoBehaviour
{
    void Update()
    {
        Animation anim = GetComponent<Animation>();
        anim.Play("Animationplatform");
    }
}