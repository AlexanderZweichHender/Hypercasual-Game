using System.Collections;
using UnityEngine;
using System;
using TMPro;

public class Timer : MonoBehaviour
{
    public static Action OnComplete;

    [SerializeField] private TMP_Text _timer;
    [SerializeField] private int _time = 30;

    private void OnEnable()
    {
        StartCoroutine(Tick());
    }

    private void OnDisable()
    {
        StopCoroutine(Tick());
    }

    private IEnumerator Tick()
    {
        while(_time > 0)
        {
            _time--;
            _timer.text = _time.ToString();
            yield return new WaitForSeconds(1f);
        }
        
        OnComplete?.Invoke();
    }    
}
