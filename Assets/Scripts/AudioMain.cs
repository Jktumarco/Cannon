using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMain : MonoBehaviour
{
    
    [SerializeField]
     public AudioSource audioSource;
    [SerializeField]
    public AudioSource audioStrike;
    public bool q = false;
    void Start()
    {
        
    }
    public void OffSound()
    {
        if (q == true) { 
            audioStrike.mute = false;
            audioSource.mute = false;
            q = false;
            return;
        }
        if (q == false)
        {
            audioStrike.mute = true;
            audioSource.mute = true;
            q = true;
        }
    }
   
}
