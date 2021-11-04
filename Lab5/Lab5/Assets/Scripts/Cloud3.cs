using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud3 : MonoBehaviour
{
    void Update()
    {
        Animation anim = GetComponent<Animation>();
        anim.Play("AnimationCloud3");
    }
}