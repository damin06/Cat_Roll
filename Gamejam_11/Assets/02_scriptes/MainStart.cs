using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainStart : MonoBehaviour
{
    float time = 0;

    public void Update()
    {
        if (time < 1f)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1 - time);
        }
        else
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, time);
            if (time > 1.5f)
            {
                time = 0;
            }
        }

        time += Time.deltaTime;
    }




}
