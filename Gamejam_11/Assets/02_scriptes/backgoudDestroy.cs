using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgoudDestroy : MonoBehaviour
{

        private void OnTriggerEnter2D(Collider2D other) 
     {  
        
   
         if(other.CompareTag("cloud"))
         {
            Destroy();
         }
     }   
     private void Destroy()
     {
        Destroy(gameObject,18);
     }
}
