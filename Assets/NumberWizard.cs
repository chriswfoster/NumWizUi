using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	public Text text;
	int min = 1;
	int max = 1000; 
	int guess = 500;
	
	int maxGuessesAllowed = 10;
	
	public void ChoiceHandler(string choice){
		if(choice == "Higher"){
			min = guess;
			NextGuess ();
		} else if(choice == "Lower"){
			max = guess;
			NextGuess();
		}
	}
	
	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame (){
		text.text = "======================== \n" +
					"Welcome to Number Wizard \n" +
					"Pick a number in your head, between " + min + " and "  + max + ", but DON'T TELL A SOUL!!! \n" +
					"Is the number higher or lower than " + guess + "? \n" +
					"Up arrow for higher, down arrow for lower, return for equal";
		
		// to open the Unity docs about an api, put cursor on the function
		// then hold control, then hit apostrophe: '	
	}

	void ResetGame(){
		min = 1;
		max = 1000;
		guess = 500;
	}
	
	void NextGuess (){
		guess = (max + min) / 2;
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel('Win');
		}
	}
	

	
	// Update is called once per frame
	void Update () {// update listens to a frame calls.
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			min = guess;
			NextGuess ();
		} else if(Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess;
			NextGuess();
		} else if(Input.GetKeyDown(KeyCode.Return)){
			print("Teh Wizardz has won!");
			ResetGame ();
			StartGame ();
		}
	}
}
