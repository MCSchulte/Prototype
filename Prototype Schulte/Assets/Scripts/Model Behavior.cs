using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void planetAdded(Collider col)
    {
        if (col.CompareTag("MiniPlanet"))
        {
            Debug.Log("Planet Added");
            //The planet attaches to the model and a big planet spawns at the same rotation and placement
        }
    }
}
