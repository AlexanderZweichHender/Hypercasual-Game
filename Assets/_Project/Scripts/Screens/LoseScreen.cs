using _Project.Services;
using UnityEngine.UI;
using UnityEngine;

public class LoseScreen : BaseScreen
{
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _menuButton;

    private void OnEnable()
    {
        _restartButton.onClick.AddListener(() =>
        {
            ButtonOnClicked(_restartButton, Restart);
        });

        _menuButton.onClick.AddListener(() =>
        {
            ButtonOnClicked(_menuButton, LoadMenu);
        });
    }

    private void OnDisable()
    {
        _restartButton.onClick?.RemoveAllListeners();
        _menuButton.onClick?.RemoveAllListeners();
    }

    private void Restart()
    {
        SceneLoader.Restart();
    }

    private void LoadMenu()
    {
        SceneLoader.LoadMenu();
    }
}
