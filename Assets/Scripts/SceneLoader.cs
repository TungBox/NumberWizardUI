using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
     public void LoadGame ()
	{
	   SceneManager.LoadScene("Game");
	}
	public void LoadStart ()
	{
	   SceneManager.LoadScene("Start");
	}
	public void LoadWin ()
	{
		SceneManager.LoadScene ("Win");
	}
	public void LoadLose ()
	{
		SceneManager.LoadScene ("Lose");
	}
}
