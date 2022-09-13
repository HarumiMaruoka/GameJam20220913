using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// 残り時間を管理するコンポーネント
/// </summary>
public class TimeLeft : MonoBehaviour
{
    Text _timeText;
    [Header("制限時間"), SerializeField] float _timeLimit = 30f;
    void Start()
    {
        _timeText = GetComponent<Text>();
    }

    void Update()
    {
        if (_timeLimit > 0f)
        {
            _timeLimit -= Time.deltaTime;
            _timeText.text = $"残り時間 : {_timeLimit.ToString("00.00")}";
        }
        else
        {
            SceneChanger._beforeSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene("ResultScene");
        }
    }
}
