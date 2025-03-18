using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tigerrun : MonoBehaviour
{
    Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    public void therrun()
    {
        anim.SetTrigger("run");
    }
    
}
