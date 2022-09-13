using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Button))]
public class TextAnim : MonoBehaviour
{
    /// <summary>
    /// ボタンにつけるテキストをアニメーションを行うスクリプト
    /// </summary>

    [Tooltip("スタートボタンのテキスト"), SerializeField] Text _buttonText;

    [Tooltip("フェードの間隔"),SerializeField] float _fadeTime;

    [Tooltip("変化後の色"), SerializeField] Color _afterFadeColor;

    // Start is called before the first frame update
    void Start()
    {
        _buttonText.DOColor(_afterFadeColor, _fadeTime).SetEase(Ease.InOutQuart).SetLoops(-1, LoopType.Yoyo);
    }

}
