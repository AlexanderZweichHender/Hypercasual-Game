using UnityEngine;

namespace _Project.Services
{
    public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (!_instance == null)
                {
                    _instance = FindObjectOfType<T>();

                    if (!_instance)
                    {
                        Debug.LogError("Singleton of type " + typeof(T) + " not found in the scene.");
                    }
                }

                return _instance;
            }
        }

        protected virtual void Awake()
        {
            if (_instance == null)
            {
                _instance = this as T;
            }
            else
            {
                Destroy(gameObject);
            }
        }

    }
}
