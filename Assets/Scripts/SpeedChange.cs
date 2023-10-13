using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChange : MonoBehaviour
{

    [SerializeField] public int _speedChange;
    [SerializeField] public int _cost;
    [SerializeField] GameObject _RedLigh1;
    [SerializeField] GameObject _RedLigh2;

    

    private ParticleSystem _particleSystem1;
    private ParticleSystem _particleSystem2;


    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.GetComponent<PlayerMove>())
        {
            if (CoinManager._coinCount >= _cost)
            {

                FindObjectOfType<PlayerMove>().ChangeSpeed(_speedChange);
                FindObjectOfType<CoinManager>().ChangeCoin(_cost);

               
                //_RedLigh1.SetActive(true);
                //_RedLigh2.SetActive(true);

                _particleSystem1=_RedLigh1.GetComponent<ParticleSystem>();
                
                _particleSystem1.Play();

                _particleSystem2 = _RedLigh2.GetComponent<ParticleSystem>();

                _particleSystem2.Play();


            }


                }
    }
}
