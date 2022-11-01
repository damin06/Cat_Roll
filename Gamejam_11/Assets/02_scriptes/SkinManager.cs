using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public int White = 0;
    public int Gray = 0;
    public int Black = 0;
    public int Threecol = 0;
    public int Sham = 0;

    public void Start()
    {
        White = PlayerPrefs.GetInt("White");
        Sham = PlayerPrefs.GetInt("Sham");
        Threecol = PlayerPrefs.GetInt("3col");
        Gray = PlayerPrefs.GetInt("Gray");
        Black = PlayerPrefs.GetInt("Black");

        if (White == 1)
        {
            SkinChoose.skin.Cat5 = true;
        }
        if (Gray == 1)
        {
            SkinChoose.skin.Cat3 = true;
        }
        if (Threecol == 1)
        {
            SkinChoose.skin.Cat2 = true;
        }
        if (Black == 1)
        {
            SkinChoose.skin.Cat4 = true;
        }
        if (Sham == 1)
        {
            SkinChoose.skin.Cat6 = true;
        }
    }


    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void firstload()
    {

    }
    
}


