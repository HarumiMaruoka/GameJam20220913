using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonAnimController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Animator _animation;

    private void Start()
    {
        _animation = GetComponent<Animator>();
    }
    /// <summary>
    /// マウスカーソルが重なったときに実行する。
    /// </summary>
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Anim再生");
        _animation.Play("ContinueButtonPU");
    }
    /// <summary>
    /// マウスカーソルが離れたときに実行する。
    /// </summary>
    /// 
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Anim停止");
        _animation.Play("None");
    }
}
