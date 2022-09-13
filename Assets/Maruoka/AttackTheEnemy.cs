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
    int _life;

    /// <summary>
    /// オブジェクトをクリックしたらライフを減らし、ライフが 0 になったら破棄する
    /// </summary>
    /// <param name="eventData"></param>
    void IPointerClickHandler.OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
    {
        _life--;

        if (_life < 1)
        {
            Destroy(this.gameObject);
        }
    }
}
