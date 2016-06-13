using UnityEngine;
using System.Collections;

public class MenuManagerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //PLAY
    public void Play() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
}
