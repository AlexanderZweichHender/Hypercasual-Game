using _Project.Services;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void OnEnable()
    {
        Timer.OnComplete += ShowLoseScreen;
    }

    private void OnDisable()
    {
        Timer.OnComplete -= ShowLoseScreen;
    }

    private void ShowLoseScreen()
    {
        GameScreenStateMachine.Instance.SetScreenState(ScreenState.Lose);  
    }
}
