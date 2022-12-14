using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        OpenResult();
    }


    public void OpenResult()
    {
        Object rs = FindObjectOfType<UIResult>();
        if (rs == null)
        {
            Object rrs = Resources.Load("UI/UIResult");
            GameObject result = (GameObject)Instantiate(rrs);
            result.GetComponent<UIMain>();
        }
    }
}
