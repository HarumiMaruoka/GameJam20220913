using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 敵の生成を管理するコンポーネント。
/// </summary>
public class EnemyGenerator : MonoBehaviour
{
    [Header("生成の間隔"), SerializeField]
    RandomValue _randomValue;

    [Header("生成する敵のプレハブ"), SerializeField]
    GameObject _enemyPrefab;

    float _generationInterval;
    bool _isGenerate = true;

    void Update()
    {
        if (_isGenerate)
        {
            _isGenerate = false;
            StartCoroutine(GenerateEnemy());
        }
    }

    IEnumerator GenerateEnemy()
    {
        Instantiate(_enemyPrefab,transform.position,Quaternion.identity);
        // インターバルを待って敵を生成する。
        yield return new WaitForSeconds(Random.Range(_randomValue._minValue, _randomValue._maxValue));
        _isGenerate = true;
    }
}

/// <summary>
/// ランダム値の最小値と最大値を持つ構造体。
/// </summary>
[System.Serializable]
public struct RandomValue
{
    /// <summary> 最小値 </summary>
    public float _minValue;
    /// <summary> 最大値 </summary>
    public float _maxValue;
}
