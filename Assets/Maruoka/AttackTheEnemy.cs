using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// 敵を攻撃するコンポーネント。 : <br/>
/// 敵にアタッチする。
/// </summary>
public class AttackTheEnemy : MonoBehaviour, IPointerClickHandler
{
    [Header("ライフ"), SerializeField] int _life = 1;
    [Header("撃破時に加算するスコア量"), SerializeField]
    int _score = 10;

    /// <summary>
    /// オブジェクトをクリックしたらライフを減らし、ライフが 0 になったら破棄する。<br/>
    /// スコアを加算する。
    /// </summary>
    /// <param name="eventData"></param>
    void IPointerClickHandler.OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
    {
        _life--;

        if (_life < 1)
        {
            Destroy(this.gameObject);
            ScoreManager._score += _score;
        }
    }
}
