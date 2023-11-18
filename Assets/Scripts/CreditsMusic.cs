using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsMusic : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    public AudioClip creditsMusic;

    private void Start()
    {
        musicSource.clip = creditsMusic;
        musicSource.Play();
    }
}
