//Code provided by https://www.youtube.com/watch?v=ElmzIq6stNI

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim1 : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject Stanley;
    public GameObject Reviews;
    public GameObject bookInfo;
    public GameObject VideoRewiew;
    public GameObject button;
    public int counter = 1; 

    void Start()
    {
        
        button = GameObject.Find("VirtualButton1");
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
         Stanley = GameObject.Find("Cube22");
         Stanley.SetActive(false);

        Reviews = GameObject.Find("Reviews");
        Reviews.SetActive(false);

        bookInfo = GameObject.Find("bookInfo");
        bookInfo.SetActive(false);

        VideoRewiew = GameObject.Find("VideoRewiew");
        VideoRewiew.SetActive(false);
    }


    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {   
       // if(counter == 1)
       // {
       //     counter = 2;
       //     Debug.Log("Counter = 2");
       // }

       //else if (counter == 2)
       // {
       //     counter = 1;
       //     Debug.Log("Counter = 1");
       // }

       Stanley.SetActive(false);
        //Debug.Log("OFF");
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (counter == 1)
        {
            counter = 2;
            VideoRewiew.SetActive(false);
            bookInfo.SetActive(true);
            Reviews.SetActive(false);
            Debug.Log("Counter = 2");
        }

        else if (counter == 2)
        {
            counter = 3;
            VideoRewiew.SetActive(false);
            bookInfo.SetActive(false);
            Reviews.SetActive(true);
            Debug.Log("Counter = 3");
        }
        else if (counter == 3)
        {
            counter = 1;
            VideoRewiew.SetActive(true);
            bookInfo.SetActive(false);
            Reviews.SetActive(false);
            Debug.Log("Counter = 1");
        }



        //   Stanley.SetActive(true);
        //   Debug.Log("OFF");
    }

}