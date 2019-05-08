using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoEnemigo : MonoBehaviour
{
    public GameObject bala;
    public Transform entrega;
    public float fuerza = 500f;
    Rigidbody2D rb;
    bool disparo = false;
    float proximoDisparo;
    float disparo1 = 0f;
    public float cadenciaDisparo = 1;
    public float tiempoMin; 
    public float tiempoMax;
    public Transform player2;
    float distancia;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
            if (proximoDisparo < Time.time)
            {
                disparo = true;
                //proximoDisparo = Time.time + cadenciaDisparo;
                //Debug.Log(proximoDisparo);
            }


       


    }
    void FixedUpdate()
    {


        if (disparo)
        {
            dispararBala();
            disparo = false;
        }

    }


    void dispararBala()
    {

        GameObject balaNueva;
        Rigidbody2D rbBalaNueva;
        proximoDisparo = Time.time + Random.Range(tiempoMin, tiempoMax);
        balaNueva = Instantiate(bala, entrega.position, entrega.rotation);
        rbBalaNueva = balaNueva.GetComponent<Rigidbody2D>();
        rbBalaNueva.AddForce(balaNueva.transform.right * -fuerza);

    }
}
