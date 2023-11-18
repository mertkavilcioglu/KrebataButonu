using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAudio : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    public AudioClip menuMusic;

    private void Start()
    {
        musicSource.clip = menuMusic;
        musicSource.Play();
    }
}
