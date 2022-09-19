using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCrackers : MonoBehaviour
{
    public ParticleSystem[] endCrackers = new ParticleSystem[5];

    public void Diwali()
    {
        for(int i=0; i < endCrackers.Length; i++)
        {
            endCrackers[i].Play();
        }
    }
}
