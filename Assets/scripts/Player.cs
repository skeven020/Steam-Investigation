using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InteracaoComPapel : MonoBehaviour
{
    public Panel painel; // Painel a ser exibido (UI Panel)
    public TextMeshProUGUI texto1; // Primeiro texto (TextMeshPro)
    public TextMeshProUGUI texto2; // Segundo texto (TextMeshPro)
    private bool jogadorNaArea; // Verifica se o player está na área

    void Start()
    {
        // Garante que o painel e os textos estejam desativados no início
        if (painel != null) painel.gameObject.SetActive(false);
        if (texto1 != null) texto1.gameObject.SetActive(false);
        if (texto2 != null) texto2.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        // Verifica se o player entrou na colisão com o objeto chamado "Papel"
        if (other.CompareTag("Player") && gameObject.name == "Papel")
        {
            jogadorNaArea = true;
            if (painel != null) painel.gameObject.SetActive(true);
            if (texto1 != null) texto1.gameObject.SetActive(true);
            if (texto2 != null) texto2.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Verifica se o player saiu da colisão
        if (other.CompareTag("Player"))
        {
            jogadorNaArea = false;
            if (painel != null) painel.gameObject.SetActive(false);
            if (texto1 != null) texto1.gameObject.SetActive(false);
            if (texto2 != null) texto2.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        // Verifica se o player está na área e a tecla "E" foi pressionada
        if (jogadorNaArea && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject); // Destroi o objeto (Papel)
            if (painel != null) painel.gameObject.SetActive(false);
            if (texto1 != null) texto1.gameObject.SetActive(false);
            if (texto2 != null) texto2.gameObject.SetActive(false);
        }
    }
}