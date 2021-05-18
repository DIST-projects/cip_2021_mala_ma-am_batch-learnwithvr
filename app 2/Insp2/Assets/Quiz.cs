using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[System.Serializable]
public class Quiz
{
    public string Question;
    public string[] Answers;
    public int rightAnswer;
}

[System.Serializable]
public class ImgQuiz
{
    public Sprite Question;
    public string[] Answers;
    public int rightAnswer;

}