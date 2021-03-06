using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class CoinController : MonoBehaviour
{
    public GameObject CoinPrefab;
    public GameObject CoinAudioManager;
    private const int Duration = 3;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnDisable()
    {
        CoinAudioManager.GetComponent<AudioSource>().Play();
        Observable.Timer(TimeSpan.FromSeconds(Duration))
            .Subscribe(_ =>
            {
                CoinPrefab.SetActive(true);
            });
    }
}
