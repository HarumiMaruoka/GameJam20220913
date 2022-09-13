using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �G�̈ړ��𐧌䂷��R���|�[�l���g
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMove : MonoBehaviour
{
    [Header("�ړ����x"), SerializeField]
    float _moveSpeed = 1f;

    [Header("�v���C���[�̃^�O"), SerializeField]
    string _playerTagName = "Player";

    Transform _playerPos = default;

    Rigidbody2D _rb2D;

    void Start()
    {
        _playerPos = GameObject.FindGameObjectWithTag(_playerTagName).transform;
        if (_playerPos == null)
        {
            Debug.LogError("�v���C���[�̎擾�Ɏ��s���܂����B");
        }
        _rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    /// <summary>
    /// �v���C���[�Ɍ������Ĉړ�����B
    /// </summary>
    private void Move()
    {
        // �v���C���[�Ɍ����������x�N�g�����擾
        var targetVector = (_playerPos.position - transform.position).normalized;
        // �ړ����邽�߂̑��x��^����B
        _rb2D.velocity = targetVector * _moveSpeed;
    }
}
