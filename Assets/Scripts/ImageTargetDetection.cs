using Vuforia;
using UnityEngine;

public class ImageTargetDetection : MonoBehaviour, ITrackableEventHandler
{
    public enum ThisHardware { motherboard, harddrive, monitor, processor, powerbox, mouse };
    public ThisHardware thisHardware;

    public GameObject motherBoard, hardDrive, monitor, processor, powerBox, mouse;

    public TMPro.TMP_Text debugText;

    private TrackableBehaviour mTrackableBehaviour;

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            debugText.text = "Detected Object" + thisHardware;

            if (thisHardware == ThisHardware.motherboard)
            {
                motherBoard.SetActive(true);
                hardDrive.SetActive(false);
                monitor.SetActive(false);
                processor.SetActive(false);
                powerBox.SetActive(false);
                mouse.SetActive(false);
            }
            else if (thisHardware == ThisHardware.harddrive)
            {
                motherBoard.SetActive(false);
                hardDrive.SetActive(true);
                monitor.SetActive(false);
                processor.SetActive(false);
                powerBox.SetActive(false);
                mouse.SetActive(false);
            }
            else if (thisHardware == ThisHardware.monitor)
            {
                motherBoard.SetActive(false);
                hardDrive.SetActive(false);
                monitor.SetActive(true);
                processor.SetActive(false);
                powerBox.SetActive(false);
                mouse.SetActive(false);
            }
            else if (thisHardware == ThisHardware.processor)
            {
                motherBoard.SetActive(false);
                hardDrive.SetActive(false);
                monitor.SetActive(false);
                processor.SetActive(true);
                powerBox.SetActive(false);
                mouse.SetActive(false);
            }
            else if (thisHardware == ThisHardware.powerbox)
            {
                motherBoard.SetActive(false);
                hardDrive.SetActive(false);
                monitor.SetActive(false);
                processor.SetActive(false);
                powerBox.SetActive(true);
                mouse.SetActive(false);
            }
            else if (thisHardware == ThisHardware.mouse)
            {
                motherBoard.SetActive(false);
                hardDrive.SetActive(false);
                monitor.SetActive(false);
                processor.SetActive(false);
                powerBox.SetActive(false);
                mouse.SetActive(true);
            }
        }
        else
        {
            debugText.text = "Lost Detected Object";
        }
    }
}
