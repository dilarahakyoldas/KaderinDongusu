using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DropDownKontrol : MonoBehaviour
{
    public TMP_Dropdown dropdown1;
    public TMP_Dropdown dropdown2;
    public TMP_Dropdown dropdown3;

    public int dogruCevap1 = 1;
    public int dogruCevap2 = 1;
    public int dogruCevap3 = 1;

    private int secilen1;
    private int secilen2;
    private int secilen3;

    private string sifreGecildiKey = "SifreGecildi"; // PlayerPrefs için anahtar

    void Start()
    {
        // Þifre daha önce geçildiyse bu sahneyi atla
        if (PlayerPrefs.GetInt(sifreGecildiKey, 0) == 1)
        {
            SceneManager.LoadScene("Açýk Defter");
            return; // Fonksiyonun geri kalanýný çalýþtýrma
        }

        // Dropdown olaylarýný baðla
        dropdown1.onValueChanged.AddListener(delegate {
            secilen1 = dropdown1.value;
            KontrolEt();
        });
        dropdown2.onValueChanged.AddListener(delegate {
            secilen2 = dropdown2.value;
            KontrolEt();
        });
        dropdown3.onValueChanged.AddListener(delegate {
            secilen3 = dropdown3.value;
            KontrolEt();
        });
    }

    void KontrolEt()
    {
        if (secilen1 == dogruCevap1 && secilen2 == dogruCevap2 && secilen3 == dogruCevap3)
        {
            Debug.Log("Doðru cevaplar! Sahne geçiþi yapýlýyor.");
            PlayerPrefs.SetInt(sifreGecildiKey, 1); // Þifre geçildi bilgisini kaydet
            PlayerPrefs.Save(); // Deðiþiklikleri kaydet
            SceneManager.LoadScene("Açýk Defter");
        }
        else
        {
            Debug.Log("Yanlýþ cevaplar. Tekrar deneyin.");
        }
    }
}
