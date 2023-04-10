using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acelerar : MonoBehaviour
{
    public MovimientoBola bola;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Player")
        {
            Debug.Log("bola");
            bola.fuerzaAdelante = 2000f;
        }
    }
}
