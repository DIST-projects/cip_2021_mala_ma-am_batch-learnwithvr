﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KangarooMovement : MonoBehaviour
{
    static Animator anim;
    public Transform target;
    
    public float t;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        Vector3 a=transform.position;
        Vector3 b=target.position;
        transform.position=Vector3.MoveTowards(a,Vector3.Lerp(a,b,t),speed);
  
        anim.SetBool("IsWalking",true);
              
    }
}