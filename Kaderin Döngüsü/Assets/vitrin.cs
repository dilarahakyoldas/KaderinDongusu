using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vitrin : MonoBehaviour
{
    public string gidilecekSahneAdi = "kapalývitrin"; // Geçilecek sahnenin adýný buraya girin

    private void OnMouseDown()
    {
        Debug.Log("Nesneye týklandý! " + gidilecekSahneAdi + " sahnesine geçiliyor.");
        SceneManager.LoadScene(gidilecekSahneAdi);
    }
}

