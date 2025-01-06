using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class komodin : MonoBehaviour
{
    public string gidilecekSahneAdi = "kapalý çekmece kilitli"; // Geçilecek sahnenin adýný buraya girin

    private void OnMouseDown()
    {
        Debug.Log("Nesneye týklandý! " + gidilecekSahneAdi + " sahnesine geçiliyor.");
        SceneManager.LoadScene(gidilecekSahneAdi);
    }
}
