using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource audio;
    private void Update()
    {
        audio.volume = PlayerPrefs.GetFloat("volume");
    }
}
