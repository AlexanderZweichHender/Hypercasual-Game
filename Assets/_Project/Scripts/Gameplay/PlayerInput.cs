using _Project.Services;
using UnityEngine.UI;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [HideInInspector] public Vector2 Direction;

    [SerializeField] private Button
        _upButton, _downButton,
        _leftButton, _rightButton;


    private void OnEnable()
    {
        _upButton.onClick.AddListener(() =>
        {
            AudioService.Instance.PlayMoveSound();
            Direction = Vector2.up;
        });

        _downButton.onClick.AddListener(() =>
        {
            AudioService.Instance.PlayMoveSound();
            Direction = Vector2.down;
        });

        _leftButton.onClick.AddListener(() =>
        {
            AudioService.Instance.PlayMoveSound();
            Direction = Vector2.left;
        });

        _rightButton.onClick.AddListener(() =>
        {
            AudioService.Instance.PlayMoveSound();
            Direction = Vector2.right;
        });
    }
}
