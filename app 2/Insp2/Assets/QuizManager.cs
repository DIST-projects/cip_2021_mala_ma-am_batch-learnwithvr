using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers>QnA;
    public GameObject[] options;
    public int currentQuestion;
    private int correctop;


    public TextMeshProUGUI QuestionTxt;

    int totalQuestions = 0;

    private void Start()
    {
        totalQuestions = QnA.Count;
        Debug.Log(totalQuestions);
        Debug.Log(options.Length);
        generateQuestion();
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

  /*  void GameOver()
    {
  
        ScoreTxt.text = score + "/" + totalQuestions;
    } */

    public void correct()
    {
        //score += 1;
        options[correctop].GetComponent<Image>().color = Color.green;
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }

    public void wrong()
    {
      
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }

    IEnumerator waitForNext()
    {
        yield return new WaitForSeconds(1);
        options[correctop].GetComponent<Image>().color = Color.white;
        generateQuestion();
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[currentQuestion].Answers[i];
            
            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                correctop=i;
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
          
        }
    }

    void generateQuestion()
    {
        if(QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of Questions");
            //GameOver();
        }


    }
}
