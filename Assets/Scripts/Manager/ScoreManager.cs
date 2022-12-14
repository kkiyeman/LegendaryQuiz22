using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    #region SingletoneMake
    public static ScoreManager instance = null;
    public static ScoreManager GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("@ScoreManager");
            instance = go.AddComponent<ScoreManager>();

            DontDestroyOnLoad(go);
        }
        return instance;
    }
    #endregion

    public int mathScore;
    public int scienceScore;
    public int historyScore;
    public int riddleScore;

    public int totalScore = 0;
    
    public int CorrectCount = 0;
    public int quizcount = 0;
    

    public List<int> scores = new List<int>();


    public void AddScores(int anyscore)
    {
        scores.Add(anyscore);
        totalScore += anyscore;
    }


    #region EvaluationSystem;
    public int GetAverage()
    {
        int totalscore = 0;
        int average = 0;
        for(int i = 0; i<scores.Count; i++)
        {
            totalscore += scores[i];
        }
        average = totalscore / quizcount;
        return average;
    }

    public string Grade()
    {
        int average = GetAverage();
        string grade;
        if (average > 80 && average <= 100)
        {
            grade = "뇌가 섹시함";
        }
        else if (average > 60 && average <= 80)
        {
            grade = "똑똑한 편임";
        }
        else if (average > 40 && average <= 60)
        {
            grade = "말은 통함";
        }
        else
        {
            grade = "고릴라..?";
        }
        return grade;
    }
    #endregion
}
