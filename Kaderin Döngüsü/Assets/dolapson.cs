using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dolapson : MonoBehaviour
{
    public string gidilecekSahneAdi = "Dolap son sahne"; // Ge�ilecek sahnenin ad�n� buraya girin

    private void OnMouseDown()
    {
        Debug.Log("Nesneye t�kland�! " + gidilecekSahneAdi + " sahnesine ge�iliyor.");
        SceneManager.LoadScene(gidilecekSahneAdi);
    }
}