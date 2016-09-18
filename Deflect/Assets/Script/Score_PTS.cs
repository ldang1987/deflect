using UnityEngine;
using System.Collections;

public class Score_PTS : MonoBehaviour {

	private int scoreCount;
	private string scoreLabel = "Score";
	private string scoreDisplay;
	// Use this for initialization
	void Start () {
		
		string scoreDisplay = scoreLabel + " " + scoreCount.ToString();
		GetComponent<TextMesh>().text = scoreDisplay;
	}
	
	// Update is called once per frame
	void Update () {
		string scoreDisplay = scoreLabel + " " + scoreCount.ToString();
		GetComponent<TextMesh>().text = scoreDisplay;
	}

	public void increaseScoreCount (){
		scoreCount += 1;
	}
}
