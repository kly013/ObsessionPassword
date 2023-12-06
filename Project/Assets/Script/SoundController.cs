using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundController : MonoBehaviour
{
    private AudioSource audiosource;
    
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        
    }

    public void VolumeChanged(float newVolume)
    {
        audiosource.volume = newVolume;
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
