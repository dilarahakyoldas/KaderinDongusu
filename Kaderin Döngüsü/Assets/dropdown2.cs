using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dropdown2 : MonoBehaviour
{
    public TMP_Dropdown dropdown1;
    public TMP_Dropdown dropdown3;
    public TMP_Dropdown dropdown4;
    public TMP_Dropdown dropdown5;


    public int dogruCevap1 = 1; // �rnek do�ru cevaplar
    public int dogruCevap2 = 3;
    public int dogruCevap3 = 2;
    public int dogruCevap4 = 0;

    private int secilen1;
    private int secilen2;
    private int secilen3;
    private int secilen4;

    void Start()
    {
        // Dropdown olaylar�n� ba�la (TMP_Dropdown i�in farkl� bir olay var)
        dropdown1.onValueChanged.AddListener(delegate {
            secilen1 = dropdown1.value;
            KontrolEt();
        });
        dropdown3.onValueChanged.AddListener(delegate {
            secilen2 = dropdown3.value;
            KontrolEt();
        });
        dropdown4.onValueChanged.AddListener(delegate {
            secilen3 = dropdown4.value;
            KontrolEt();
        });
        dropdown5.onValueChanged.AddListener(delegate {
            secilen4 = dropdown5.value;
            KontrolEt();
        });
    }

    void KontrolEt()
    {
        if (secilen1 == dogruCevap1 && secilen2 == dogruCevap2 && secilen3 == dogruCevap3 && secilen4 == dogruCevap4)
        {
            Debug.Log("Do�ru cevaplar! Sahne ge�i�i yap�l�yor.");
            SceneManager.LoadScene("Dolap ��i");
        }
        else
        {
            Debug.Log("Yanl�� cevaplar. Tekrar deneyin.");
        }
    }
}
