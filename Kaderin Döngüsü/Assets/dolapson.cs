using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dolapson : MonoBehaviour
{
    public string gidilecekSahneAdi = "Dolap son sahne"; // Geçilecek sahnenin adýný buraya girin

    private void OnMouseDown()
    {
        Debug.Log("Nesneye týklandý! " + gidilecekSahneAdi + " sahnesine geçiliyor.");
        SceneManager.LoadScene(gidilecekSahneAdi);
    }
}