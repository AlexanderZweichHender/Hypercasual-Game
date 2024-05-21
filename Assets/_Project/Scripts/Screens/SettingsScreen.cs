using _Project.Services;
using UnityEngine.UI;
using UnityEngine;

public class SettingsScreen : BaseScreen
{
    [SerializeField] private bool _isMenu;
    [SerializeField] private Button _musicButton;
    [SerializeField] private Button _soundButton;
    [SerializeField] private Button _backButton;

    [SerializeField] private Sprite _on;
    [SerializeField] private Sprite _off;

    private void Start()
    {
        UpdateSound();
        UpdateMusic();
    }

    private void OnEnable()
    {
        _soundButton.onClick.AddListener(() =>
        {
            ButtonOnClicked(_soundButton, ChangeSound);
        });

        _musicButton.onClick.AddListener(() =>
        {
            ButtonOnClicked(_musicButton, ChangeMusic);
        });

        _backButton.onClick.AddListener(() =>
        {
            ButtonOnClicked(_backButton, GoBack);
        });
    }

    private void OnDisable()
    {
        _soundButton.onClick?.RemoveAllListeners();
        _musicButton.onClick?.RemoveAllListeners();
    }

    private void ChangeSound()
    {
        SaveService.Sound = !SaveService.Sound;
        UpdateSound();        
    }

    private void ChangeMusic()
    {
        SaveService.Music = !SaveService.Music;
        UpdateMusic();

    }

    private void UpdateSound()
    {
        if (SaveService.Sound)
            _soundButton.image.sprite = _on;
        else
            _soundButton.image.sprite = _off;
    }

    private void UpdateMusic()
    {
        if (SaveService.Music)
            _musicButton.image.sprite = _on;
        else
            _musicButton.image.sprite = _off;

        AudioService.Instance.UpdateMusic();
    }

    private void GoBack()
    {
        if (_isMenu)
            ScreenStateMachine.Instance.SetScreen(ScreenState.Menu);
        else
            GameScreenStateMachine.Instance.SetScreenState(ScreenState.Game);
    }
}
