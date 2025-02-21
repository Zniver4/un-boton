using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnFall : MonoBehaviour
{
    public float fallThreshold = -5f; // Altura mínima antes de cambiar de escena
    public string sceneName = "GameOver"; // Nombre de la escena a la que se cambiará

    void Update()
    {
        // Verifica si el personaje ha caído por debajo del umbral
        if (transform.position.y < fallThreshold)
        {
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        // Cambia a la escena especificada
        SceneManager.LoadScene(sceneName);
    }
}
