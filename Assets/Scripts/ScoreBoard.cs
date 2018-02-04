using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {


    int score;
    Text scoreText;
        
	void Start () {
        scoreText = GetComponent<Text>();
	}

    private void Update()
    {
        scoreText.text = score.ToString();
    }

    public void ScoreHit(int scorePerHit)
    {
        score += scorePerHit;
    }
}
