using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StartScript : MonoBehaviour
{
   public Headings Head=new Headings();
   public GameObject quizp;
   public GameObject startp;
   public TextMeshProUGUI DisplayHeading;
   private int headCount=0;
   public void Start()
   {
       setHeading();
   } 
   public void setHeading()
   {
     DisplayHeading.text=Head.H[headCount++];   
   }
   public void setQuizPActive()
   {
      startp.SetActive(false);
      quizp.SetActive(true);
   }

}
