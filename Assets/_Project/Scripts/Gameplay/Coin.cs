using System.Collections;
using _Project.Services;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField, Range(0, 5)] private float _delay = 2.0f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SaveService.Money += SaveService.Reward;
        AudioService.Instance.PlayPickUpSound();
        StartCoroutine(ShowWinPanel());
    }

    private IEnumerator ShowWinPanel()
    {
        yield return new WaitForSeconds(_delay);        
        GameScreenStateMachine.Instance.SetScreenState(ScreenState.Win);
    }
}
