using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Random11 : MonoBehaviour
{
    // public
    AudioSource audioSource;
    AudioSource audioSource2;


    // 활성화,비활성화 할 오브젝트
    private float currenttime=3;

    public GameObject DrawShop; // 뽑기 상점
    public GameObject DrawWindow; // 뽑는 창

    
    // 불러올 이미지 오브젝트
    public Image DrawImage; // 랜덤 이미지를 출력할 오브젝트
    public RectTransform DrawImageRT; // 랜덤 이미지 출력할 오브젝트 렉트 트랜스폼


    //숫자 이미지
    public Sprite Image1;
    public Sprite Image2;
    public Sprite Image3;
    public Sprite Image4;
    public Sprite Image5;
    
   
    public GameObject Gi1;
    public GameObject Gi2;
    public GameObject Gi3;
    public GameObject Gi4;
    public GameObject Gi5;
    
    
    public Sprite RanCats;

    public GameObject Result_PopUp;
    public GameObject Result_Btn;
    public GameObject Result_Text;

    public GameObject ExitButton;

    public GameObject skinAll;
    public GameObject skinAllBackGround;


    public GameObject GachaButton;


    // 변수
    public int RandomInt; // 랜덤 변수

    private void Awake()
    {
        audioSource = GameObject.Find("CelebrationSound").GetComponent<AudioSource>();
        audioSource2 = GameObject.Find("LingingSound").GetComponent<AudioSource>();
    }

    void Update()
    {
        RandomInt = Random.Range(0, 5);
        currenttime += Time.deltaTime;
    }

    public void OneDraw() // 1회 뽑기 버튼을 클릭 시
    {
        DrawImageRT.sizeDelta = new Vector2(400, 400); //고양이 사이즈 조절
        if (currenttime > 1.3f)
        {
            /*if (GameControl.control.coin >= 100)
            {
                ExitButton.SetActive(false);

                GameControl.control.coin -= 100;

                DrawShop.SetActive(false); //뽑기 선택 화면을 비활성화하고,
                DrawWindow.SetActive(true);// 랜덤 이미지를 출력한 화면을 활성화합니다.

                StartCoroutine("Audio");

                StartCoroutine("RandomOn");

                Button();
            }*/

            if (SkinChoose.skin.Cat2 == true && SkinChoose.skin.Cat3 == true && SkinChoose.skin.Cat4 == true && SkinChoose.skin.Cat5 == true && SkinChoose.skin.Cat6 == true)
            {
                skinAll.SetActive(true);
                skinAllBackGround.SetActive(true);
            }
        }
    }

    public bool gachabutton = true;

    public void Button()
    {
        gachabutton = false;
        GachaButton.SetActive(false);
        Invoke("ButtonLate", 3.25f);
    }

    public void ButtonLate()
    {
        gachabutton = true;
        GachaButton.SetActive(true);
    }

    public void skinAllNo()
    {
        skinAll.SetActive(false);
        skinAllBackGround.SetActive(false);
    }

    IEnumerator Audio()
    {
        audioSource2.Play();
        yield return new WaitForSeconds(1.0f);
        audioSource2.Play();
        yield return new WaitForSeconds(1.0f);
        audioSource2.Play();
    }

    IEnumerator RandomOn()
    {
        currenttime = 0;

        for (int i = 0; i <= 7; i++)
        {
            DrawImage.sprite = Image1;
            yield return new WaitForSeconds(0.1f);

            DrawImage.sprite = Image2;
            yield return new WaitForSeconds(0.1f);

            DrawImage.sprite = Image3;
            yield return new WaitForSeconds(0.1f);

            DrawImage.sprite = Image4;
            yield return new WaitForSeconds(0.1f);

            DrawImage.sprite = Image5;
        }

        Gacha();
    }

    public int cat22 = PlayerPrefs.GetInt("Cat2");
    public int cat33 = PlayerPrefs.GetInt("Cat3");
    public int cat44 = PlayerPrefs.GetInt("Cat4");
    public int cat55 = PlayerPrefs.GetInt("Cat5");
    public int cat66 = PlayerPrefs.GetInt("Cat6");

    public List<string> GachaList = new List<string>() { "cat2", "cat3", "cat4", "cat5", "cat6" };

    public void Gacha()
    {
        int rand = Random.Range(0, GachaList.Count);

        if (GachaList[rand] == "cat5") // RandomInt가 1이라면
        {
                audioSource.Play();

                DrawImage.sprite = Image1;
                Result_PopUp.SetActive(true);
                Result_Btn.SetActive(true);
                Result_Text.SetActive(true);
                ExitButton.SetActive(true);

                SkinChoose.skin.Cat5 = true;
            PlayerPrefs.SetInt("White", 1);
                Gi1.SetActive(true);

            GachaList.RemoveAt(rand);

                PlayerPrefs.SetInt("Cat2", 1);
        }
        else if (GachaList[rand] == "cat4")
        {
                audioSource.Play();

                DrawImage.sprite = Image2;
                Result_PopUp.SetActive(true);
                Result_Btn.SetActive(true);
                Result_Text.SetActive(true);
                ExitButton.SetActive(true);

                SkinChoose.skin.Cat4 = true;
            PlayerPrefs.SetInt("Black", 1);
            Gi2.SetActive(true);

            GachaList.RemoveAt(rand);

            PlayerPrefs.SetInt("Cat3", 1);
        }
        else if (GachaList[rand] == "cat3")
        {
                audioSource.Play();

                DrawImage.sprite = Image3;
                Result_PopUp.SetActive(true);
                Result_Btn.SetActive(true);
                Result_Text.SetActive(true);
                ExitButton.SetActive(true);

                SkinChoose.skin.Cat3 = true;
            PlayerPrefs.SetInt("Gray", 1);
            Gi3.SetActive(true);

            GachaList.RemoveAt(rand);

            PlayerPrefs.SetInt("Cat4", 1);
        }
        else if (GachaList[rand] == "cat2")
        {
                audioSource.Play();

                DrawImage.sprite = Image4;
                Result_PopUp.SetActive(true);
                Result_Btn.SetActive(true);
                Result_Text.SetActive(true);
                ExitButton.SetActive(true);

                SkinChoose.skin.Cat2 = true;
            PlayerPrefs.SetInt("3col", 1);
            Gi4.SetActive(true);

            GachaList.RemoveAt(rand);

            PlayerPrefs.SetInt("Cat5", 1);
        }
        else
        {
                audioSource.Play();

                DrawImage.sprite = Image5;
                Result_PopUp.SetActive(true);
                Result_Btn.SetActive(true);
                Result_Text.SetActive(true);
                ExitButton.SetActive(true);

                SkinChoose.skin.Cat6 = true;

                Gi5.SetActive(true);

            GachaList.RemoveAt(rand);
            PlayerPrefs.SetInt("Sham", 1);
            PlayerPrefs.SetInt("Cat6", 1);
        }

        DrawImageRT.sizeDelta = new Vector2(400, 400); //결과 고양이 사이즈 조절

        Invoke("CloseDraw", 0.0f);

        
    }

    public void CloseDraw() // 뽑기 스크립트가 실행되고 자동으로 실행되게 합니다.
    {
        DrawImage.sprite = RanCats; // 적용했던 이미지를 초기화합니다.
        DrawShop.SetActive(true); // 뽑기 선택 화면을 활성화 하고,
        DrawWindow.SetActive(false); // 랜덤 이미지 화면을 비활성화합니다
    }
}