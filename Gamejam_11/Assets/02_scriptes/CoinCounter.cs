using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    [SerializeField]Text COinTXT;
 public static  int Coin;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        COinTXT.text=Coin.ToString();
    }
}
