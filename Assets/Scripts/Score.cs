using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;
    public WordManager updateScore;
	
	void Update() {
        scoreText.text = updateScore.score.ToString();
	}
}