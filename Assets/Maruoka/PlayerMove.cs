using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤーの移動を制御するコンポーネント
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [Header("移動速度"), SerializeField] float _moveSpeed = 1f;
    Rigidbody2D _rigidbody2D;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }
    /// <summary>
    /// 移動を制御する。
    /// </summary>
    void Move()
    {
        //入力を取得する
        float h = Input.GetAxisRaw("Horizontal");//水平方向
        float v = Input.GetAxisRaw("Vertical");//垂直方向

        //速度を与える。
        _rigidbody2D.velocity = new Vector2(h, v).normalized * _moveSpeed;
    }
}
