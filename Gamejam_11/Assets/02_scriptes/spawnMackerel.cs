using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMackerel : MonoBehaviour
{
        [SerializeField]private stagedata Stagedata ;
        [SerializeField]GameObject Mackerel;
            [SerializeField]private float spawnMIN;
    [SerializeField]private float spawnMAX;
    [SerializeField]Transform llimitMINPOS;
    [SerializeField]Transform limitMAXPOS;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MackerelSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator MackerelSpawn()
    {
        if(Player.isDIe==false)
        {
            while(true)
            {
                        float a = Random.Range(spawnMIN,spawnMAX);
                yield return new WaitForSeconds(a);
                float posX=Random.Range(llimitMINPOS.position.x, limitMAXPOS.position.x);
                float posY=Random.Range(llimitMINPOS.position.y,limitMAXPOS.position.y);
                    Instantiate(Mackerel,new Vector3(posX, posY),Quaternion.identity);
            }
         }
    }
}
