using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phone : MonoBehaviour
{
    private AudioSource sesKaynagi;

    void Start()
    {
        // Audio Source bile�enini al
        sesKaynagi = GetComponent<AudioSource>();

        // E�er Audio Source yoksa hata mesaj� ver
        if (sesKaynagi == null)
        {
            Debug.LogError("Bu nesnede Audio Source bile�eni yok!");
        }
    }

    private void OnMouseDown()
    {
        // E�er Audio Source varsa ve ses �alm�yorsa sesi �al
        if (sesKaynagi != null && !sesKaynagi.isPlaying)
        {
            sesKaynagi.Play();
        }
    }
}
