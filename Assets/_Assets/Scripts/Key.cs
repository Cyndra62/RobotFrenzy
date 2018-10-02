using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {
    [SerializeField] private bool entertrigger =true;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider player)
    {
        Debug.Log("Destruye Llave");
        player.gameObject.tag = ("Player");
        Destroy(this.gameObject);       
    }
}
