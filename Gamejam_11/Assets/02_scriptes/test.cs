using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class test : MonoBehaviour
{
GameObject objecta;
    void Start()
    {
       
        Input.gyro.enabled =true;
    }
    void FixedUpdate()
    {
    Vector3 minusvec=new Vector3(0,-90,0);
        transform.Rotate (0,0,Input.gyro.rotationRateUnbiased.z*0.7f);
    
    }
}
