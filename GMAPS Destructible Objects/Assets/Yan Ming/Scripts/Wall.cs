using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClipDrop;
    private bool hasPlayed = false;

    private void OnCollisionEnter(Collision collision)
    {
        // If wall pieces collides with ground and the audio is not playing, get and play the audio, and set hasPlayed to true to indicate the audio was played
        if (collision.gameObject.CompareTag("Ground") && !hasPlayed)
        {
            audioSource.clip = audioClipDrop;
            audioSource.Play();
            hasPlayed = true;
        }
        // Or else, indicate the audio was not played
        else
        {
            hasPlayed = false;
        }
    }

    private void AdjustSound()
    {
        // Adjust sound properties, set sound at full volume
        audioSource.volume = 1.0f;
    }
}
