using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class banyo : MonoBehaviour
{
    public void sagbutton()
    {
        SceneManager.LoadScene("Salon");
    }
    public void solbutton()
    {
        SceneManager.LoadScene("yatakOdasi");
    }
}
