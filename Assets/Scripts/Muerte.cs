using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
	public float vidaInicial = 3f;
	float vidaActual;
	public Sprite newSprite;

    // Start is called before the first frame update
    void Start()
    {
		vidaActual = vidaInicial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void QuitaVida(float cantidad){
		vidaActual = vidaActual - cantidad;
		if (vidaActual <= 2) {
			//GetComponent (SpriteRenderer).sprite = newSprite;
		}
	}
}
