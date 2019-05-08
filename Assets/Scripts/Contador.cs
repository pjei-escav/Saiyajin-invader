using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
	public int puntos = 0;
	public Text textoMarcador;
	public int limitePuntos = 500;
	// Use this for initialization
	void Start () {
		textoMarcador.text = puntos.ToString ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col){
		if (puntos < limitePuntos) {
		}
		if (col.gameObject.CompareTag ("Enemy")) {
			puntos = puntos + 10;
			textoMarcador.text = puntos.ToString ();
		}
	}
}