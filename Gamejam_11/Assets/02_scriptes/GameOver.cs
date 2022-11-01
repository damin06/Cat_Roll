using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField]GameObject playe;
    [SerializeField]GameObject playerpos;
    [SerializeField]Image TT;
    [SerializeField]Image moneimage;
    [SerializeField]Image scoreimage;
    [SerializeField]Image black;
    [SerializeField]Image white;
    [SerializeField]Button ok;
    [SerializeField]Text scoreTXT;
    [SerializeField]Text moneyTXT;
    void Awakeart()
    {
        
     gamererode();
    }   
void gamererode()
{
  //
}
    // Update is called once per frame
    void Update()
    {

        if(Player.isDIe ==true)
        {
            Time.timeScale=0;   
            GamePause();
        }
    }
    private void GamePause()
    {
        TT.gameObject.SetActive(true);
        moneimage.gameObject.SetActive(true);
        scoreimage.gameObject.SetActive(true);
        scoreTXT.gameObject.SetActive(true);
        moneyTXT.gameObject.SetActive(true);
        scoreTXT.text="  "+string.Format("{0:N0}", score.time);
        moneyTXT.text="  "+score.time/10;
        ok.gameObject.SetActive(true);
        white.gameObject.SetActive(true);
        black.gameObject.SetActive(true);
    }
    public void gohome()
    {
        Player.isDIe = false;
               Time.timeScale=1;   
               playe.transform.position=playerpos.transform.position;
                 //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Start");
     
    }
}
