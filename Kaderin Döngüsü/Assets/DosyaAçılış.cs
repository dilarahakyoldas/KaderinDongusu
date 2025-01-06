using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DosyaAçılış : MonoBehaviour
{
    public TMP_InputField inputAlan1;
    public string dogruDeger1 = "yasin bulut";
    public string sonrakisahne = "d1"; // Açılacak sahnenin adı
    public TMP_Text geriBildirimMesaji; // TextMeshPro bileşeni için

    public void KontrolEtVeSahneGec()
    {
        if (inputAlan1.text == dogruDeger1)
        {
            SceneManager.LoadScene(sonrakisahne);
        }
        else
        {
            Debug.Log("Yanlış giriş kontrolü çalıştı."); // Debug mesajı
            geriBildirimMesaji.text = "Yanlış giriş!"; // Mesaj güncelleniyor
            geriBildirimMesaji.color = Color.red; // Renk ayarlanıyor
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) // Enter tuşuna basıldığında
        {
            KontrolEtVeSahneGec();
        }
    }

}
