using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class çekmeceson : MonoBehaviour
{
    public string gidilecekSahneAdi = "Çekmece son sahne"; // Geçilecek sahnenin adını buraya girin

    private void OnMouseDown()
    {
        Debug.Log("Nesneye tıklandı! " + gidilecekSahneAdi + " sahnesine geçiliyor.");
        SceneManager.LoadScene(gidilecekSahneAdi);
    }
}
