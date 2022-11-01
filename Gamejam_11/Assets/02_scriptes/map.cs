using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class map : MonoBehaviour
{
    [SerializeField]GameObject cloud;
    int randommap;
    public static float Xpos=1374.3f;
    [SerializeField]GameObject a;
     [SerializeField]GameObject b;
     [SerializeField]GameObject c;
    [SerializeField]GameObject d;
      [SerializeField]GameObject e;
       [SerializeField]GameObject f;
      [SerializeField]GameObject g;
      [SerializeField]GameObject h;
      [SerializeField]GameObject i;
       [SerializeField]GameObject j;

       Transform parents; 
  [SerializeField]GameObject mapImageA;
 [SerializeField]GameObject mapImageB;
  [SerializeField]GameObject mapImageC;
   [SerializeField]GameObject mapImageD;
  int randmomImage;
  private   float MAPXpos=1429.9f;
  public static float limitMinMapPos=1370;

    void Start()
    {
      randmomImage=Random.Range(0,4);
       // parents= GameObject.Find("mapCONTROL").transform;
        randommap=Random.Range(0,10);
        for(int i=0; i<6; i++)
        {
  BackGroundSpawn();
        }
    for(int i=0; i<3; i++)
        {
  MapSpawn();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void BackGroundSpawn()
    {
          
              Vector3 vec1 = new Vector3(Xpos,-129.1f,0);
        switch(randmomImage)
        {
            case 0 :
           gameObject.transform.position=new Vector3(Xpos-21.536f,-134.5f,0);
               GameObject clonA= Instantiate(mapImageA,vec1,Quaternion.identity);
                Xpos+=21.536f;
               // clonA.transform.parent= parents;
                limitMinMapPos+=21.536f;
                break;
           case 1 : 
                 gameObject.transform.position=new Vector3(Xpos-23.5f,-134.5f,0);
                GameObject clonC= Instantiate(mapImageC,vec1,Quaternion.identity);
                Xpos+=23.5f;
                //clonC.transform.parent= parents;
                limitMinMapPos+=23.5f;
                break;
            case 2 :
             gameObject.transform.position=new Vector3(Xpos-23.6f,-134.5f,0);
               GameObject clonB =  Instantiate(mapImageB,vec1,Quaternion.identity);
                Xpos+=23.6f;
                limitMinMapPos+=23.6f;
                   //       clonB.transform.parent= parents;
                break;
                case 3 :
                gameObject.transform.position=new Vector3(Xpos-22.4f,-134.5f,0);
                 GameObject clonD = Instantiate(mapImageD,vec1,Quaternion.identity);
                Xpos+=22.4f;
                limitMinMapPos+=22.4f;
                     //     clonD.transform.parent= parents;
                break;
        }
    
    }
    public void MapSpawn()
    {
      
        Vector3 vec= new Vector3(MAPXpos,-134.6f,0);
    switch(randommap)
    {
        case 0 : 
            GameObject aClone=Instantiate(a,vec,Quaternion.identity) ;
           // aClone.transform.parent= parents;
            //aClone.transform.position=vec;
            MAPXpos+=117;
            break;
        case 1 :
           GameObject bClone=Instantiate(b,new Vector3(vec.x,vec.y,0),Quaternion.identity) ;
           // bClone.transform.parent= parents;
            //bClone.transform.position=vec;
            MAPXpos+=117;
            break;
        case 2 :
           GameObject cClone=Instantiate(c,vec,Quaternion.identity) ;
           // cClone.transform.parent= parents;
          //  cClone.transform.position=vec;
              MAPXpos+=117;
            break;
        case 3 :
         GameObject dClone=Instantiate(d,new Vector3(vec.x-39,vec.y+1.6f,0),Quaternion.identity) ;
          MAPXpos+=117;
         break;
         case 4 :
         GameObject eClone=Instantiate(e,new Vector3(vec.x,vec.y-4,0),Quaternion.identity) ;
        MAPXpos+=117;
         break;
         case 5 :
         GameObject fClone=Instantiate(f,new Vector3(vec.x,vec.y+21.5f,0),Quaternion.identity) ;
        MAPXpos+=117;
         break;
         case 6 :
         GameObject gClone=Instantiate(g,new Vector3(vec.x,vec.y+3,0),Quaternion.identity) ;
        MAPXpos+=117;
         break;
              case 7 :
         GameObject hClone=Instantiate(h,new Vector3(vec.x,vec.y,0),Quaternion.identity) ;
        MAPXpos+=117;
         break;
                 case 8 :
         GameObject iClone=Instantiate(i,new Vector3(vec.x,vec.y+7.2f,0),Quaternion.identity) ;
        MAPXpos+=117;
         break;
             case 9 :
         GameObject jClone=Instantiate(j,new Vector3(vec.x,vec.y,0),Quaternion.identity) ;
        MAPXpos+=117;
         break;
         
    }
      
      randommap=Random.Range(0,10);
    }
          private void OnTriggerEnter2D(Collider2D other) 
     {  
  
         if(other.CompareTag("Player"))
         {
            cloud.transform.position=new Vector3(Xpos-54,-135.03f,0);
            BackGroundSpawn();
            MapSpawn();
            BackGroundSpawn();
            MapSpawn();
        }
     }   
}
