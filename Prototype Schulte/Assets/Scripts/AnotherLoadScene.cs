using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnotherLoadScene : MonoBehaviour {

    public void ChangeScene()
    {
        //Changes to Game Scene
        Debug.Log("Change Scene");
        SceneManager.LoadScene("Space Room");
    }

}
