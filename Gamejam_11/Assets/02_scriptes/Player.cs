using System;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
     [SerializeField]List<Sprite> catidel = new List<Sprite>();
     [SerializeField]List<Sprite> Catup = new List<Sprite>();
     [SerializeField]List<Sprite> CatJump = new List<Sprite>();
       [SerializeField]List<Sprite> CatDie = new List<Sprite>();
     private bool up;
       [SerializeField]private float speed;
     Vector3 vec = Vector3.right;
     float movementscale=24;
     private float jumptime=1;
     private  float nowtime;

     Rigidbody2D rd;
       bool isGround=false;
        bool isrun=false;
       SpriteRenderer spriteRen;
       bool islevitation=false;
      public static bool isDIe=false;
       public float jumpPower=8;
       bool ispushedRunButton=false;  
       bool ispushedFeatButton=false;
       private float CurrenTime=4;
      private Vector3 playerPos;
      bool isjump=false;
      int a;
    void Start()
    {
     
     //SkinChoose.skin.SeclectCat
     a=6;
           spriteRen=GetComponent<SpriteRenderer>();

     switch(a)
     {
          case 1 : 
               spriteRen.sprite=catidel[0];
               break;
          case 2:
               spriteRen.sprite=catidel[1];
               break;
          case 3:
                spriteRen.sprite=catidel[2];
                break;
          case 4:
                spriteRen.sprite=catidel[3];
                break;
          case 5:
                spriteRen.sprite=catidel[4];
                break;
          case 6:
                spriteRen.sprite=catidel[5];
                break;
     }
          
       Input.gyro.enabled =true;
  
    
         rd=GetComponent<Rigidbody2D>();
    }
    void Update()
    {

     if(isjump)
     {
            transform.rotation =Quaternion.Euler(0,0,0);
           nowtime+=Time.deltaTime;
          transform.Rotate(0,0,0);
          if(nowtime>0.35f)
          {
                switch(a)
     {
          case 1 : 
               spriteRen.sprite=CatJump[0];
               break;
          case 2:
               spriteRen.sprite=CatJump[1];
               break;
          case 3:
                spriteRen.sprite=CatJump[2];
                break;
          case 4:
                spriteRen.sprite=CatJump[3];
                break;
          case 5:
                spriteRen.sprite=CatJump[4];
                break;
          case 6:
                spriteRen.sprite=CatJump[5];
                break;
     }
          }
          else
          {
                 switch(a)
     {
          case 1 : 
               spriteRen.sprite=Catup[0];
               break;
          case 2:
               spriteRen.sprite=Catup[1];
               break;
          case 3:
                spriteRen.sprite=Catup[2];
                break;
          case 4:
                spriteRen.sprite=Catup[3];
                break;
          case 5:
                spriteRen.sprite=Catup[4];
                break;
          case 6:
                spriteRen.sprite=Catup[5];
                break;
     }
          }
     }
  
       if(isGround==false)
       {
          jumptime-=Time.deltaTime;
          if(jumptime<0 && ispushedFeatButton==false)
          {
               isjump=false;
                   switch(a)
     {
          case 1 : 
               spriteRen.sprite=CatJump[0];
               break;
          case 2:
               spriteRen.sprite=CatJump[1];
               break;
          case 3:
                spriteRen.sprite=CatJump[2];
                break;
          case 4:
                spriteRen.sprite=CatJump[3];
                break;
          case 5:
                spriteRen.sprite=CatJump[4];
                break;
          case 6:
                spriteRen.sprite=CatJump[5];
                break;
     }
          islevitation=true;
          }
       }
       else if(ispushedRunButton==false && isGround && isDIe==false)
       {
          jumptime=1;
        switch(a)
     {
          case 1 : 
               spriteRen.sprite=catidel[0];
               break;
          case 2:
               spriteRen.sprite=catidel[1];
               break;
          case 3:
                spriteRen.sprite=catidel[2];
                break;
          case 4:
                spriteRen.sprite=catidel[3];
                break;
          case 5:
                spriteRen.sprite=catidel[4];
                break;
          case 6:
                spriteRen.sprite=catidel[5];
                break;
     }
          islevitation=false;
       }
     
    }
