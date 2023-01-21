using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AndroidBackManager : MonoBehaviour
{
    ExitManager exitManager;
    OptionManager optionManager;
    HelpManager helpManager;
    SkinHelpManager skinHelpManager;
    Random11 random11;

    private void Start()
    {
        exitManager = FindObjectOfType<ExitManager>();
        optionManager = FindObjectOfType<OptionManager>();
        helpManager = FindObjectOfType<HelpManager>();
        skinHelpManager = FindObjectOfType<SkinHelpManager>();
        random11 = FindObjectOfType<Random11>();
    }

    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (SceneManager.GetActiveScene().name == "Start")
            {
                if (exitManager.ExitClick == true)
                {
                    if (Input.GetKeyDown(KeyCode.Escape))
                    {
                        //GameControl.control.Button();
                        exitManager.ExitClick = false;
                    }
                }
                else if (optionManager.click == false && helpManager.HelpClick == false)
                {
                    if (Input.GetKeyDown(KeyCode.Escape))
                    {
                        //GameControl.control.Button();
                        exitManager.ExitClick = true;
                    }
                }
            }

            if (SceneManager.GetActiveScene().name == "Skin")
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    //GameControl.control.Button();
                    SceneManager.LoadScene("Start");
                }
            }

            if (SceneManager.GetActiveScene().name == "random")
            {
                if (Input.GetKeyDown(KeyCode.Escape) && random11.gachabutton == true)
                {
                    //GameControl.control.Button();
                    SceneManager.LoadScene("Skin");
                }
            }

            if (optionManager.click == true)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    //GameControl.control.Button();
                    optionManager.click = false;
                }
            }

            if (helpManager.HelpClick == true)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    //GameControl.control.Button();
                    helpManager.HelpClick = false;
                }
            }
        }
    }
}
