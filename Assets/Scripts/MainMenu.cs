using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string firstLevel;
	public string LevelSelect;

	public string[] levelNames;

	public int startingLives;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void NewGame()
	{
		SceneManager.LoadScene(firstLevel);

		for(int i = 0; i < levelNames.Length; i++)
		{
			PlayerPrefs.SetInt(levelNames[i], 0);
		}

		PlayerPrefs.SetInt("CoinCount", 0);
		PlayerPrefs.SetInt("PlayerLives", startingLives);
	}

	public void Continue()
	{
		SceneManager.LoadScene(LevelSelect);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
