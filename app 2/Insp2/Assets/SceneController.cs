using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    
    public void menu()

    {
         SceneManager.LoadScene("Menu");
    }

    public void Exercise1()
    {
         SceneManager.LoadScene("SampleScene");
    }
    public void Exercise2()
    {
         SceneManager.LoadScene("Exercise1");
    }
    public void Exercise3()
    {
         SceneManager.LoadScene("Exercise2");
    }
    public void Exercise4()
    {
         SceneManager.LoadScene("Exercise3");
    }
    public void Exercise5()
    {
         SceneManager.LoadScene("Exercise4");
    }
    public void Exercise6()
    {
         SceneManager.LoadScene("Exercise5");
    }
}
