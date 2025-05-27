using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour
{
    Rigidbody rbCarro;

    [SerializeField]
    private float sensibilidad;
    private float velocidad
    {
        set
        {
            velocidad = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rbCarro = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rbCarro.AddForce(0, 0, velocidad * Time.deltaTime);
        
        if (Input.GetKey("d"))
        {
            rbCarro.AddForce(sensibilidad * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rbCarro.AddForce(sensibilidad * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rbCarro.position.y < -1f)
        {
            Invoke("ReiniciarNivel", 1);
        }
    }

    void ReiniciarNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
