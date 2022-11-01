using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{
  public static bool  isPuause=false;
   

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GamePauseButton()
    {
        isPuause=!isPuause;
        if(isPuause)
        {
            Time.timeScale=0;
        }
        else
        {
            Time.timeScale = 1f;
        }
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }
}
