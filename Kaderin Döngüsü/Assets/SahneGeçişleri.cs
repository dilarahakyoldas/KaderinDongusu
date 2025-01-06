using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGeçişleri : MonoBehaviour
{
    public void SonrakiSahne()
    {
        int mevcutSahneIndex = SceneManager.GetActiveScene().buildIndex;
        int sonrakiSahneIndex = mevcutSahneIndex + 1;

        // Sonraki sahne var mı kontrolü (build settings'te tanımlı mı?)
        if (sonrakiSahneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(sonrakiSahneIndex);
        }
        else
        {
            Debug.LogWarning("Sonraki sahne bulunamadı!");
            // İsteğe bağlı olarak burada bir işlem yapabilirsiniz (örneğin, oyunun başına dönme).
            //SceneManager.LoadScene(0); // İlk sahneye dön
        }
    }

    public void OncekiSahne()
    {
        int mevcutSahneIndex = SceneManager.GetActiveScene().buildIndex;
        int oncekiSahneIndex = mevcutSahneIndex - 1;

        if (oncekiSahneIndex >= 0)
        {
            SceneManager.LoadScene(oncekiSahneIndex);
        }
        else
        {
            Debug.LogWarning("Önceki sahne bulunamadı!");
            // İsteğe bağlı olarak burada bir işlem yapabilirsiniz.
        }
    }

    public void SahneyeGit(int sahneIndex)
    {
        if (sahneIndex >= 0 && sahneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(sahneIndex);
        }
        else
        {
            Debug.LogWarning("Geçersiz sahne indeksi!");
        }
    }
}
