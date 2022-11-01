using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnLock : MonoBehaviour
{
    Random11 random11;

    public bool cat222;
    public bool cat333;
    public bool cat444;
    public bool cat555;
    public bool cat666;

    private void Start()
    {
        random11 = FindObjectOfType<Random11>();

        if (random11.cat22 == 1)
        {
            cat222 = true;
            SkinChoose.skin.Cat2 = true;
        }
        if (random11.cat33 == 1)
        {
            cat333 = true;
            SkinChoose.skin.Cat3 = true;
        }
        if (random11.cat44 == 1)
        {
            cat444 = true;
            SkinChoose.skin.Cat4 = true;
        }
        if (random11.cat55 == 1)
        {
            cat555 = true;
            SkinChoose.skin.Cat5 = true;
        }
        if (random11.cat66 == 1)
        {
            cat666 = true;
            SkinChoose.skin.Cat6 = true;
        }
    }

    public Image cat2;
    public Image cat3;
    public Image cat4;
    public Image cat5;
    public Image cat6;

    public GameObject skinChoose1;
    public GameObject skinChoose2;
    public GameObject skinChoose3;
    public GameObject skinChoose4;
    public GameObject skinChoose5;
    public GameObject skinChoose6;

    // Update is called once per frame
    void Update()
    {

        if (SkinChoose.skin.Cat2 == true || cat222 == true)
        {
            cat2.color = Color.white;
        }

        if (SkinChoose.skin.Cat3 == true || cat3 == true)
        {
            cat3.color = Color.white;
        }

        if (SkinChoose.skin.Cat4 == true || cat4 == true)
        {
            cat4.color = Color.white;
        }

        if (SkinChoose.skin.Cat5 == true || cat5 == true)
        {
            cat5.color = Color.white;
        }

        if (SkinChoose.skin.Cat6 == true || cat6 == true)
        {
            cat6.color = Color.white;
        }
    }

    public void catSeclect(int a)
    {
        switch (a)
        {
            case 1:
                GameControl.control.CatButton();
                skinChoose1.SetActive(true);
                skinChoose2.SetActive(false);
                skinChoose3.SetActive(false);
                skinChoose4.SetActive(false);
                skinChoose5.SetActive(false);
                skinChoose6.SetActive(false);
                SkinChoose.skin.SeclectCat = 1;
                break;
            case 2:
                if (SkinChoose.skin.Cat2 == true)
                {
                    GameControl.control.CatButton();
                    skinChoose1.SetActive(false);
                    skinChoose2.SetActive(true);
                    skinChoose3.SetActive(false);
                    skinChoose4.SetActive(false);
                    skinChoose5.SetActive(false);
                    skinChoose6.SetActive(false);
                    SkinChoose.skin.SeclectCat = 2;
                }
                break;
            case 3:
                if (SkinChoose.skin.Cat3 == true)
                {
                    GameControl.control.CatButton();
                    skinChoose1.SetActive(false);
                    skinChoose2.SetActive(false);
                    skinChoose3.SetActive(true);
                    skinChoose4.SetActive(false);
                    skinChoose5.SetActive(false);
                    skinChoose6.SetActive(false);
                    SkinChoose.skin.SeclectCat = 3;
                }
                break;
            case 4:
                if (SkinChoose.skin.Cat4 == true)
                {
                    GameControl.control.CatButton();
                    skinChoose1.SetActive(false);
                    skinChoose2.SetActive(false);
                    skinChoose3.SetActive(false);
                    skinChoose4.SetActive(true);
                    skinChoose5.SetActive(false);
                    skinChoose6.SetActive(false);
                    SkinChoose.skin.SeclectCat = 4;
                }
                break;
            case 5:
                if (SkinChoose.skin.Cat5 == true)
                {
                    GameControl.control.CatButton();
                    skinChoose1.SetActive(false);
                    skinChoose2.SetActive(false);
                    skinChoose3.SetActive(false);
                    skinChoose4.SetActive(false);
                    skinChoose5.SetActive(true);
                    skinChoose6.SetActive(false);
                    SkinChoose.skin.SeclectCat = 5;
                }
                break;
            case 6:
                if (SkinChoose.skin.Cat6 == true)
                {
                    GameControl.control.CatButton();
                    skinChoose1.SetActive(false);
                    skinChoose2.SetActive(false);
                    skinChoose3.SetActive(false);
                    skinChoose4.SetActive(false);
                    skinChoose5.SetActive(false);
                    skinChoose6.SetActive(true);
                    SkinChoose.skin.SeclectCat = 6;
                }
                break;
        }
    }
}
