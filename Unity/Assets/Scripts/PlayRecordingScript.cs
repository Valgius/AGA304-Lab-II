using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRecordingScript : MonoBehaviour
{
    public AudioSource recording;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            recording.Play();
            print("Trigger");
        }
    }
}
