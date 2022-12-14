using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainScene : MonoBehaviour
{

    void Start()
    {
        UIManager uimanager = UIManager.GetInstance();
        uimanager.SetEventSystem();
        uimanager.OpenUI("UIMain");
        
        ScoreManager.GetInstance();
        QuizManager.GetInstance();

    }

}
