using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class salon : MonoBehaviour
{
    public Button bedroomButton; // Yatak odasý butonu
    public string bedroomSceneName = "yatakodasi"; // Yatak odasý sahnesinin adý

    private void Start()
    {
        bedroomButton.interactable = false; // Baþlangýçta buton devre dýþý
    }

    private void Update()
    {
        if (anahtar.hasKey) // Anahtar alýndýysa
        {
            bedroomButton.interactable = true; // Butonu aktif et
        }
    }

    public void sagbutton() // Yatak odasýna geçiþ (kontrollü)
    {
        if (anahtar.hasKey)
        {
            SceneManager.LoadScene(bedroomSceneName);
        
        }
        else
        {
            Debug.Log("Önce anahtarý bulmalýsýn!");
        }
    }

    public void solbutton() // Banyoya geçiþ (kontrolsüz)
    {
        SceneManager.LoadScene("banyo");
    }
}