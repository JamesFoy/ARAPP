using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirutalButtonInteraction : MonoBehaviour, IVirtualButtonEventHandler
{
    GameObject vbObj;
    [SerializeField]
    GameObject videoPlayerPlane;

    // Start is called before the first frame update
    void Start()
    {
        vbObj = GameObject.Find("VirtualButton");
        vbObj.GetComponentInChildren<VirtualButtonBehaviour>().RegisterEventHandler(this);
        videoPlayerPlane.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        videoPlayerPlane.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {       
        throw new System.NotImplementedException();
    }
}
