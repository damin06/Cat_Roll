using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitManager : MonoBehaviour
{
    public bool ExitClick = false;
    public GameObject Exit;
    public GameObject ExitTool;

    void Update()
    {
        if(ExitClick == true)
        {
            Exit.SetActive(true);
            ExitTool.SetActive(true);
        }

        if (ExitClick == false)
        {
            Exit.SetActive(false);
            ExitTool.SetActive(false);
        }
    }

    public void tlqkf()
    {
        ExitClick = true;
        ExitTool.SetActive(true);
        Debug.Log("tlqkffff");
    }
}
