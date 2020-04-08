using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateObjects : MonoBehaviour
{
    public GameObject motherBoard, hardDrive, monitor, processor, powerBox, mouse;

    private void OnDisable()
    {
        motherBoard.SetActive(false);
        hardDrive.SetActive(false);
        monitor.SetActive(false);
        processor.SetActive(false);
        powerBox.SetActive(false);
        mouse.SetActive(false);
    }
}
