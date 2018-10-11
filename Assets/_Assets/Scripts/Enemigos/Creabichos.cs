using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creabichos : MonoBehaviour {

    [SerializeField] GameObject[] enemigos = new GameObject [2];
    [SerializeField] int tipoEnemigo;

    // Use this for initialization
    void Start () {
        Instantiate(enemigos[tipoEnemigo], transform.position, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
