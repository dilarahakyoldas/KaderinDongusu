using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ördek : MonoBehaviour
{
    private AudioSource sesKaynagi;

    void Start()
    {
        // Audio Source bileşenini al
        sesKaynagi = GetComponent<AudioSource>();

        // Eğer Audio Source yoksa hata mesajı ver
        if (sesKaynagi == null)
        {
            Debug.LogError("Bu nesnede Audio Source bileşeni yok!");
        }
    }

    private void OnMouseDown()
    {
        // Eğer Audio Source varsa ve ses çalmıyorsa sesi çal
        if (sesKaynagi != null && !sesKaynagi.isPlaying)
        {
            sesKaynagi.Play();
        }
    }
}

