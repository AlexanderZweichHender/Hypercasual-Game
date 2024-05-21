using _Project.Services;
using UnityEngine.UI;
using UnityEngine;

public class ShopScreen : BaseScreen
{
    [SerializeField] private Button _backButton;

    private void OnEnable()
    {
        _backButton.onClick.AddListener(() =>
        {
            ButtonOnClicked(_backButton, GoBack);
        });
    }

    private void OnDisable()
    {
        _backButton.onClick?.RemoveAllListeners();
    }

    private void GoBack()
    {
        ScreenStateMachine.Instance.SetScreen(ScreenState.Menu);
    }
}