using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour {
    public Animator anim;
    public bool xButtonPress = false;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        
        if (OVRInput.Get(OVRInput.Button.Three) == true)
        {
            xButtonPress = true;
            if (OVRInput.Get(OVRInput.Button.Four) == true && xButtonPress == true)
            {
                anim.Play("Roll_Credits");
                
            }
        }
        xButtonPress = false;
    }
    
    public void exitPlease()
    {
        Application.Quit();
    }
}
