using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerMovement : MonoBehaviour
{
    static Animator anim;
    public Transform target;
    public Transform bird;
    public Transform birdtarget;
    public float t;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 birdpos=bird.position;
        Vector3 birdtargpos=birdtarget.position;
        if(Mathf.Floor(birdpos.x)==Mathf.Floor(birdtargpos.x))
        {      
        Vector3 a=transform.position;
        Vector3 b=target.position;
        if(Mathf.Floor(a.x)!=Mathf.Floor(b.x))
        {
        transform.position=Vector3.MoveTowards(a,Vector3.Lerp(a,b,t),speed);
        anim.SetBool("IsWalking",true);
        }
        else
        {
         anim.SetBool("IsWalking",false);
        }
        
        }

              
    }
}
