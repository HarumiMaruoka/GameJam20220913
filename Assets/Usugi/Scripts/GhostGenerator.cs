using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostGenerator : MonoBehaviour
{
    /// <summary>
    /// �w�i�p�̃S�[�X�g�𐶐�����R���|�[�l���g
    /// </summary>
    [Tooltip("��������S�[�X�g"), SerializeField] GameObject _ghost;

    [Tooltip("Y���W�̐����͈�"), SerializeField] float _Yrange;

    [SerializeField] int _instatiateDuration;

    bool _wait;

    // Update is called once per frame
    void Update()
    {
        if (!_wait)
        {
            _wait = true;
            StartCoroutine(nameof(InstantiateGhost));
        }

    }

    IEnumerator InstantiateGhost()
    {
        

        yield return new WaitForSeconds(_instatiateDuration);

        _Yrange = Random.Range(-4, 4f);

        Instantiate(_ghost, new Vector3(transform.position.x, _Yrange, transform.position.y), Quaternion.identity);

        _wait = false;
    }
}
