using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class yatakodasi : MonoBehaviour
{
    public void sagbutton()
    {
        SceneManager.LoadScene("Salon");
    }
    public void solbutton()
    {
        SceneManager.LoadScene("Banyo");
    }

    public string SahneAdi = "Kapalý dolap"; // Yeni sahne adý
    private void OnMouseDown()
        {
            // Dolaba týklanýnca yeni sahneye geçiþ
            SceneManager.LoadScene(SahneAdi);
        }
    
}
