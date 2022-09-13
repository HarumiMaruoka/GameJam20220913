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
    /// �{�^���ɏd�Ȃ������F��ς���R���|�[�l���g
    /// </summary>
    [SerializeField] EventTrigger _trigger;
    [SerializeField] Text _buttonText;
    [Tooltip("�ω�����"), SerializeField] float _fadeTime;
    [Tooltip("�ω���̐F"), SerializeField] Color _afterFadeColor;
    [Tooltip("���̐F"), SerializeField] Color _originColor;

    void Start()
    {
        _originColor = _buttonText.color;
    }

    /// <summary>
    /// �}�E�X�I�[�o�[�����Ƃ�
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerEnter(PointerEventData eventData)
    {
        _buttonText.DOColor(_afterFadeColor, 1f).SetEase(Ease.Linear);
    }

    /// <summary>
    /// �}�E�X�A�E�g�����Ƃ�
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerExit(PointerEventData eventData)
    {
        _buttonText.DOColor(_originColor, 1f).SetEase(Ease.Linear);
    }
}
