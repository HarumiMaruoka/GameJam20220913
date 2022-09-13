using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawScoreController : MonoBehaviour
{
    Text _scoreText = default;
    void Start()
    {
        _scoreText = GetComponent<Text>();
    }

    void Update()
    {
        _scoreText.text = $"Score : {ScoreManager._score.ToString("000000")}";
    }
}
