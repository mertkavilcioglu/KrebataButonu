using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;

    public AudioClip c1;
    public AudioClip p1;

    private void Start()
    {
        musicSource.clip = c1;
        musicSource.Play();
    }

    public void StartP1()
    {
        musicSource.Stop();
        musicSource.clip = p1;
        musicSource.Play();
    }
}
