using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// プレイヤーの接触系の処理
/// </summary>
public class PlayerCollider : MonoBehaviour
{
    [Header("無敵時間のインターバル"), SerializeField]
    float _godModeTime = 1f;
    [Header("無敵かどうか"),SerializeField]
    bool _isGodMode = false;

    [Header("プレイヤーのライフ"), SerializeField] public int _life = 10;

    //敵接触時の処理
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            //Godモードでなければ実行する。
            if (!_isGodMode)
            {
                _life--;
                if (_life < 1)
                {
                    SceneChanger._beforeSceneName = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene("ResultScene");
                }
                StartCoroutine(GodModeInterval());
            }
        }
    }

    IEnumerator GodModeInterval()
    {
        _isGodMode = true;
        yield return new WaitForSeconds(_godModeTime);
        _isGodMode = false;
    }
}
