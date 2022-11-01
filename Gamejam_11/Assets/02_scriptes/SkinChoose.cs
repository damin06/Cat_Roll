using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinChoose : MonoBehaviour
{
    public static SkinChoose skin;

    public bool Cat2 = false;
    public bool Cat3 = false;
    public bool Cat4 = false;
    public bool Cat5 = false;
    public bool Cat6 = false;

    public int SeclectCat = 1;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (skin == null)
        {
            skin = this;
        }
        else if (skin != this)
        {
            Destroy(this.gameObject);
        }
    }
}
