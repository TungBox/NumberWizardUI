using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NumberWizards : MonoBehaviour {
	// Use this for initialization
	int max;
	int min;
	int guess;

	int maxGuessesAllowed = 5;

            public Text text;
	void Start () {
		StartGame();
	}
	
	void StartGame () {
		max = 1001;
		min = 1;
		NextGuess();
		max = max + 1;
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void GuessHigher () {
		min = guess;
	    NextGuess();
	}
	public void GuessLower () {
	    max = guess;
	    NextGuess();
	}
	void NextGuess ()
	{
		guess = Random.Range(min, max+1);
		text.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0) {
		   SceneManager.LoadScene("Win");
		}
	}
}
