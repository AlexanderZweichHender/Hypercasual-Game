using _Project.Services;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ShopElement : MonoBehaviour
{
    [SerializeField] private ShopElement _secondElement;
    [SerializeField] private _Project.Constants.Skin _skin;
    [SerializeField] private ScoreCounter _scoreCounter;
    public ShopItem _item;
    public Button _buyButton;

    [SerializeField] private TMP_Text _price;

    [SerializeField] private Sprite _activeSprite;
    [SerializeField] private Sprite _notActiveSprite;


    private void OnEnable()
    {
        _scoreCounter.ShowScore();

        if (_item.IsBought)
        {
            _price.text = 0.ToString();
        }

        _buyButton.onClick.AddListener(() =>
        {
            Buy();
        });
    }

    private void Buy()
    {
        if (_item.IsBought)
        {
            _buyButton.image.sprite = _activeSprite;

            switch (_skin)
            {
                case _Project.Constants.Skin.Panda:
                    SaveService.Skin = 1;
                    break;
                case _Project.Constants.Skin.Tiger:
                    SaveService.Skin = 2;
                    break;
            }

            _secondElement._buyButton.image.sprite = _notActiveSprite;
        }
        else if (SaveService.Money >= _item.Price)
        {
            SaveService.Money -= _item.Price;
            _scoreCounter.ShowScore();

            _item.IsBought = true;

            switch(_skin)
            {
                case _Project.Constants.Skin.Panda:
                    SaveService.Skin = 1;
                    break;
                case _Project.Constants.Skin.Tiger:
                    SaveService.Skin = 2;
                    break;
                        
            }
        }
    }
}
