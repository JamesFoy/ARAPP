using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class DescriptionEnable : MonoBehaviour
{
    public GameObject descriptionTxt;

    // Start is called before the first frame update
    void Start()
    {
        descriptionTxt.SetActive(false);
    }

    public void OnButtonPress()
    {
        if (descriptionTxt.activeInHierarchy)
        {
            descriptionTxt.SetActive(false);
        }
        else
        {
            descriptionTxt.SetActive(true);
        }
    }
}
