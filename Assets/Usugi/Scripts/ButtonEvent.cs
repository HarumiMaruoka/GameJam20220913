using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(EventTrigger))]
public class ButtonEvent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    /// <summary>
    /// ボタンに重なった時色を変えるコンポーネント
    /// </summary>
    [SerializeField] EventTrigger _trigger;
    [SerializeField] Text _buttonText1;
    [SerializeField] Text _buttonText2;
    [Tooltip("変化時間"), SerializeField] float _fadeTime;
    [Tooltip("変化後の色"), SerializeField] Color _afterFadeColor;
    [Tooltip("元の色"), SerializeField] Color _originColor1;
    [Tooltip("元の色"), SerializeField] Color _originColor2;

    void Start()
    {
        _originColor1 = _buttonText1.color;
        _originColor2 = _buttonText2.color;
    }

    /// <summary>
    /// マウスオーバーしたとき
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerEnter(PointerEventData eventData)
    {
        _buttonText1.DOColor(_afterFadeColor, 1f).SetEase(Ease.Linear);
        _buttonText2.DOColor(_afterFadeColor, 1f).SetEase(Ease.Linear);
    }

    /// <summary>
    /// マウスアウトしたとき
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerExit(PointerEventData eventData)
    {
        _buttonText1.DOColor(_originColor1, 1f).SetEase(Ease.Linear);
        _buttonText2.DOColor(_originColor2, 1f).SetEase(Ease.Linear);
    }
}
