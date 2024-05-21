using _Project.Constants;
using _Project.Services;
using UnityEngine.UI;
using UnityEngine;

public class MenuScreen : BaseScreen
{
    [SerializeField] private Button _settingsButton;
    [SerializeField] private Button _levelsButton;
    [SerializeField] private Button _shopButton;
    [SerializeField] private Button _playButton;

    private void OnEnable()
    {
        _settingsButton.onClick.AddListener(() =>
        {
            ButtonOnClicked(_settingsButton, OpenSettings);
        });

        _levelsButton.onClick.AddListener(() =>
        {
            ButtonOnClicked(_levelsButton, OpenLevels);
        });

        _shopButton.onClick.AddListener(() =>
        {
            ButtonOnClicked(_shopButton, OpenShop);
        });

        _playButton.onClick.AddListener(() =>
        {
            ButtonOnClicked(_playButton, Play);
        });
    }

    private void OnDisable()
    {
        _shopButton.onClick?.RemoveAllListeners();
        _levelsButton.onClick?.RemoveAllListeners();
        _shopButton.onClick?.RemoveAllListeners();
        _playButton.onClick?.RemoveAllListeners();
    }

    private void OpenSettings()
    {
        ScreenStateMachine.Instance.SetScreen(ScreenState.Settings);
    }

    private void OpenLevels()
    {
        ScreenStateMachine.Instance.SetScreen(ScreenState.Dificult);
    }

    private void OpenShop()
    {
        ScreenStateMachine.Instance.SetScreen(ScreenState.Shop);
    }

    private void Play()
    {
        SceneLoader.LoadLevel(Dificult.Easy);
    }
}
