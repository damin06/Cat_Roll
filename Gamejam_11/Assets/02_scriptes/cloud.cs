using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    [SerializeField]float speed;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.position+=Vector3.right*speed*Time.deltaTime;
    }
       private void OnTriggerEnter2D(Collider2D other) 
       {
        if(other.CompareTag("Player"))
        {
            Debug.Log("하");
            Player.isDIe=true;
        }
       }
}
