using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas : MonoBehaviour {
    float contador = 0;
    [SerializeField] private float velocidad;
    [SerializeField] private float topArriba;
    private float topAbajo;


    // Use this for initialization
    void Start () {
        topAbajo = (topArriba * 2);
	}
	
	// Update is called once per frame
	void Update () {
        contador = contador + Time.deltaTime;

        if (contador >= 0 && contador <= topArriba) {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime);
        }
        if (contador > topArriba && contador <= topAbajo) {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);
        }
        if (contador > topAbajo) {
            contador = 0;
        }

    }
}
