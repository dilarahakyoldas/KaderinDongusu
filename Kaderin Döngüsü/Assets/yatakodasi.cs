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

    public string SahneAdi = "Kapal� dolap"; // Yeni sahne ad�
    private void OnMouseDown()
        {
            // Dolaba t�klan�nca yeni sahneye ge�i�
            SceneManager.LoadScene(SahneAdi);
        }
    
}
