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



    IEnumerator Movement()
    {
        yield return new WaitForSeconds(17f);
        Vector3 a=transform.position;
        Vector3 b=target.position;
        if(Mathf.Floor(a.x)!=Mathf.Floor(b.x) || Mathf.Floor(a.y)!=Mathf.Floor(b.y) || Mathf.Floor(a.z)!=Mathf.Floor(b.z))
        {
        transform.position=Vector3.MoveTowards(a,Vector3.Lerp(a,b,t),speed);
        anim.SetBool("IsWalking",true);
        }
        else
        {
          float degrees = 160;
          Vector3 to = new Vector3(0,degrees,0);
          transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
          anim.SetBool("IsWalking",false);
        }  
    } 

    void FixedUpdate()
    {
       StartCoroutine(Movement());     
    }
 
}
