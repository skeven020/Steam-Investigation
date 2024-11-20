using UnityEngine;
using TMPro;

public class Papel : MonoBehaviour
{
     //public Panel painel; // Painel a ser exibido (UI Panel)
    public TextMeshProUGUI texto1; // Primeiro texto (TextMeshPro)
    public TextMeshProUGUI texto2; // Segundo texto (TextMeshPro)
    private bool jogadorNaArea; // Verifica se o player está na área
    private Player player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (texto1 != null) texto1.gameObject.SetActive(false);
        if (texto2 != null) texto2.gameObject.SetActive(false);
        player = gameObject.GetComponent<Player>();
    }

    // Update is called once per frame

    void Update()
    {
        
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se o player entrou na colisão com o objeto chamado "Papel"
        if (other.CompareTag("Player") && gameObject.name == "Papel")
        {
            jogadorNaArea = true;
           // if (painel != null) painel.SetActive(true);
            if (texto1 != null) texto1.gameObject.SetActive(true);
            if (texto2 != null) texto2.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // Verifica se o player saiu da colisão
        if (other.CompareTag("Player"))
        {
            jogadorNaArea = false;
           // if (painel != null) painel.SetActive(false);
            if (texto1 != null) texto1.gameObject.SetActive(false);
            if (texto2 != null) texto2.gameObject.SetActive(false);
        }
    }
}