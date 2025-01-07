using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phone : MonoBehaviour
{
    private AudioSource sesKaynagi;

    void Start()
    {
        // Audio Source bileþenini al
        sesKaynagi = GetComponent<AudioSource>();

        // Eðer Audio Source yoksa hata mesajý ver
        if (sesKaynagi == null)
        {
            Debug.LogError("Bu nesnede Audio Source bileþeni yok!");
        }
    }

    private void OnMouseDown()
    {
        // Eðer Audio Source varsa ve ses çalmýyorsa sesi çal
        if (sesKaynagi != null && !sesKaynagi.isPlaying)
        {
            sesKaynagi.Play();
        }
    }
}
