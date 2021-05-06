using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeacockMovement : MonoBehaviour
{
    static Animator anim;
    public Transform target;
    public Transform kang;
    public Transform kangtarget;
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
        yield return new WaitForSeconds(35f);
        Vector3 a=transform.position;
        Vector3 b=target.position;
        if(Mathf.Floor(a.x)!=Mathf.Floor(b.x) || Mathf.Floor(a.y)!=Mathf.Floor(b.y) || Mathf.Floor(a.z)!=Mathf.Floor(b.z))
        {
        transform.position=Vector3.MoveTowards(a,Vector3.Lerp(a,b,t),speed);
        anim.SetBool("IsWalking",true);
        }
        else
        {

          float degrees = 180;
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
