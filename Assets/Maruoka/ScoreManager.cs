using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �X�R�A�Ǘ���
/// </summary>
public class ScoreManager : MonoBehaviour
{
    static public int _score = 0;

    /// <summary>
    /// �X�R�A�����Z�b�g����B
    /// </summary>
    public void ResetScore()
    {
        _score = 0;
    }
}
