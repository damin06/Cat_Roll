using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    [SerializeField] Text coincounter;

    // Update is called once per frame
    void Update()
    {
        coincounter.text = "       " + GameControl.control.coin;
    }
}
