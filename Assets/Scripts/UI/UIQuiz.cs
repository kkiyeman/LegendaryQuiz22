using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIQuiz : MonoBehaviour
{
    [SerializeField] Image quiztype;
    [SerializeField] Text title;
    [SerializeField] Text numQ;
    [SerializeField] Text txtQ;
    [SerializeField] List<Text> txtAnswers;


    [SerializeField] List<Button> buttons;

    QuizGen[] nQuiz;
    QuizGen realQuiz;

    public int curNum=0;
    public int curScore = 0;
   

    void Start()
    {
        UIconfirm(QuizManager.GetInstance().quiztype);       
    }

    #region SetQuizUI
    private void UIconfirm(Quiz quiztype)
    {
        var quizmanager = QuizManager.GetInstance();
        nQuiz = quizmanager.quizList[quiztype];
        curNum = 0; 
        title.text = quiztype.ToString();
        TxtSetting();
        SetButton(buttons.Count);
    }
    
    private void UIUpdate()
    {
        ResetButton();
        for (int i = 0; i < buttons.Count; i++)
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
            TxtSetting();
        }
        int length = realQuiz.txtA.Length;
        for (int l = 3; l >= length; l--)
        {
            buttons[l].gameObject.SetActive(false);
        }
        SetButton(length);
    }

    private void SetButton(int count)
    {
        for (int i = 0; i < count; i++)
        {
            int idx = i;
            buttons[i].onClick.AddListener(() => { OnClickAnswer(idx); });
        }
    }

    private void ResetButton()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            buttons[i].gameObject.SetActive(true);
        }
    }

    private void TxtSetting()
    {
        realQuiz = nQuiz[curNum];
        numQ.text = realQuiz.numQ;
        txtQ.text = realQuiz.txtQ;
        for (int i = 0; i < realQuiz.txtA.Length; i++)
        {
            txtAnswers[i].text = realQuiz.txtA[i];
        }
    }
    #endregion

    #region ButtonAction
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
    #endregion   
}

