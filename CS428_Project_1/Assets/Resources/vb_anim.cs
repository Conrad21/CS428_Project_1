//Code provided by https://www.youtube.com/watch?v=ElmzIq6stNI

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject Stanley;
    public GameObject button;
  

    void Start()
    {
        button = GameObject.Find("VirtualButton");
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Stanley = GameObject.Find("Stanley");
        Stanley.SetActive(false);
    }


    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Stanley.SetActive(false);
        Debug.Log("OFF");
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Stanley.SetActive(true);
        Debug.Log("NO");
    }

}