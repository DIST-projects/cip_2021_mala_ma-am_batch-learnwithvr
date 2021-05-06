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
    IEnumerator Movement()  
    {
        yield return new WaitForSeconds(23f);   
        Vector3 peacockpos=peacock.position;
        Vector3 peacocktargpos=peacocktarget.position;
        Vector3 a=transform.position;
        Vector3 b=target.position;
        if(Mathf.Floor(a.x)!=Mathf.Floor(b.x) || Mathf.Floor(a.y)!=Mathf.Floor(b.y) || Mathf.Floor(a.z)!=Mathf.Floor(b.z))
        {
        transform.position=Vector3.MoveTowards(a,Vector3.Lerp(a,b,t),speed);
        anim.SetBool("IsFlying",true);
        }
        else
        {
         anim.SetBool("IsFlying",false);
        }
        
      
    }

    void FixedUpdate()
    {
        StartCoroutine(Movement());
              
    }
}
