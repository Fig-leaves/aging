using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameScore : MonoBehaviour {
	public PlayerMove player;
	public GameObject gameOverText;
	public Text scoreLabel;
//	public Text  lifePanel;
	public static float timeLeft = 5;
	public Text timeLabel;

	void Start () {
		gameOverText.SetActive(true);
		timeLabel.text = "TimeLeft: " + ((int)timeLeft).ToString ();
	}
	//public LifePanel lifePanel;

	public void Update() {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			gameOverText.SetActive(true);
		}
		int score = calcScore();
		scoreLabel.text = "Score: " + score + "m";
		//lifePanel.UpdateLife(player.Life());
	//	int life = calcLife();
	//	lifePanel.text = "Life: " + life;
		timeLabel.text = ((int)timeLeft).ToString ();

		if (timeLeft <= 0) {
			Application.LoadLevel ("GameOver");
		}

	}

/*	public timer() {
		return timeLeft();
	}

*/

	int calcScore() {
		return (int)player.transform.position.x;
	}
}
