using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tablo : MonoBehaviour
{
    public string gidilecekSahneAdi = "tablo"; // Ge�ilecek sahnenin ad�n� buraya girin

    private void OnMouseDown()
    {
        Debug.Log("Nesneye t�kland�! " + gidilecekSahneAdi + " sahnesine ge�iliyor.");
        SceneManager.LoadScene(gidilecekSahneAdi);
    }
}
