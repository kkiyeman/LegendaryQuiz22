using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizGen
{
    public string Genre;
    public string numQ;
    public string txtQ;

    public string[] txtA;

    public int correctScore;
    public int corrctNum;

    public QuizGen(string qnum,string qtxt,string[] atxt, int cscore, int cnum)
    {
        numQ = qnum;
        txtQ = qtxt;
        txtA = atxt;
        correctScore = cscore;
        corrctNum = cnum;
    }

}
