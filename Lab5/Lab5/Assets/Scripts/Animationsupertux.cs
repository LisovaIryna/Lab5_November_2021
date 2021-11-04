using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationsupertux : MonoBehaviour
{
    void Update()
    {
        Animation anim = GetComponent<Animation>();
        anim.Play("Animationsupertux");
    }
}