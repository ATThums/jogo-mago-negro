using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AudioMute()
    {
        GetComponent<AudioSource>().Pause();
    }

    public void AudioPlay()
    {
        GetComponent<AudioSource>().Play();

    }
}
