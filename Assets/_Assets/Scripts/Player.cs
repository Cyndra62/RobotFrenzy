using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField] public static int llaves = 0;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //Se suman las llaves
    private void OnTriggerEnter(Collider Key)
    {
        Key.gameObject.tag = ("Key");
        llaves++;
        Debug.Log("Numero Llaves: " + llaves);
    }

    public int getLlaves()
    {
        return llaves;
    }

    
}
