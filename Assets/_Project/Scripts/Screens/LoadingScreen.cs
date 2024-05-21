using System.Collections;
using UnityEngine;
using _Project.Services;

public class LoadingScreen : BaseScreen
{
    [SerializeField] private float _loadingTime = 3.0f;

    private void Start()
    {
        Debug.Log(SaveService.Money);
        StartCoroutine(LoadMenu());
    }

    private IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(_loadingTime);
        ScreenStateMachine.Instance.SetScreen(ScreenState.Menu);
    }

}
