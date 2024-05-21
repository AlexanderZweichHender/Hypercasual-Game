using UnityEngine;
using DG.Tweening;

namespace _Project.Services
{
    public sealed class AnimationService : Singleton<AnimationService>
    {
        [SerializeField] private Vector2 _size = new Vector2(0.9f, 0.9f);
        [SerializeField] private float _duration;

        public void PlayAnimation(GameObject @object, TweenCallback callback)
        {
            DOTween.Sequence()
                .Append(@object.transform.DOScale(_size, _duration))
                .Append(@object.transform.DOScale(Vector2.one, _duration))
                .AppendCallback(callback);
        }
    }
}
