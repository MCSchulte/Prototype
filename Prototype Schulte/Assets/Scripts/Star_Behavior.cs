using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Behavior : MonoBehaviour {

    Rigidbody starBody;
    Collider col;

    // Use this for initialization
	void Start () {
        col = GetComponent<Collider>();
        starBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
	}


    //Destroys object
    public void DestroyGameObject()
    {
        Destroy(gameObject);
    }

    //If touching wall or ceiling will freeze, if floor will delete
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Wall") || col.gameObject.CompareTag("Ceiling"))
        {
            Debug.Log("Wall detected");
            starBody.constraints = RigidbodyConstraints.FreezePosition;
        }
        else if (col.gameObject.CompareTag("Floor"))
        {
            Debug.Log("Floor detected");
            Destroy(gameObject);
        }
    }

}
