using System.Collections.Generic;
using UnityEngine;

namespace _Project.Services
{
    public class ScreenStateMachine : Singleton<ScreenStateMachine>
    {
        [SerializeField] private BaseScreen _loadingScreen;
        [SerializeField] private BaseScreen _menuScreen;
        [SerializeField] private BaseScreen _settingsScreen;
        [SerializeField] private BaseScreen _dificultScreen;
        [SerializeField] private BaseScreen _shopScreen;

        private Dictionary<ScreenState, BaseScreen> _screens;
        private ScreenState _currentScreen;

        protected override void Awake()
        {
            base.Awake();
            Init();

            SetScreen(ScreenState.Loading);
        }

        private void Init()
        {
            _screens = new()
            {
                { ScreenState.Loading, _loadingScreen },
                { ScreenState.Menu, _menuScreen },
                { ScreenState.Settings, _settingsScreen },
                { ScreenState.Dificult, _dificultScreen },
                { ScreenState.Shop, _shopScreen}
            };
        }

        public virtual void SetScreen(ScreenState screen)
        {
            _screens[_currentScreen].gameObject.SetActive(false);
            _screens[screen].gameObject.SetActive(true);

            _currentScreen = screen;
        }
    }


    public enum ScreenState
    {
        Loading,
        Menu,
        Settings,
        Dificult,
        Shop,
        Win,
        Lose,
        Game
    }
}
