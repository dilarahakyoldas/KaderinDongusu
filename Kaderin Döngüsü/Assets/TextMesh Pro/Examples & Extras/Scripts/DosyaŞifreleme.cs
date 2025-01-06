using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class DosyaŞifreleme : MonoBehaviour
{
    public TMP_InputField inputField; // TextMeshPro InputField bileşeni
    public int correctValue = 73; // Doğru kabul edilen değer
    public string sceneToLoad = "dosya 2. sayfa"; // Açılacak sahnenin adı

    void Start()
    {
        if (inputField != null)
        {
            inputField.onEndEdit.AddListener(CheckInputValue); // Listener ekle
        }
        else
        {
            Debug.LogError("TMP_InputField atanmadı! Inspector'da kontrol et.");
        }
    }

    void CheckInputValue(string value)
    {
        if (int.TryParse(value, out int enteredValue))
        {
            if (enteredValue == correctValue)
            {
                Debug.Log("Doğru değer girildi. Sahne yükleniyor...");
                SceneManager.LoadScene(sceneToLoad);
            }
            else
            {
                Debug.Log("Yanlış değer girildi: " + enteredValue);
            }
        }
        else
        {
            Debug.Log("Lütfen geçerli bir sayı girin.");
        }
    }
}