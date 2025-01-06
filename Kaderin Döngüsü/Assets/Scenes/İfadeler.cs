using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class İfadeler : MonoBehaviour
{
    public TMP_InputField inputAlan1;
    public TMP_InputField inputAlan2;
    public TMP_InputField inputAlan3;
    public TMP_InputField inputAlan4;
    public TextMeshProUGUI gorunurMetin1;
    public TextMeshProUGUI gorunurMetin2;
    public TextMeshProUGUI gorunurMetin3;
    public TextMeshProUGUI gorunurMetin4;
    public Image gorunurResim;
    public string dogruDeger1 = "dogru1";
    public string dogruDeger2 = "dogru2";
    public string dogruDeger3 = "dogru3";
    public string dogruDeger4 = "dogru4";

    void Start()
    {
        gorunurMetin1.gameObject.SetActive(false);
        gorunurMetin2.gameObject.SetActive(false);
        gorunurMetin3.gameObject.SetActive(false);
        gorunurMetin4.gameObject.SetActive(false);
        inputAlan3.gameObject.SetActive(false);
        inputAlan4.gameObject.SetActive(false);
        gorunurResim.gameObject.SetActive(false);

        inputAlan1.onValueChanged.AddListener(delegate { DegerleriKontrolEt(); }); // Lambda expression ile
        inputAlan2.onValueChanged.AddListener(delegate { DegerleriKontrolEt(); }); // Lambda expression ile
        inputAlan3.onValueChanged.AddListener(delegate { Deger3KontrolEt(); }); // Lambda expression ile
        inputAlan4.onValueChanged.AddListener(delegate { Deger4KontrolEt(); });
    }

    void DegerleriKontrolEt() // Parametre kaldrildi
    {
        if (inputAlan1.text == dogruDeger1 && inputAlan2.text == dogruDeger2)
        {
            gorunurMetin1.gameObject.SetActive(true);
            inputAlan3.gameObject.SetActive(true);
        }
        else
        {
            gorunurMetin1.gameObject.SetActive(false);
            inputAlan3.gameObject.SetActive(false);
            inputAlan4.gameObject.SetActive(false);
            gorunurMetin2.gameObject.SetActive(false);
            gorunurResim.gameObject.SetActive(false);
            gorunurMetin3.gameObject.SetActive(false);
            gorunurMetin4.gameObject.SetActive(false);
        }
    }

    void Deger3KontrolEt() // Parametre kaldırıldı
    {
        if (inputAlan3.text == dogruDeger3)
        {
            gorunurMetin2.gameObject.SetActive(true);
            gorunurResim.gameObject.SetActive(true);
            inputAlan4.gameObject.SetActive(true);
        }
        else
        {
            gorunurMetin2.gameObject.SetActive(false);
            gorunurResim.gameObject.SetActive(false);
            inputAlan4.gameObject.SetActive(false);
        }
    }
    void Deger4KontrolEt() // Parametre kaldırıldı
    {
        if (inputAlan4.text == dogruDeger4)
        {
            gorunurMetin3.gameObject.SetActive(true);
            gorunurMetin4.gameObject.SetActive(true);
        }
        else
        {
            gorunurMetin3.gameObject.SetActive(false);
            gorunurMetin4.gameObject.SetActive(false);

        }
    }
    public void sagbutton()
    {
        SceneManager.LoadScene("d4");
    }
    public void solbutton()
    {
        SceneManager.LoadScene("d1");
    }
}