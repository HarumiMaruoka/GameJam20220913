using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class PlayerHitPoint : MonoBehaviour
{
    [Header("ハートのスプライト : プレハブ"), SerializeField] GameObject _heartSpritePrefab;
    PlayerCollider _playerHitPoint;
    [Header("playerのタグ"), SerializeField] string _playerTagName = "Player";

    void Start()
    {
        _playerHitPoint = GameObject.FindGameObjectWithTag(_playerTagName).GetComponent<PlayerCollider>();
        //ハートを生成する。
        for (int i = 0; i < _playerHitPoint._life; i++)
        {
            Instantiate(_heartSpritePrefab, transform);
        }
    }


    private void OnEnable()
    {

    }

    void Update()
    {
        if (transform.childCount != _playerHitPoint._life)
        {
            if (transform.childCount < _playerHitPoint._life)
            {
                for (int i = 0; i < Mathf.Abs(transform.childCount - _playerHitPoint._life); i++)
                {
                    Instantiate(_heartSpritePrefab, transform);
                }
            }

            else if (transform.childCount > _playerHitPoint._life)
            {
                for (int i = 0; i < Mathf.Abs(transform.childCount - _playerHitPoint._life); i++)
                {
                    Destroy(transform.GetChild(i).gameObject);
                }
            }
        }
    }
}
