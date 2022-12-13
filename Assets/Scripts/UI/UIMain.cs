using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIMain : MonoBehaviour
{

    public Button btnMath;
    public Button btnScience;
    public Button btnHistory;
    public Button btnRiddle;
    // Start is called before the first frame update
    void Start()
    {
        btnMath.onClick.AddListener(OnClickMath);
        btnScience.onClick.AddListener(OnClickScience);
        btnHistory.onClick.AddListener(OnClickHistory);
        btnRiddle.onClick.AddListener(OnClickRiddle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnClickMath()
    {
        QuizManager.GetInstance().quiztype = Quiz.Math;
        SceneManager.LoadScene("Quiz");
        
    }

    private void OnClickScience()
    {
        QuizManager.GetInstance().quiztype = Quiz.Science;
        SceneManager.LoadScene("Quiz");
    }

    private void OnClickHistory()
    {
        QuizManager.GetInstance().quiztype = Quiz.History;
        SceneManager.LoadScene("Quiz");
    }

    private void OnClickRiddle()
    {
        QuizManager.GetInstance().quiztype = Quiz.Riddle;
        SceneManager.LoadScene("Quiz");
    }
}
