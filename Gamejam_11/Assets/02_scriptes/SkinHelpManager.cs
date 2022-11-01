using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinHelpManager : MonoBehaviour
{
    public bool SkinHelpClick = false;
    public GameObject SkinHelp;
    public GameObject SkinHelpTool;

    void Update()
    {
        if (SkinHelpClick == true)
        {
            SkinHelp.SetActive(true);
            SkinHelpTool.SetActive(true);
        }

        if (SkinHelpClick == false)
        {
            SkinHelp.SetActive(false);
            SkinHelpTool.SetActive(false);
        }
    }
}
