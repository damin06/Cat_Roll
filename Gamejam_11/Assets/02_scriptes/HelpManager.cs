using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpManager : MonoBehaviour
{
    public bool HelpClick = false;
    public GameObject Help;
    public GameObject HelpTool;

    void Update()
    {
        if (HelpClick == true)
        {
            Help.SetActive(true);
            HelpTool.SetActive(true);
        }

        if (HelpClick == false)
        {
            Help.SetActive(false);
            HelpTool.SetActive(false);
        }
    }
}
