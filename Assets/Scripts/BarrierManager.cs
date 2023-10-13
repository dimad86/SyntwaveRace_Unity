using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BarrierManager : MonoBehaviour
{
    [SerializeField] public static int _barrierCount;
    [SerializeField] TextMeshProUGUI _barrierView;
    // Start is called before the first frame update

    public void AddOne()
    {
        _barrierCount += 1;
        _barrierView.text = _barrierCount.ToString();

    }
}
