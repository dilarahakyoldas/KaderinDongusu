using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class salon : MonoBehaviour
{
    public Button bedroomButton; // Yatak odas� butonu
    public string bedroomSceneName = "yatakodasi"; // Yatak odas� sahnesinin ad�

    private void Start()
    {
        bedroomButton.interactable = false; // Ba�lang��ta buton devre d���
    }

    private void Update()
    {
        if (anahtar.hasKey) // Anahtar al�nd�ysa
        {
            bedroomButton.interactable = true; // Butonu aktif et
        }
    }

    public void sagbutton() // Yatak odas�na ge�i� (kontroll�)
    {
        if (anahtar.hasKey)
        {
            SceneManager.LoadScene(bedroomSceneName);
        
        }
        else
        {
            Debug.Log("�nce anahtar� bulmal�s�n!");
        }
    }

    public void solbutton() // Banyoya ge�i� (kontrols�z)
    {
        SceneManager.LoadScene("banyo");
    }
}