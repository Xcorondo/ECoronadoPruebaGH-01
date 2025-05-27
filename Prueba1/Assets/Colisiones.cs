using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    private Movimiento movimientoScript;
    // Start is called before the first frame update
    void Start()
    {
        movimientoScript = GetComponent<Movimiento>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstáculo")
        {
            movimientoScript.enabled = false;
            Invoke("Reiniciar Nivel", 1);
        }
    }
}
