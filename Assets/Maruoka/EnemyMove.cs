using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 敵の移動を制御するコンポーネント
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMove : MonoBehaviour
{
    [Header("移動速度"), SerializeField]
    float _moveSpeed = 1f;

    [Header("プレイヤーのタグ"), SerializeField]
    string _playerTagName = "Player";

    Transform _playerPos = default;

    Rigidbody2D _rb2D;

    void Start()
    {
        _playerPos = GameObject.FindGameObjectWithTag(_playerTagName).transform;
        if (_playerPos == null)
        {
            Debug.LogError("プレイヤーの取得に失敗しました。");
        }
        _rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    /// <summary>
    /// プレイヤーに向かって移動する。
    /// </summary>
    private void Move()
    {
        var targetVector = _playerPos.position - transform.position;
        if (_playerPos != null)
        {
            // プレイヤーに向かう方向ベクトルを取得し、
            //var targetVector = _playerPos.position - transform.position;
            // 移動するための速度を与える。
            _rb2D.velocity = targetVector.normalized * _moveSpeed;
        }
    }
}
