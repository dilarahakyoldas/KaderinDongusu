using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buton : MonoBehaviour
{
    public void Ileri()
    {
        SceneManager.LoadScene("dosya 1. sayfa");
    }
    public void Geri()
    {
        SceneManager.LoadScene("DOSYA 4. SAYFA");
    }
}
   
