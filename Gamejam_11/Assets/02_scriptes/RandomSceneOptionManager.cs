using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSceneOptionManager : MonoBehaviour
{
    public AudioSource RandomBGM;

    private void Start()
    {
        if (GameControl.control.Sound == true)
        {
            RandomBGM.volume = 1;
        }
        else
        {
            RandomBGM.volume = 0;
        }
    }
}
