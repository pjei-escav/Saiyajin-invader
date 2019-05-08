using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float anchurax;
    public float anchuray;
    Vector2 destino;
    public float vel;
    bool movAbajo = true;
    bool movIzq = true;
    bool movUp = true;
    bool movArriba = true;
    bool movIzqu = true;


    // Start is called before the first frame update
    void Start()
    {
        destino.y = anchuray + transform.position.y;
        destino.x = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if((Vector2)transform.position != destino)
        {
            transform.position = Vector2.MoveTowards(transform.position,destino, vel * Time.deltaTime);
        }    
        else if ( movArriba )
        {
            movArriba = false;
            destino.x = destino.x - anchurax; //izq
            movIzq = true;

        }
        else if (movIzq)
        {
            movIzq = false;
            destino.y = destino.y - anchuray; //abajo
            movAbajo = true;
        }
        else if (movAbajo)
        {
            movAbajo = false;
            destino.x = destino.x - anchurax; //izq
            movUp = true;


        }
        else if (movUp)
        {
            movUp = false;
            destino.y = destino.y + anchuray; //subiendo
            movArriba = true;


        }
        


    }
}
