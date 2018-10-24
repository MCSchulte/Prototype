using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RoomCollision(Collider col)
    {
        if (col.CompareTag("Wall") || col.CompareTag("Floor") || col.CompareTag("Ceiling"))
        {
            Debug.Log("Room detected");
            //It gets deleted
        }
    }
}