IEnumerator featCat()
{
     yield return null;
}
    void FixedUpdate()
{
     if(isjump == false && islevitation== false && isDIe==false)
     {
          if(isGround)
          {
   transform.Rotate (0,0,Input.gyro.rotationRateUnbiased.z*12);
          }
     Vector3 tilt = Input.acceleration;
     rd.AddForce(tilt*5);
     
     }

  if(ispushedFeatButton)
  {
         
        CurrenTime+=Time.deltaTime;
   transform.Rotate(new Vector3(0,0,1)* -360 * Time.deltaTime);
     if(CurrenTime>4.3f && isDIe==false)
     {
          transform.rotation =Quaternion.Euler(0,0,0);
          CurrenTime=4;
          score.time+=10;
          ispushedFeatButton=false;
     }
  }
  
     if(isDIe)
     {
             switch(a)
     {
          case 1 : 
               spriteRen.sprite=CatDie[0];
               break;
          case 2:
               spriteRen.sprite=CatDie[1];
               break;
          case 3:
                spriteRen.sprite=CatDie[2];
                break;
          case 4:
                spriteRen.sprite=CatDie[3];
                break;
          case 5:
                spriteRen.sprite=CatDie[4];
                break;
          case 6:
                spriteRen.sprite=CatDie[5];
                break;
     }
             transform.rotation =Quaternion.Euler(0,0,0);
     }

    if(ispushedRunButton)
    {
     if(isGround && isDIe==false)
     {
          isjump=false;
           switch(a)
     {
          case 1 : 
               spriteRen.sprite=catidel[0];
               break;
          case 2:
               spriteRen.sprite=catidel[1];
               break;
          case 3:
                spriteRen.sprite=catidel[2];
                break;
          case 4:
                spriteRen.sprite=catidel[3];
                break;
          case 5:
                spriteRen.sprite=catidel[4];
                break;
          case 6:
                spriteRen.sprite=catidel[5];
                break;
     }
             transform.Rotate(new Vector3(0,0,1)*- 360 * Time.deltaTime);
     }
    }

}
private void OnCollisionEnter2D(Collision2D collision)
{

jumptime=1;
        if(ispushedFeatButton && collision.gameObject.CompareTag("Ground"))
     {
          isDIe=true;
                     switch(a)
     {
          case 1 : 
               spriteRen.sprite=CatDie[0];
               break;
          case 2:
               spriteRen.sprite=CatDie[1];
               break;
          case 3:
                spriteRen.sprite=CatDie[2];
                break;
          case 4:
                spriteRen.sprite=CatDie[3];
                break;
          case 5:
                spriteRen.sprite=CatDie[4];
                break;
          case 6:
                spriteRen.sprite=CatDie[5];
                break;
     }
     }

         
if(collision.gameObject.CompareTag("Ground"))
{
     isjump=false;
isGround=true;
}
else
{
     isGround=false;
}
}
private void OnCollisionExit2D(Collision2D collision)
{
      isGround=false;
}
private void OnCollisionStay2D(Collision2D collision)
{
  
    if(collision.gameObject.CompareTag("Ground"))
{
     Debug.Log("와우");
isGround=true;
}
}

public void JumpButton()
{
     if(isGround && isDIe == false)
     {
            nowtime=0;
          transform.Rotate(0,0,0);
          transform.rotation =Quaternion.Euler(0,0,0);
          isjump=true;
          rd.AddForce(Vector2.up* jumpPower , ForceMode2D.Impulse);
     }      
}
public void RunButtonDown()
{
ispushedRunButton = true;
}
public void RunButtonPUSH()
{
    
     if(islevitation && CurrenTime>3 && isDIe == false)
     {
          Debug.Log("와아");
      switch(a)
     {
          case 1 : 
               spriteRen.sprite=catidel[0];
               break;
          case 2:
               spriteRen.sprite=catidel[1];
               break;
          case 3:
                spriteRen.sprite=catidel[2];
                break;
          case 4:
                spriteRen.sprite=catidel[3];
                break;
          case 5:
                spriteRen.sprite=catidel[4];
                break;
          case 6:
                spriteRen.sprite=catidel[5];
                break;
     }
     ispushedFeatButton=true;
     }
}
public void RunButtonUp()
{
     ispushedRunButton = false;
}

}
