using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UIManager.GetInstance().SetEventSystem();
        QuizManager.GetInstance().OpenQuiz();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
