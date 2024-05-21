using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
public sealed class Player : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private float _speed = 10;
    private PlayerInput _input;
    private ShopItem _skin;

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
    }

    private void Start()
    {
        _skin = ShopManager.Instance.GetSkin();
        _renderer.sprite = _skin.Sprite;
    }

    private void Update()
    {
        transform.Translate(_input.Direction * _speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _input.Direction = Vector2.zero;
    }
}
