using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarBehavior : MonoBehaviour {

    Rigidbody starBody;
    Collider col;

    // Use this for initialization
	void Start () {
        col = GetComponent<Collider>();
        starBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        RoomCollision(col, starBody);
	}


    //Detroyes object
    public void DestroyGameObject()
    {
        Destroy(gameObject);
    }

    //If touching wall or ceiling will freeze, if floor will delete
    public void RoomCollision(Collider col, Rigidbody starBody)
    {
        if (col.CompareTag("Wall") || col.CompareTag("Ceiling"))
        {
            Debug.Log("Wall detected");
            starBody.constraints = RigidbodyConstraints.FreezePosition;
        }
        else if (col.CompareTag("Floor"))
        {
            Debug.Log("Floor detected");
            Destroy(gameObject);
        }
    }

}
