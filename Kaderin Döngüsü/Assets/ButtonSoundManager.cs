using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ButtonSoundManager : MonoBehaviour
{
    public List<Button> buttons; // Butonlar�n listesi (DO, MI, LA, RE, SOL, FA s�ras�yla)
    public AudioClip finalSound; // Do�ru s�ra tamamland���nda �al�nacak ses
    private int currentButtonIndex = 0; // Beklenen butonun indeksi
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        for (int i = 0; i < buttons.Count; i++)
        {
            int buttonIndex = i;
            buttons[i].onClick.AddListener(() => OnButtonClick(buttonIndex));
        }
    }

    void OnButtonClick(int buttonIndex)
    {
        if (buttonIndex == currentButtonIndex)
        {
            // Do�ru butona bas�ld�
            Debug.Log("Do�ru butona bas�ld�: " + buttons[buttonIndex].name); // Hangi butona bas�ld���n� g�sterir
            currentButtonIndex++;

            if (currentButtonIndex >= buttons.Count)
            {
                // T�m butonlara do�ru s�rada bas�ld�
                if (finalSound != null)
                {
                    audioSource.PlayOneShot(finalSound);
                    Debug.Log("T�m butonlara do�ru s�rada bas�ld�! Ses �al�n�yor.");
                }
                else
                {
                    Debug.LogError("Final ses kayd� atanmam��!");
                }
                Reset(); // Tekrar ba�lamak i�in reset fonksiyonunu �a��r
            }
        }
        else
        {
            // Yanl�� butona bas�ld�
            Debug.Log("Yanl�� butona bas�ld�! Beklenen buton: " + buttons[currentButtonIndex].name);
            Reset(); // S�f�rla
        }
    }

    private void Reset()
    {
        currentButtonIndex = 0;
        Debug.Log("Sistem resetlendi. DO butonuna basman�z bekleniyor.");
    }
}
