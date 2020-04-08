using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class GameManager : MonoBehaviour
{
    public enum RecentDetected { none, motherboard, harddrive, monitor, processor, powerbox, mouse };
    public RecentDetected recentDetected;

    public enum ModeType { image, ground };
    public ModeType currentMode;

    public GameObject ImageDetection;
    public GameObject GroundDetection;

    public TMPro.TMP_Text debugText;

    private static GameManager instance = null;

    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void ModeSwtich()
    {
        Debug.Log("Switch Mode");

        if (currentMode == ModeType.image)
        {
            currentMode = ModeType.ground;
        }
        else
        {
            currentMode = ModeType.image;
        }
    }

    private void Start()
    {
        currentMode = ModeType.image;
    }

    public void Update()
    {
        if (currentMode == ModeType.image)
        {
            ImageDetection.SetActive(true);
            GroundDetection.SetActive(false);
        }

        if (currentMode == ModeType.ground)
        {
            GroundDetection.SetActive(true);
            ImageDetection.SetActive(false);
        }       
    }
}
