using UnityEngine;

public class Platformovement : MonoBehaviour
{
    public float velocidad = 2.0f; // Velocidad de movimiento
    public float limiteIzquierdo = -5.0f; // L�mite izquierdo en el eje X
    public float limiteDerecho = 5.0f; // L�mite derecho en el eje X

    private bool moviendoDerecha = true;

    void Update()
    {
        // Mover plataforma a la derecha
        if (moviendoDerecha)
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);

            // Verificar si ha llegado al l�mite derecho
            if (transform.position.x >= limiteDerecho)
            {
                moviendoDerecha = false; // Cambiar direcci�n
            }
        }
        else
        {
            // Mover plataforma a la izquierda
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);

            // Verificar si ha llegado al l�mite izquierdo
            if (transform.position.x <= limiteIzquierdo)
            {
                moviendoDerecha = true; // Cambiar direcci�n
            }
        }
    }
}

