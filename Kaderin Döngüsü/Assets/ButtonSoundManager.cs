using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ButtonSoundManager : MonoBehaviour
{
    public List<Button> buttons; // Butonlarýn listesi (DO, MI, LA, RE, SOL, FA sýrasýyla)
    public AudioClip finalSound; // Doðru sýra tamamlandýðýnda çalýnacak ses
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
            // Doðru butona basýldý
            Debug.Log("Doðru butona basýldý: " + buttons[buttonIndex].name); // Hangi butona basýldýðýný gösterir
            currentButtonIndex++;

            if (currentButtonIndex >= buttons.Count)
            {
                // Tüm butonlara doðru sýrada basýldý
                if (finalSound != null)
                {
                    audioSource.PlayOneShot(finalSound);
                    Debug.Log("Tüm butonlara doðru sýrada basýldý! Ses çalýnýyor.");
                }
                else
                {
                    Debug.LogError("Final ses kaydý atanmamýþ!");
                }
                Reset(); // Tekrar baþlamak için reset fonksiyonunu çaðýr
            }
        }
        else
        {
            // Yanlýþ butona basýldý
            Debug.Log("Yanlýþ butona basýldý! Beklenen buton: " + buttons[currentButtonIndex].name);
            Reset(); // Sýfýrla
        }
    }

    private void Reset()
    {
        currentButtonIndex = 0;
        Debug.Log("Sistem resetlendi. DO butonuna basmanýz bekleniyor.");
    }
}
