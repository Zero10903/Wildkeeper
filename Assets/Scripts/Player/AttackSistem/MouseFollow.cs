using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    public Transform player;         
    public float distancia = 1.25f;   
    public Camera camara;
    private void Update()
    {
        Follow();
    }

    private void Follow()
    {
        Vector3 mousePos = camara.ScreenToWorldPoint(Input.mousePosition);      //Obtiene la posición del mouse en el mundo 2D/3D de Unity, no en la pantalla
        mousePos.z = 0f;                                                        //Se asegura de que el objeto se mantenga en el plano 2D
        Vector3 direccion = (mousePos - player.position).normalized;            //Calcula un vector unitario que apunta desde el jugador hacia el mouse
        transform.position = player.position + direccion * distancia;           //Posiciona el objeto a cierta distancia desde el jugador en dirección al mouse
        float angle = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;    //Calcula el ángulo de rotación que debe tener el objeto para mirar hacia el mouse
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
