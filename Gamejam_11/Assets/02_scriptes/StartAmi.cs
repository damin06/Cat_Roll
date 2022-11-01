using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartAmi : MonoBehaviour
{
    public bool AmiStart;
    public GameObject Title;
    public GameObject CatBackground;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (AmiStart == true)
        {
            Vector3 velo = Vector3.zero;

            Vector3 target = new Vector3(550, 3000, 0);
            Title.transform.position = Vector3.SmoothDamp(Title.transform.position, target, ref velo, 0.09f);

            Vector3 targett = new Vector3(550, -1100, 0);
            CatBackground.transform.position = Vector3.SmoothDamp(CatBackground.transform.position, targett, ref velo, 0.05f);

        }
    }

    public void realStart()
    {
        Invoke("realrealStart", 0.5f);
    }

    public void realrealStart()
    {
        SceneManager.LoadScene("test");
    }
}
