using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {
    public void playGame () {
        SceneManager.LoadScene("Main");
    }

    public void mainMenu(){
        SceneManager.LoadScene("MenuScreen");
    }

    public FirebaseManager manager;

    public void Leaderboard(){
        StartCoroutine(manager.LoadScoreboardData());
        SceneManager.LoadScene("Leaderboard");
    }
}