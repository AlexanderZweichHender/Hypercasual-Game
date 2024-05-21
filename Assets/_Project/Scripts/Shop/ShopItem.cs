using UnityEngine;

[CreateAssetMenu(fileName ="Item", menuName ="Configs/Shop Item", order =0)]
public class ShopItem : ScriptableObject
{
    [field:SerializeField] public int Price { get; private set; }
    [field:SerializeField] public Sprite Sprite { get; private set; }
    [field:SerializeField] public bool IsBought { get; set; }
}
