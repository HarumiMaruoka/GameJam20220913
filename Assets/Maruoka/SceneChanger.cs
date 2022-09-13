using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// シーンを変える機能
/// </summary>
public class SceneChanger : MonoBehaviour
{
    static public string _beforeSceneName = "";
    public void ChangeScene(string nextSceneName)
    {
        _beforeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(nextSceneName);
    }

    public void ScoreReset()
    {
        ScoreManager.ResetScore();
    }

    public void Continue()
    {
        SceneManager.LoadScene(_beforeSceneName);
        _beforeSceneName = SceneManager.GetActiveScene().name;
    }
}
