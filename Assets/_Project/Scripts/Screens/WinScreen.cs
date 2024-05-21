using _Project.Services;
using System.Collections;
using UnityEngine;
using TMPro;

public class WinScreen : BaseScreen
{
    [SerializeField] private float _delay = 2f;
    [SerializeField] private TMP_Text _rewardText;

    private void Start()
    {
        _rewardText.text = SaveService.Reward.ToString();
        StartCoroutine(LoadMenu());
    }

    private IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(_delay);
        SceneLoader.LoadMenu();
    }
}
