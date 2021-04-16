using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    static Animator anim;
    public Transform target;
    public Transform peacock;
    public Transform peacocktarget;
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
        Vector3 peacockpos=peacock.position;
        Vector3 peacocktargpos=peacocktarget.position;
        if(Mathf.Floor(peacockpos.x)==Mathf.Floor(peacocktargpos.x))
        {      
        Vector3 a=transform.position;
        Vector3 b=target.position;
        if(Mathf.Floor(a.x)!=Mathf.Floor(b.x))
        {
        transform.position=Vector3.MoveTowards(a,Vector3.Lerp(a,b,t),speed);
        anim.SetBool("IsFlying",true);
        }
        else
        {
         anim.SetBool("IsFlying",false);
        }
        
        }

              
    }
}
