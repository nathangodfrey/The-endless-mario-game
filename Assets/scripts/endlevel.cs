using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class endlevel : MonoBehaviour {
	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag == "Player") {
			SceneManager.LoadScene (level);
		}
	}
	public string level;
}
