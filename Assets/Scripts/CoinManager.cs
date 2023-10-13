using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{

    [SerializeField] public static int _coinCount;
    [SerializeField] TextMeshProUGUI _coinView;
    [SerializeField] AudioSource _soundCoin;
    // Start is called before the first frame update
    
        public void AddOne()
    {
        _coinCount += 1;
        _coinView.text = _coinCount.ToString();
        _soundCoin.Play();

    }

    public void ChangeCoin(int _cost)
        {
        _coinCount = _coinCount - _cost;
        _coinView.text = _coinCount.ToString();

    }


}

