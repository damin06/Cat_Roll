/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl control;
    
    //public bool Language = false;
    *//*public bool Sound = true;
    public bool SoundEffect = true;
    public bool Vibration = true;*//*

    public AudioSource CatSound;
    public AudioSource ButtonClick;

    public int coin = 1000;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        if (control == null)
        {
            control = this;
        }
        else if (control != this)
        {
            Destroy(this.gameObject);
        }
    }

    *//*public void CatButton()
    {
        CatSound.Play();
    }

    public void Button()
    {
        if (SoundEffect == true)
        ButtonClick.Play();
    }*//*
}*/
