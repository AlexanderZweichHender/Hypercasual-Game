using _Project.Constants;
using _Project.Services;
using UnityEngine.UI;
using UnityEngine;

public class LevelsScreen : BaseScreen
{
    [SerializeField] private Button _easyButton;
    [SerializeField] private Button _middleButton;
    [SerializeField] private Button _hardButton;

    [SerializeField] private Button _backButton;

    private void OnEnable()
    {
        _easyButton.onClick.AddListener(() =>
        {
            ButtonOnClicked(_easyButton, PlayEasy);
        });

        _middleButton.onClick.AddListener(() =>
        {
            ButtonOnClicked(_middleButton, PlayMiddle);
        });

        _hardButton.onClick.AddListener(() =>
        {
            ButtonOnClicked(_hardButton, PlayHard);
        });

        _backButton.onClick.AddListener(() =>
        {
            ButtonOnClicked(_backButton, GoBack);
        });
    }

    private void OnDisable()
    {
        _easyButton.onClick?.RemoveAllListeners();
        _middleButton.onClick?.RemoveAllListeners();
        _hardButton.onClick?.RemoveAllListeners();
        _backButton.onClick?.RemoveAllListeners();  
    }

    private void PlayEasy()
    {
        SceneLoader.LoadLevel(Dificult.Easy);
    }

    private void PlayMiddle()
    {
        SceneLoader.LoadLevel(Dificult.Middle);
    }

    private void PlayHard()
    {
        SceneLoader.LoadLevel(Dificult.Hard);
    }    

    private void GoBack()
    {
        ScreenStateMachine.Instance.SetScreen(ScreenState.Menu);
    }
}
