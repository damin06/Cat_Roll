using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScripts_exit : MonoBehaviour
{
    public GameObject Result_PopUp;
    public GameObject Result_Btn;
    public GameObject Result_Text;

    public GameObject Gi1;
    public GameObject Gi2;
    public GameObject Gi3;
    public GameObject Gi4;
    public GameObject Gi5;
  
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void result()
    {
        Result_PopUp.SetActive(false);
        Result_Btn.SetActive(false);
        Result_Text.SetActive(false);

        Gi1.SetActive(false);
        Gi2.SetActive(false);
        Gi3.SetActive(false);
        Gi4.SetActive(false);
        Gi5.SetActive(false);
       
       
    }
}
