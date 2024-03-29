using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionManager : MonoBehaviour
{
    public bool click = false;
    public GameObject Option;
    public GameObject OptionTool;

    public AudioSource startBGM;

    public GameObject Sound_On;
    public GameObject Sound_Off;
    public GameObject SoundEffect_On;
    public GameObject SoundEffect_Off;
    public GameObject Vibration_On;
    public GameObject Vibration_Off;


    ButtonEvent buttonEvent;
    [SerializeField] Text Exit;
    [SerializeField] Text ExitNo;
    [SerializeField] Text ExitYes;
    [SerializeField] Text OptionText;
    [SerializeField] Text Option_Language;
    [SerializeField] Text Help;
    [SerializeField] Text HelpText1;
    [SerializeField] Text HelpText2;
    [SerializeField] Text BestScore;
    [SerializeField] Text Score;


    public GameObject Title_English;
    public GameObject Title_Korea;


    private void Start()
    {
        buttonEvent = FindObjectOfType<ButtonEvent>();

        if (GameControl.control.Sound == true)
        {
            startBGM.volume = 1;
            Sound_On.SetActive(true);
            Sound_Off.SetActive(false);
        }
        else
        {
            startBGM.volume = 0;
            Sound_On.SetActive(false);
            Sound_Off.SetActive(true);
        }

        if (GameControl.control.SoundEffect == true)
        {
            SoundEffect_On.SetActive(true);
            SoundEffect_Off.SetActive(false);
        }
        else
        {
            SoundEffect_On.SetActive(false);
            SoundEffect_Off.SetActive(true);
        }

        if (GameControl.control.Vibration == true)
        {
            Vibration_On.SetActive(true);
            Vibration_Off.SetActive(false);
        }
        else
        {
            Vibration_On.SetActive(false);
            Vibration_Off.SetActive(true);
        }
    }

    void Update()
    {
        if (click == true)
        {
            Option.SetActive(true);
            OptionTool.SetActive(true);
        }

        if (click == false)
        {
            Option.SetActive(false);
            OptionTool.SetActive(false);
        }

        if (GameControl.control.Language == false)
        {
            Title_Korea.SetActive(true);
            Title_English.SetActive(false);
            Exit.text = "정말 나가실건가요?";
            ExitNo.text = "아니요";
            ExitYes.text = "네";
            OptionText.text = "설정";
            Option_Language.text = "English";
            Help.text = "도움";
            HelpText1.text = "화면을 기울여 맵을 기울일 수 있습니다.";
            HelpText2.text = "고양이는 구르거나 점프할 수 있습니다.";
            BestScore.text = "최고점수\n0";
            Score.text = "현재점수\n0";
        }
        else
        {
            Title_Korea.SetActive(false);
            Title_English.SetActive(true);
            Exit.text = "Are you really going out?";
            ExitNo.text = "No";
            ExitYes.text = "Yes";
            OptionText.text = "Option";
            Option_Language.text = "한국어";
            Help.text = "Help";
            HelpText1.text = "You can tile the screen to tilt the map.";
            HelpText2.text = "Cat can roll and jump";
            BestScore.text = "BestScore\n0";
            Score.text = "Score\n0";
        }
    }

    public void Sound_on_off()
    {
        if (GameControl.control.Sound == true)
        {
            startBGM.volume = 0;
            Sound_On.SetActive(false);
            Sound_Off.SetActive(true);
            GameControl.control.Sound = false;
        }
        else
        {
            startBGM.volume = 1;
            Sound_On.SetActive(true);
            Sound_Off.SetActive(false);
            GameControl.control.Sound = true;
        }
    }

    public void SoundEffect_on_off()
    {
        if (GameControl.control.SoundEffect == true)
        {
            SoundEffect_On.SetActive(false);
            SoundEffect_Off.SetActive(true);
            GameControl.control.SoundEffect = false;
        }
        else
        {
            SoundEffect_On.SetActive(true);
            SoundEffect_Off.SetActive(false);
            GameControl.control.SoundEffect = true;
            GameControl.control.Button();
        }
    }

    public void Vibration_on_off()
    {
        if (GameControl.control.Vibration == true)
        {
            Vibration_On.SetActive(false);
            Vibration_Off.SetActive(true);
            GameControl.control.Vibration = false;
        }
        else
        {
            Handheld.Vibrate();
            Vibration_On.SetActive(true);
            Vibration_Off.SetActive(false);
            GameControl.control.Vibration = true;
        }
    }
}
