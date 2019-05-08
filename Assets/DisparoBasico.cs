using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoBasico : MonoBehaviour
{
    public GameObject ondaBasica;
    public Transform generador;
    public float fuerzaAtk;

    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        anim.SetBool("BasicAtk", true);
        GameObject ondaBasicaNueva;
        Rigidbody2D rbOndaBasicaNueva;
        ondaBasicaNueva = Instantiate(ondaBasica, generador.position, generador.rotation);
        rbOndaBasicaNueva = ondaBasicaNueva.GetComponent<Rigidbody2D>();
        rbOndaBasicaNueva.AddForce(ondaBasicaNueva.transform.right * fuerzaAtk);
    }

    private void OnMouseUp()
    {
        anim.SetBool("BasicAtk", false);
    }

}
