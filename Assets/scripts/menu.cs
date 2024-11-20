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

    public void Fase2()
    {
        if(gameObject.CompareTag("Player"))
        {
            gameObject.CompareTag("porta1");
            SceneManager.LoadScene("Fase1");
        }
        
    }
    
    public void Fase3()
    {
        if(gameObject.CompareTag("Player"))
        {
            gameObject.CompareTag("porta2");
            SceneManager.LoadScene("Fase1");
        }
    }
}
