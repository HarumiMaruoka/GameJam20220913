using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class PulseScore : MonoBehaviour
{
    [SerializeField] float _scoreChangeInterval = 0.5f;
    Text _scoreText = default;

    int _maxScore = 99999;
    int _score = 0;

    void Start()
    {
        _scoreText = GetComponent<Text>();
        PlusScore(ScoreManager._score);
    }


    public void PlusScore(int score)
    {
        int tempScore = _score;
        _score = Mathf.Min(_score + score, _maxScore);


        if (tempScore != _maxScore)
        {

            DOTween.To(() => tempScore,
                x => tempScore = x,
                _score,
                _scoreChangeInterval)
                .OnUpdate(() => _scoreText.text = tempScore.ToString("00000")).SetEase(Ease.InOutQuad)
                .OnComplete(() => _scoreText.text = _score.ToString("00000"));

        }
    }
}
