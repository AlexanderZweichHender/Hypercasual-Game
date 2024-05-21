using System.Collections.Generic;
using _Project.Services;
using UnityEngine;

public class GameScreenStateMachine : Singleton<GameScreenStateMachine>
{
    [SerializeField] private BaseScreen _gameUI;
    [SerializeField] private BaseScreen _settingsScreen;
    [SerializeField] private BaseScreen _winScreen;
    [SerializeField] private BaseScreen _loseScreen;
    [SerializeField] private ScreenState _currentScreen = ScreenState.Game;

    private Dictionary<ScreenState, BaseScreen> _screens;

    protected override void Awake()
    {
        base.Awake();
        Init();

        SetScreenState(_currentScreen);
    }

    private void Init()
    {
        _screens = new()
        {
            { ScreenState.Game, _gameUI },
            { ScreenState.Settings, _settingsScreen },
            { ScreenState.Win, _winScreen },
            { ScreenState.Lose, _loseScreen }
        };
    }

    public void SetScreenState(ScreenState newScreen)
    {
        _screens[_currentScreen].gameObject.SetActive(false);
        _screens[newScreen].gameObject.SetActive(true);

        _currentScreen = newScreen;
    }
}
