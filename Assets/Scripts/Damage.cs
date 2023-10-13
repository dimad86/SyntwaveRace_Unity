using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    [SerializeField] public float _damage;
    [SerializeField] ParticleSystem _healthEffect;

    private bool _hasDamagedPlayer = false;




    // Start is called before the first frame update

    public void OnTriggerEnter(Collider other)
    {
        if (!_hasDamagedPlayer && other.attachedRigidbody != null && other.attachedRigidbody.GetComponent<PlayerMove>() != null)
        {
            FindObjectOfType<HealthBar>().TakeDamage(_damage);
            _hasDamagedPlayer = true;
        }

        if (_damage < 0)
        {
            _healthEffect.Play();
        }
            
            

    }
}
