using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anahtar : MonoBehaviour
{
    public static bool hasKey = false; // Anahtar�n al�n�p al�nmad���n� takip eden statik de�i�ken

    private void OnMouseDown() // �rnek olarak t�klama ile alma
    {
        hasKey = true; // Anahtar al�nd�
        Destroy(gameObject); // Anahtar� yok et
        Debug.Log("Anahtar Al�nd�!");
    }
}
