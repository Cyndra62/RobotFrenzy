using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanzagranada : MonoBehaviour {
    [SerializeField] GameObject bomba;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(1)) {
            Instantiate(bomba, transform.position, transform.rotation);
        }
	}

    
}
