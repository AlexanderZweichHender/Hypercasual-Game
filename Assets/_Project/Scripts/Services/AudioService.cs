using UnityEngine;

namespace _Project.Services
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioService : Singleton<AudioService>
    {
        [SerializeField] private AudioSource _musicSource;
        [SerializeField] private AudioClip _clickSound;
        [SerializeField] private AudioClip _moveSound;
        [SerializeField] private AudioClip _pickUpSound;

        private AudioSource _source;

        protected override void Awake()
        {
            base.Awake();
            _source = GetComponent<AudioSource>();
        }

        private void Start()
        {
            UpdateMusic();
        }

        public void PlayClickSound() => PlaySound(_clickSound);
        public void PlayMoveSound() => PlaySound(_moveSound);
        public void PlayPickUpSound() => PlaySound(_pickUpSound);

        private void PlaySound(AudioClip sound)
        {
            if (SaveService.Sound)
                _source.PlayOneShot(sound);
        }

        public void UpdateMusic()
        {
            if (SaveService.Music)
                _musicSource.volume = 1;
            else
                _musicSource.volume = 0;
        }
    }
}
