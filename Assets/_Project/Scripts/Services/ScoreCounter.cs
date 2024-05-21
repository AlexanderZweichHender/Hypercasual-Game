using _Project.Services;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;

    private void Start() => ShowScore();
    private void OnEnable() => ShowScore();


    public void ShowScore()
    {
        _scoreText.text = SaveService.Money.ToString();
    }
}
