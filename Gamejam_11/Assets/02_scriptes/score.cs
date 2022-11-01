using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    [SerializeField]Text timeText;
    public static float time;
    void Start(){
        time=0;
    }

    void Update()
    {
        if(Player.isDIe==false)
        {
          time += Time.deltaTime;
        }
  

         timeText.text = string.Format("{0:N0}", time);
    }
}
