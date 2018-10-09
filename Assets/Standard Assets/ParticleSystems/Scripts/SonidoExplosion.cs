using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoExplosion : MonoBehaviour {
    private AudioSource source;
    [SerializeField] AudioClip explosion;
    // Use this for initialization
    void Start () {
        source.PlayOneShot(explosion, 1);
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
