using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;

    public AudioClip c1;
    public AudioClip p1;
    public AudioClip c2;
    public AudioClip p2;
    public AudioClip c3;

    private void Start()
    {
        musicSource.clip = c1;
        musicSource.Play();
    }

    public void StartP1()
    {
        musicSource.Stop();
        musicSource.volume = 0.1f; 
        musicSource.clip = p1;
        musicSource.Play();
    }

    public void StartC2()
    {
        musicSource.Stop();
        musicSource.volume = 0.7f;
        musicSource.clip = c2;
        musicSource.Play();
    }

    public void StartP2()
    {
        musicSource.Stop();
        musicSource.volume = 0.1f;
        musicSource.clip = p2;
        musicSource.Play();
    }

    public void StartC3()
    {
        musicSource.Stop();
        musicSource.volume = 0.7f;
        musicSource.clip = c3;
        musicSource.Play();
    }
}
