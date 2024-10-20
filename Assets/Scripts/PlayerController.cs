using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidade = 15f; // Velocidade de movimentação da cesta.
    public float limiteFrente = 15f; // Limite da posição à frente (direita).
    public float limiteTraseiro = -15f; // Limite da posição atrás (esquerda).

    void Update()
    {
        // Movimentação usando as teclas A e D no eixo Z.
        float movimento = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        transform.Translate(0, 0, movimento);

        // Limita a posição da cesta para não sair da área de jogo.
        float posZ = Mathf.Clamp(transform.position.z, limiteTraseiro, limiteFrente);
        transform.position = new Vector3(transform.position.x, transform.position.y, posZ);
    }
}
