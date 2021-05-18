using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public List<Quiz> Questions;
    public GameObject[] options;
    public GameObject start;
    public GameObject quizp;
     public GameObject scorep;
    public int current;
    private int correctop;
    private int gameScore=0;

    public TextMeshProUGUI DisplayQuestion;
    public TextMeshProUGUI DisplayScore;
    int questionsCount = 0;


    public void displayScore()
    {
       quizp.SetActive(false);
       scorep.SetActive(true);
       DisplayScore.text="   cq;fs; kjpg;ngz;fs; "+ questionsCount  +  " f;F "  + gameScore;
    }
    private void Start()
    {
        quizp.SetActive(false);
        scorep.SetActive(false);
        questionsCount = Questions.Count;
        Debug.Log(questionsCount);
        Debug.Log(options.Length);
        getQuestion();
    }

    public void right()
    {
        gameScore+=1;
        options[correctop].GetComponent<Image>().color = Color.green;
        Questions.RemoveAt(current);
        StartCoroutine(getNextQuestion());
    }

    public void wrong()
    {
        Questions.RemoveAt(current);
        StartCoroutine(getNextQuestion());
    }

    IEnumerator getNextQuestion()
    {
        yield return new WaitForSeconds(1);
         options[correctop].GetComponent<Image>().color = Color.white;
        getQuestion();
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Checker>().isRight = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Questions[current].Answers[i];
            
            if(Questions[current].rightAnswer == i+1)
            {
                correctop = i;
                options[i].GetComponent<Checker>().isRight = true;
            }
        }
    }

    void getQuestion()
    {
        if(Questions.Count > 0)
        {
            current = Random.Range(0, Questions.Count);
            DisplayQuestion.text = Questions[current].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("End of Quiz");
            displayScore();
        }


    }
}
