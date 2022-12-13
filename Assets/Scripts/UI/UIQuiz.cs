using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIQuiz : MonoBehaviour
{
    public Image quiztype;
    public Text title;
    public Text numQ;
    public Text txtQ;
    public Text[] txtAnswers;
    

    public Button[] buttons;

    QuizGen[] nQuiz;
    QuizGen realQuiz;

    public int curNum=0;
    public int curScore = 0;
   
    // Start is called before the first frame update
    void Start()
    {

        UIconfirm(QuizManager.GetInstance().quiztype);
        
    }

    public void UIconfirm(Quiz quiztype)
    {
        var quizmanager = QuizManager.GetInstance();
        nQuiz = quizmanager.quizList[quiztype];
        curNum = 0; 
        title.text = quiztype.ToString();
        realQuiz = nQuiz[curNum];
        numQ.text = realQuiz.numQ;
        txtQ.text = realQuiz.txtQ;
        for (int i = 0; i < realQuiz.txtA.Length; i++)
        {
            txtAnswers[i].text = realQuiz.txtA[i];
        }
        for (int i = 0; i < buttons.Length; i++)
        {
            int idx = i;
            buttons[i].onClick.AddListener(() => { OnClickAnswer(idx); });
        }

    }
    
    public void UIUpdate()
    {
        ResetButton();
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].onClick.RemoveAllListeners();
        }
        if (curNum >= nQuiz.Length)
        {
            ScoreManager.GetInstance().quizcount++;
            SceneManager.LoadScene("Result");
        }
        else
        {
            realQuiz = nQuiz[curNum];
            numQ.text = realQuiz.numQ;
            txtQ.text = realQuiz.txtQ;
            for (int i = 0; i < realQuiz.txtA.Length; i++)
            {
                txtAnswers[i].text = realQuiz.txtA[i];
            }

        }
        int length = realQuiz.txtA.Length;
        for (int l = 3; l >= length; l--)
        {
            buttons[l].gameObject.SetActive(false);
        }

        for (int i = 0; i < length; i++)
        {
            int idx = i;
            buttons[i].onClick.AddListener(() => { OnClickAnswer(idx); });
        }


    }

    public void OnClickAnswer(int a)
    {

        if (realQuiz.corrctNum == a)
        {
            ScoreManager.GetInstance().CorrectCount++;
            ScoreManager.GetInstance().AddScores(realQuiz.correctScore);
        }
        curNum++;

        UIUpdate();
  
    }

   
    public void ResetButton()
    {
        for(int i=0; i<buttons.Length;i++)
        {
            buttons[i].gameObject.SetActive(true);
        }
    }
}

