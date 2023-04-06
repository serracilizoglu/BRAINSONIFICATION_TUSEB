using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSound : MonoBehaviour
{

    public AudioSource thesound;
    public bool SoundOn = true;

    public void toggle()
    {
        if (thesound != null)
        {
            if (SoundOn)
            {
                thesound.Stop();
                SoundOn = false;
            }
            else
            {
                thesound.Play();
                SoundOn = true;
            }
        }
    }
}
