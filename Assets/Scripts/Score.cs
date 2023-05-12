using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform transformScore;
    public Transform transformHighScore;
    public TMP_Text txtHighScore;
    public TMP_Text txtScore;
    public HighScore highScoreSO;

    private void Start()
    {
        transformScore = GameObject.Find("Score").transform;
        transformHighScore = GameObject.Find("HighScore").transform;
        txtScore = transformScore.GetComponent<TMP_Text>();
        txtHighScore = transformHighScore.GetComponent<TMP_Text>();
        // if (PlayerPrefs.HasKey("HighScore"))
        // {
        // }
        highScoreSO.Load();
        txtHighScore.text = $"HighScore: {highScoreSO.highScore}";
        highScoreSO.score = 0;
    }

    private void FixedUpdate()
    {
        highScoreSO.score += 50;
    }

    private void Update()
    {
        txtScore.text = $"Score: {highScoreSO.score}";
        if (highScoreSO.score > highScoreSO.highScore)
        {
            highScoreSO.highScore = highScoreSO.score;
            txtHighScore.text = $"HighScore: {highScoreSO.highScore}";
            highScoreSO.Save();
        }
    }
}
