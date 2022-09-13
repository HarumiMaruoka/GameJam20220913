using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Image))]
public class GhostAnim : MonoBehaviour
{
    /// <summary>
    /// �摜���w�肵���n�_�ɏ��Ԃɓ������R���|�[�l���g
    /// </summary>
    [Tooltip("�ŏ��̒n�_")]
    [SerializeField] Vector3 _point1;
    [SerializeField] float _duration1;

    [Tooltip("���̒n�_")]
    [SerializeField] Vector3 _point2;
    [SerializeField] float _duration2;

    [Tooltip("��O�̒n�_")]
    [SerializeField] Vector3 _point3;
    [SerializeField] float _duration3;


    // Start is called before the first frame update
    void Start()
    {
        var thisImage = this.GetComponent<Image>();

        DOTween.Sequence()
            .Append(thisImage.rectTransform.DOMove(_point1, _duration1)).SetRelative().SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
