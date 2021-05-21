using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundSystem : MonoBehaviour
{
    public AudioSource pickup;
    public AudioSource music;

    public void PlayPickup()
    {
        pickup.volume = 0.5f;
        pickup.Play();
    }

    public void PlayMusic()
    {
        music.volume = 0.35f;
        music.Play();
    }

}
