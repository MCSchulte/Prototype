using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehavior : MonoBehaviour {

    Collider col;

	// Use this for initialization
	void Start () {
        col = GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
        RoomCollision(col);
	}

    //Destroys object
    public void DestroyGameObject()
    {
        Destroy(gameObject);
    }

    //Deletes object when hits boundary
    public void RoomCollision(Collider col)
    {
        if (col.CompareTag("Wall") || col.CompareTag("Floor") || col.CompareTag("Ceiling"))
        {
            Debug.Log("Room detected");
            Destroy(gameObject);
        }
    }
}
