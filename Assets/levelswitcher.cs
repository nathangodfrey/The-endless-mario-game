using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelswitcher : MonoBehaviour {

	public string nextLevel ;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Return)) {
			SceneManager.LoadScene (nextLevel);
		}
	}
}
