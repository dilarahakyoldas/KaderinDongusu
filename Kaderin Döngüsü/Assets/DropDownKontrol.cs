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

    private string sifreGecildiKey = "SifreGecildi"; // PlayerPrefs i�in anahtar

    void Start()
    {
        // �ifre daha �nce ge�ildiyse bu sahneyi atla
        if (PlayerPrefs.GetInt(sifreGecildiKey, 0) == 1)
        {
            SceneManager.LoadScene("A��k Defter");
            return; // Fonksiyonun geri kalan�n� �al��t�rma
        }

        // Dropdown olaylar�n� ba�la
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
            Debug.Log("Do�ru cevaplar! Sahne ge�i�i yap�l�yor.");
            PlayerPrefs.SetInt(sifreGecildiKey, 1); // �ifre ge�ildi bilgisini kaydet
            PlayerPrefs.Save(); // De�i�iklikleri kaydet
            SceneManager.LoadScene("A��k Defter");
        }
        else
        {
            Debug.Log("Yanl�� cevaplar. Tekrar deneyin.");
        }
    }
}
