using UnityEngine;
using System.Collections;

public class ExtraLife : MonoBehaviour {

	public int livesToGive;

	private LevelManager theLevelManager;

	// Use this for initialization
	void Start () {
		theLevelManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			theLevelManager.AddLives(livesToGive);
			gameObject.SetActive(false);
		}
	}
}
