using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class karakol : MonoBehaviour
{
    public void SahneGec()
    {

        SceneManager.LoadScene("Dosya");

    }


    void Start()
    {
        
    }

    void Update()
    {
        

        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("sag mouse tuþuna basildi");
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("sag mouse tuþuna basildi");
        }

    }
}
