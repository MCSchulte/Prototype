using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TriggerLoadScene : MonoBehaviour {

	public void onTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            print("Change Scene");
            SceneManager.LoadScene("Prototype Setup");

        }
    }
}
