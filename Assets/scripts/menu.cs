using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene("Fase0");
    }

    public void Creditos()
    {
        SceneManager.LoadScene("creditos");
    }
}
