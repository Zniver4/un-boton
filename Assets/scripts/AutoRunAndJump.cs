using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRunAndJump : MonoBehaviour
{
    public float speed = 5f; // Velocidad de avance del personaje
    public float jumpForce = 10f; // Fuerza del salto
    private Rigidbody rb;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movimiento automático hacia adelante en la dirección Z
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speed);

        // Salto al presionar la tecla espacio
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Detectar si el personaje está tocando el suelo
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}

