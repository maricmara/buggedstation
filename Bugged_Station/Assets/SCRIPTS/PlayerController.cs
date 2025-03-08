using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidade do movimento
    private Rigidbody2D rb;      // Referência ao Rigidbody2D do player

    // Start é chamado antes do primeiro frame de atualização
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtém o componente Rigidbody2D
    }

    // Update é chamado uma vez por frame
    void Update()
    {
        MovePlayer(); // Chama o método de movimento
    }

    void MovePlayer()
    {
        // Pegando o input horizontal (A/D ou setas esquerda/direita)
        float moveX = Input.GetAxisRaw("Horizontal");

        // Pegando o input vertical (W/S ou setas para cima/baixo)
        float moveY = Input.GetAxisRaw("Vertical");

        // Criando o vetor de movimento
        Vector2 moveDirection = new Vector2(moveX, moveY).normalized;

        // Movendo o player com base no vetor de movimento e velocidade
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}