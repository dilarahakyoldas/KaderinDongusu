using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kırıkparke : MonoBehaviour
{
    public string gidilecekSahneAdi = "Defter"; // Geçilecek sahnenin adını buraya girin

    private void OnMouseDown()
    {
        Debug.Log("Nesneye tıklandı! " + gidilecekSahneAdi + " sahnesine geçiliyor.");
        SceneManager.LoadScene(gidilecekSahneAdi);
    }
}
