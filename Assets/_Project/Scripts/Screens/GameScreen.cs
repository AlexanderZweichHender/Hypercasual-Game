using _Project.Services;
using UnityEngine.UI;
using UnityEngine;

public class GameScreen : BaseScreen
{
    [SerializeField] private Button _homeButton;
    [SerializeField] private Button _settingsButton;

    private void OnEnable()
    {
        _homeButton.onClick.AddListener(() =>
        {
            ButtonOnClicked(_homeButton, LoadMenu);
        });

        _settingsButton.onClick.AddListener(() =>
        {
            ButtonOnClicked(_settingsButton, OpenSettings);
        });
    }

    private void OnDisable()
    {
        _homeButton.onClick?.RemoveAllListeners();
        _settingsButton.onClick?.RemoveAllListeners();
    }

    private void LoadMenu()
    {
        SceneLoader.LoadMenu();
    }

    private void OpenSettings()
    {
        GameScreenStateMachine.Instance.SetScreenState(ScreenState.Settings);
    }
}
