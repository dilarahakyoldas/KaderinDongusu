using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class salon : MonoBehaviour
{
    public void sagbutton()
    {
        SceneManager.LoadScene("yatakOdasi");
    }
    public void solbutton()
    {
        SceneManager.LoadScene("banyo");
    }
}
