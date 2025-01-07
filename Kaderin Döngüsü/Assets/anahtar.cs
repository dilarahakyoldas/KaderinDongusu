using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anahtar : MonoBehaviour
{
    public static bool hasKey = false; // Anahtarýn alýnýp alýnmadýðýný takip eden statik deðiþken

    private void OnMouseDown() // Örnek olarak týklama ile alma
    {
        hasKey = true; // Anahtar alýndý
        Destroy(gameObject); // Anahtarý yok et
        Debug.Log("Anahtar Alýndý!");
    }
}
