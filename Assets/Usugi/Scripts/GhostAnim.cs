using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Image))]
public class GhostAnim : MonoBehaviour
{
    /// <summary>
    /// 画像を指定した地点に順番に動かすコンポーネント
    /// </summary>
    [Tooltip("最初の地点")]
    [SerializeField] Vector3 _point1;
    [SerializeField] float _duration1;

    [Tooltip("第二の地点")]
    [SerializeField] Vector3 _point2;
    [SerializeField] float _duration2;

    [Tooltip("第三の地点")]
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
