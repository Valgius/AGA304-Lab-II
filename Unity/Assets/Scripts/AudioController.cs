using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioMixerGroup audioMixerGroup;


    private void Start()
    {
        audioSource.outputAudioMixerGroup = audioMixerGroup;
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            audioSource.Play();
            print("Trigger");
        }
    }
}
