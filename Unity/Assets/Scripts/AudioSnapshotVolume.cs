using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class SnapshotConfig
{
    public AudioMixerSnapshot[] Snapshots;
    public float[] Weights;
    public float TransitionTime;
}

public class AudioSnapshotVolume : MonoBehaviour
{
    [SerializeField] AudioMixer LinkedMixer;
    //[SerializeField] SnapshotConfig OnEntry;
    [SerializeField] SnapshotConfig OnStay;
    //[SerializeField] SnapshotConfig OnExit;
    [SerializeField] List<string> Tags;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (Tags.Contains(other.tag))
            TransitionTo(OnStay);
    }


    /*   void OnTriggerEnter(Collider other)
    {
        if (Tags.Contains(other.tag) && OnEntry != null)
            TransitionTo(OnEntry);
    }

    void OnTriggerExit(Collider other)
    {
        if (Tags.Contains(other.tag) && OnEntry != null)
            TransitionTo(OnExit);
    }
    */

    void TransitionTo(SnapshotConfig config)
    {
        LinkedMixer.TransitionToSnapshots(config.Snapshots, config.Weights, config.TransitionTime);
    }

}
