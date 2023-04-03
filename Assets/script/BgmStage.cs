using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmStage : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }

    void Update()
    {
        
    }
}