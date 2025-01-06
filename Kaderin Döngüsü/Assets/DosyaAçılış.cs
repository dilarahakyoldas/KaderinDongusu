using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DosyaAçılış : MonoBehaviour
{
    public TMP_InputField inputAlan1;
    public string dogruDeger1 = "yasin";
    public string sonrakisahne = "d1"; // Açılacak sahnenin adı

    public void KontrolEtVeSahneGec()
    { 
        if (inputAlan1.text == dogruDeger1)
        {
            SceneManager.LoadScene(sonrakisahne);
        }
        else
        {
            // İsteğe bağlı: Yanlış giriş durumunda kullanıcıya geri bildirim verin
            Debug.Log("Yanlış giriş!");
        }
    }
}
