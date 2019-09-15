//Code provided by https://www.youtube.com/watch?v=ElmzIq6stNI

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject button;
    public GameObject Stanley;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("VirtualButton");
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Stanley = GameObject.Find("Stanley");
        Stanley.GetComponent<GameObject>();
        Stanley.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Stanley.SetActive(true);
        Debug.Log("NO");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Stanley.SetActive(false);
        Debug.Log("OFF");
    }


}