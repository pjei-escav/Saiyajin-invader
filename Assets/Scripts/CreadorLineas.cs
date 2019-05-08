using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorLineas : MonoBehaviour
{
    public GameObject[] lineasEnemigos;
    public int numeroLineas;
    public GameObject posicionInicial;
    public int separacionLineas;
    

    
    // Start is called before the first frame update
    void Start()
    {
        Transform posicion = transform;
        for (int i= 0; i < lineasEnemigos.Length; i++)
        {
           int totalLineas = Random.Range(0, numeroLineas);
            for(int j = 0; j< totalLineas; j++)
            {
                Instantiate(lineasEnemigos[i], posicion);
                posicion.position = new Vector3(posicion.position.x + separacionLineas, posicion.position.y, posicion.position.z);
                Debug.Log(posicion.position.x);
            }
            numeroLineas -= totalLineas;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
