using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVolume : MonoBehaviour
{
   private AudioSource m_Source;

    private void Start()
    {
        m_Source = GetComponent<AudioSource>();
    }
    private void Update()
    {
        m_Source.volume = UI.volLevel;
    }
}
