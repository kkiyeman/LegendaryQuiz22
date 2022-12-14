using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //OpenTitle();
        UIManager uimanager = UIManager.GetInstance();
        uimanager.SetEventSystem();
        uimanager.OpenUI("UIMain");

        
        ScoreManager scoremanager = ScoreManager.GetInstance();

        QuizManager quizmanager = QuizManager.GetInstance();


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OpenTitle()
    {
        Object go = FindObjectOfType<UIMain>();
        if (go == null)
        {
            Object title = Resources.Load("UI/UIMain");
            GameObject maintitle = (GameObject)Instantiate(title);
            maintitle.GetComponent<UIMain>();
        }
    }

}
