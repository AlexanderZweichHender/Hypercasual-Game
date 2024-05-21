using System.Collections.Generic;
using _Project.Services;
using UnityEngine;

public class ShopManager : Singleton<ShopManager>
{
    [SerializeField] private List<ShopItem> _skins;

    public ShopItem GetSkin()
    {
        return _skins[SaveService.Skin];
    }
}
