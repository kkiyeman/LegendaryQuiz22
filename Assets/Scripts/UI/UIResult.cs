using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIResult : MonoBehaviour
{


    public Text totalscore;
    public Text average;
    public Text grade;
    public Button btnToMain;
    // Start is called before the first frame update
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
        SceneManager.LoadScene("Main");
    }



}
