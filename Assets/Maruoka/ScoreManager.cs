using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// スコア管理者
/// </summary>
public class ScoreManager : MonoBehaviour
{
    static public int _score = 0;

    /// <summary>
    /// スコアをリセットする。
    /// </summary>
    static public void ResetScore()
    {
        _score = 0;
    }
}
