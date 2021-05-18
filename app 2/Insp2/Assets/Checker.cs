using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Checker : MonoBehaviour
{
    public bool isRight = false;
    public GameController gameController;


    public void Answer()
    {
        if(isRight)
        {

           
            Debug.Log("Right Answer");
            gameController.right();
        }
        else
        {
            
            Debug.Log("Wrong Answer");
            gameController.wrong();
        }
    }
}
