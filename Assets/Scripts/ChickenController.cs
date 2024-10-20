using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenController : MonoBehaviour
{
    public GameObject ovoPrefab; // Prefab do ovo a ser gerado.
    private float tempoMin = 2f; // Tempo mínimo de geração do ovo.
    private float tempoMax = 5f; // Tempo máximo de geração do ovo.
    private int ovosColetados = 0; // Contador de ovos coletados.

    void Start()
    {
        // Inicia a geração de ovos.
        StartCoroutine(GerarOvo());
    }

    IEnumerator GerarOvo()
    {
        while (true)
        {
            float tempoGeracao = Random.Range(tempoMin, tempoMax);
            yield return new WaitForSeconds(tempoGeracao);

            Instantiate(ovoPrefab, transform.position, Quaternion.identity);

            // Verifica se deve ajustar a velocidade de geração dos ovos.
            AjustarTempoGeracao();
        }
    }

    public void ColetarOvo()
    {
        ovosColetados++;

        // Chame este método sempre que um ovo for coletado pelo jogador.
        AjustarTempoGeracao();
    }

    void AjustarTempoGeracao()
    {
        if (ovosColetados >= 50)
        {
            tempoMin = 1f;
            tempoMax = 2f;
        }
        else if (ovosColetados >= 25)
        {
            tempoMin = 2f;
            tempoMax = 3f;
        }
        else if (ovosColetados >= 10)
        {
            tempoMin = 2f;
            tempoMax = 4f;
        }
    }
}
