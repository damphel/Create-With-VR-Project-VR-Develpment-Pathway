using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAudioPlayer : MonoBehaviour
{
    [SerializeField] float playCooldown = 10f;
    [SerializeField] AudioSource[] audioSources;

    float nextSoundPlayTime = 2f;

    private void Update()
    {
        if (Time.time > nextSoundPlayTime)
        {
            audioSources[Random.Range(0, audioSources.Length - 1)].Play();

            nextSoundPlayTime = Time.time + playCooldown;
        }
    }

}
