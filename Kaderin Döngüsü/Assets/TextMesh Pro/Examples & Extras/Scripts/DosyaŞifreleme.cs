using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class DosyaŞifreleme : MonoBehaviour
{
    public TMP_InputField inputField;
    public Button sagButon;
    public int correctValue = 73;
    public string sceneToLoad = "d2";

    void Start()
    {
        if (inputField != null && sagButon != null)
        {
            sagButon.interactable = false;
            inputField.onValueChanged.AddListener(CheckInputValue);
            // Butona tıklama olayını da burada ekleyelim
            sagButon.onClick.AddListener(LoadScene);
        }
        else
        {
            if (inputField == null) Debug.LogError("TMP_InputField atanmadı! Inspector'da kontrol et.");
            if (sagButon == null) Debug.LogError("Sağ Buton atanmadı! Inspector'da kontrol et.");
        }
    }

    void CheckInputValue(string value)
    {
        if (int.TryParse(value, out int enteredValue))
        {
            sagButon.interactable = enteredValue == correctValue;
        }
        else
        {
            sagButon.interactable = false;
        }
    }

    // Sahne yükleme fonksiyonunu ayrı bir fonksiyon haline getirelim
    public void LoadScene()
    {
        if (sagButon.interactable)
        {
            SceneManager.LoadScene(sceneToLoad); // sceneToLoad değişkenini kullan
        }
        else
        {
            Debug.LogWarning("Lütfen doğru değeri girin.");
        }
    }
}