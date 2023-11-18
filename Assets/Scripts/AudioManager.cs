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
        musicSource.volume = 0.02f; //0.1 yap
        musicSource.clip = p1;
        musicSource.Play();
    }

    public void StartC2()
    {
        musicSource.Stop();
        musicSource.volume = 0.07f;
        musicSource.clip = c2;
        musicSource.Play();
    }

    public void StartP2()
    {
        musicSource.Stop();
        musicSource.volume = 0.02f; //0.1 yap
        musicSource.clip = p2;
        musicSource.Play();
    }

    public void StartC3()
    {
        musicSource.Stop();
        musicSource.volume = 0.07f;
        musicSource.clip = c3;
        musicSource.Play();
    }
}
