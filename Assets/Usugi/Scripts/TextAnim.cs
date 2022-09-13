using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Button))]
public class TextAnim : MonoBehaviour
{
    /// <summary>
    /// �{�^���ɂ���e�L�X�g���A�j���[�V�������s���X�N���v�g
    /// </summary>

    [Tooltip("�X�^�[�g�{�^���̃e�L�X�g"), SerializeField] Text _buttonText;

    [Tooltip("�t�F�[�h�̊Ԋu"),SerializeField] float _fadeTime;

    [Tooltip("�ω���̐F"), SerializeField] Color _afterFadeColor;

    // Start is called before the first frame update
    void Start()
    {
        _buttonText.DOColor(_afterFadeColor, _fadeTime).SetEase(Ease.InOutQuart).SetLoops(-1, LoopType.Yoyo);
    }

}
