using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RoomCollision(Collider col)
    {
        if (col.CompareTag("Wall"))
        {
            Debug.Log("Wall detected");
            //It freezes position against the wall
        }
        else if (col.CompareTag("Floor"))
        {
            Debug.Log("Floor detected");
            //It gets deleted
        }
        else if (col.CompareTag("Ceiling"))
        {
            Debug.Log("Ceiling detected");
            //It freezes position on the ceiling
        }
    }

}
