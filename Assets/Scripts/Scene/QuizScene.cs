using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizScene : MonoBehaviour
{

    void Start()
    {      
        UIManager uimanager = UIManager.GetInstance();
        uimanager.SetEventSystem();
        uimanager.OpenUI("UIQuiz");
        
    }


}
