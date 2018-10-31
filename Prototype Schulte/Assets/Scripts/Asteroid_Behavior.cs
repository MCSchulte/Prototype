using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_Behavior : MonoBehaviour {

    Collider col;

	// Use this for initialization
	void Start () {
        col = GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    //Destroys object
    public void DestroyGameObject()
    {
        Destroy(gameObject);
    }

    //Deletes object when hits boundary
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Wall") || col.gameObject.CompareTag("Floor") || col.gameObject.CompareTag("Ceiling"))
        {
            Debug.Log("Room detected");
            Destroy(gameObject);
        }
    }
}
