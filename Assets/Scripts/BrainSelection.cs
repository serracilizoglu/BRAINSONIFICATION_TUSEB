using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BrainSelection : MonoBehaviour
{

    public AudioSource thesound;

    public virtual void ChannelSelection()
    {


    
        thesound.Stop();
    } 
    // Update is called once per frame
    void Update()
    {
        
    }
}
