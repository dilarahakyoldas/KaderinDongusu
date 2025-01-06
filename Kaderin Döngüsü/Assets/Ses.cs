using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ses : MonoBehaviour
{
        public void SesiCikar(Button buton)
        {
            AudioSource sesKaynagi = buton.GetComponent<AudioSource>();

            if (sesKaynagi != null)
            {
                sesKaynagi.Play(); // veya sesKaynagi.PlayOneShot();
            }
            else
            {
                Debug.LogError(buton.name + " butonunda Audio Source bileþeni yok!");
            }
        }
    }
