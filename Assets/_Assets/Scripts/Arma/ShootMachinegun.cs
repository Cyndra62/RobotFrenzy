using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMachinegun : MonoBehaviour {
    [SerializeField] Transform bala;
    [SerializeField] int tiempo;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            ponerBala();    
        }
    }

    void ponerBala()
    {
        Instantiate(bala, transform.position, transform.rotation);
    }
}
