using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Button))]
public class ButtonEvent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    /// <summary>
    /// ボタンに重なった時色を変えるコンポーネント
    /// </summary>
    [SerializeField] EventTrigger _trigger;

    [SerializeField] Text _buttonText;

    [SerializeField] Color _afterFadeColor;

    [SerializeField] float _fadeTime;

    

    [SerializeField] Color _originColor;
    void Start()
    {
        _originColor = _buttonText.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("灰った");
        _buttonText.DOColor(_afterFadeColor, 1f).SetEase(Ease.Linear);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("de" +
            "た");
        _buttonText.DOColor(_originColor, 1f).SetEase(Ease.Linear);
    }
}
