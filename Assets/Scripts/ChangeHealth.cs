using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHealth : MonoBehaviour
{
    [SerializeField] public float _damage;
    [SerializeField] public int _cost;
    [SerializeField] ParticleSystem _healthEffect;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.GetComponent<PlayerMove>())
        {
            if (CoinManager._coinCount >= _cost)
            {
                FindObjectOfType<HealthBar>().TakeDamage(_damage);
                FindObjectOfType<CoinManager>().ChangeCoin(_cost);
                _healthEffect.Play();
            }
        }
    }
}
