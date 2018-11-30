using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {

    public bool xButtonPress = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.Get(OVRInput.Button.Three) == true)
        {
            xButtonPress = true;
        } else if (OVRInput.Get(OVRInput.Button.Four) == true && xButtonPress == false)
        {
            resetScene();
        }
        xButtonPress = false;

    }

    public void resetScene()
    {
        SceneManager.LoadScene("Space Room");
    }
}
