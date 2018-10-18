    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Premio : MonoBehaviour {
    [SerializeField] private float RotationSpeed;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        transform.Rotate(1, 0, 0 + RotationSpeed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision player) {
        Debug.Log(player.gameObject.tag);
        if (player.gameObject.tag == "Player") {
            Debug.Log("Destruye premio");
            SceneManager.LoadScene(0);
        }
    }

    /*private void OnCollisionEnter(Collision player) {
        Debug.Log(player.gameObject.tag);
        if (player.gameObject.tag == "Player") {
            Debug.Log("Destruye premio");
            SceneManager.LoadScene(0);
        }
    }*/
}
