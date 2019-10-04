using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Application.LoadLevel(name);
		Debug.Log ("The level you're going to loa d is: " + name);
	}
	
	public void QuitRequest(){
		Application.Quit();
		Debug.Log("Quit request fired: ");
	}
	
}
