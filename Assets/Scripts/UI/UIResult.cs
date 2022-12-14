using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIResult : MonoBehaviour
{

    [SerializeField] Text totalscore;
    [SerializeField] Text average;
    [SerializeField] Text grade;
    [SerializeField] Button btnToMain;

    void Start()
    {
        UIManager.GetInstance().SetEventSystem();
        GetScore();
        btnToMain.onClick.AddListener(OnClickReset);      
    }

    public void GetScore()
    {
        totalscore.text = $"Total Score\n{ScoreManager.GetInstance().totalScore}";
        average.text = $"Average\n{ScoreManager.GetInstance().GetAverage()}";
        grade.text = $"Grade\n{ScoreManager.GetInstance().Grade()}";
    }

    public void OnClickReset()
    {
        UIManager.GetInstance().ClearList();
        SceneManager.LoadScene("Main");
    }

}
