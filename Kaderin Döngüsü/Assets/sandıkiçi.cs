using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sandıkiçi : MonoBehaviour
{
    public string gidilecekSahneAdi = "sandık şifre"; // Geçilecek sahnenin adını buraya girin

    private void OnMouseDown()
    {
        Debug.Log("Nesneye tıklandı! " + gidilecekSahneAdi + " sahnesine geçiliyor.");
        SceneManager.LoadScene(gidilecekSahneAdi);
    }
}
