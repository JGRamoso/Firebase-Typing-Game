using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreElement : MonoBehaviour
{

    public TMP_Text usernameText;
    public TMP_Text scoreText;
    public void NewScoreElement (string _username, int score)
    {
        usernameText.text = _username;
        scoreText.text = score.ToString();
    }
}