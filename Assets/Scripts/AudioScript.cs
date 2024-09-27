using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource IntroAudio;
    public AudioSource BackgroundGhostNormalAudio;
    public float IntroAudioDuration = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        IntroAudio.Play();
        Invoke("SwitchAudio", IntroAudioDuration);
        
    }

    // Update is called once per frame
    void SwitchAudio()
    {
        IntroAudio.Stop();
        BackgroundGhostNormalAudio.Play();
    }
}
