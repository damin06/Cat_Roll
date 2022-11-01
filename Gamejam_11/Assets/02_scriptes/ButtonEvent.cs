using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour
{
    public void SceneLoader(string sceneName)
    {
        GameControl.control.Button();
        SceneManager.LoadScene(sceneName);
    }

    public void HomeButton(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    ExitManager exitManager;
    OptionManager optionManager;
    HelpManager helpManager;
    SkinHelpManager skinHelpManager;
    StartAmi startAmi;
    UnLock unLock;
    Random11 random11;

    private void Start()
    {
        exitManager = FindObjectOfType<ExitManager>();
        optionManager = FindObjectOfType<OptionManager>();
        helpManager = FindObjectOfType<HelpManager>();
        skinHelpManager = FindObjectOfType<SkinHelpManager>();
        startAmi = FindObjectOfType<StartAmi>();
        unLock = FindObjectOfType<UnLock>();
        random11 = FindObjectOfType<Random11>();
    }

    public void StartButton()
    {
        GameControl.control.CatButton();
        startAmi.AmiStart = true;
        startAmi.realStart();
    }

    public void GameStart()
    {
        SceneManager.LoadScene("test");
    }

    public void ExitButton()
    {
        GameControl.control.Button();
        exitManager.ExitClick = true;
    }

    public void ExitYesButton()
    {
        Debug.Log("게임 종료");
        Application.Quit();
    }

    public void ExitNoButton()
    {
        GameControl.control.Button();
        exitManager.ExitClick = false;
    }


    public void OptionButton()
    {
        GameControl.control.Button();
        optionManager.click = true;
    }

    public void OptionExit()
    {
        optionManager.click = false;
    }


    public void Option_Language()
    {
        GameControl.control.Button();

        if (GameControl.control.Language == true)
        {
            GameControl.control.Language = false;
        }
        else
        {
            GameControl.control.Language = true;
        }
    }

    public void Option_Sound()
    {
        GameControl.control.Button();
        optionManager.Sound_on_off();
    }

    public void Option_SoundEffect()
    {
        optionManager.SoundEffect_on_off();
    }

    public void Option_Vibration()
    {
        GameControl.control.Button();
        optionManager.Vibration_on_off();
    }


    public void HelpButton()
    {
        GameControl.control.Button();
        helpManager.HelpClick = true;
    }

    public void SkinHelpButton()
    {
        GameControl.control.Button();
        skinHelpManager.SkinHelpClick = true;
    }

    public void HelpNoButton()
    {
        helpManager.HelpClick = false;
    }

    public void SKinHelpNoButton()
    {
        skinHelpManager.SkinHelpClick = false;
    }

    public int catNumber = 0;

    public void CatChoose(int catNum)
    {
        catNumber = catNum;
        unLock.catSeclect(catNumber);
    }

    public void skinAllNoButton()
    {
        random11.skinAllNo();
    }
}
