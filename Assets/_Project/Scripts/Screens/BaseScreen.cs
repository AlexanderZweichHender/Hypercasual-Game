using _Project.Services;
using UnityEngine.UI;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Canvas))]
public abstract class BaseScreen : MonoBehaviour
{
    protected virtual void ButtonOnClicked(Button button, TweenCallback callback)
    {
        AudioService.Instance.PlayClickSound();
        AnimationService.Instance.PlayAnimation(button.gameObject, callback);
    }
}
