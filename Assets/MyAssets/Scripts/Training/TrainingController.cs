using OVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TrainingController : MonoBehaviour
{
    [SerializeField] VRHINTAudioManager audioManager;
    [SerializeField] AudioClip clip;
    [SerializeField] AudioClip distClip;

    private int rounds = 20;

    // Start is called before the first frame update
    void Start()
    {
        audioManager.OnPlayingDone = OnPlayingDone;
        audioManager.SetTargetAudio(clip);
        audioManager.SetDistractorAudio(distClip, true);
        audioManager.StartPlaying();



    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnPlayingDone()
    {
        if (rounds > 0)
        {
            ++rounds;
            audioManager.StartPlaying();
        }
    }
}
