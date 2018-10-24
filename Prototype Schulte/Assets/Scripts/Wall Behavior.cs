using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StarCollision(Collider col)
    {
        if (col.CompareTag("Star"))
        {
            Debug.Log("Star detected");
        }
    }

    public void AsteroidCollision(Collider col)
    {
        if (col.CompareTag("Asteroid"))
        {
            Debug.Log("Asteroid detected");
        }
    }
}
