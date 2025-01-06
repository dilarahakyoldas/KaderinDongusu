using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class foto : MonoBehaviour
{
    public TMP_InputField inputAlan1;
    public Image gorunurResim1;
    public Image gorunurResim2;
    public string dogruDeger1 = "dogru1";

    void Start()
    {

        gorunurResim1.gameObject.SetActive(false);
        gorunurResim2.gameObject.SetActive(false);

        inputAlan1.onValueChanged.AddListener(delegate { DegerleriKontrolEt(); }); // Lambda expression ile


        void DegerleriKontrolEt() // Parametre kaldrildi
        {
            if (inputAlan1.text == dogruDeger1)
            {
                gorunurResim1.gameObject.SetActive(true);
                gorunurResim2.gameObject.SetActive(true);
            }
            else
            {

                gorunurResim1.gameObject.SetActive(false);
                gorunurResim2.gameObject.SetActive(false);

            }
        }
    }
}

