using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    [SerializeField] public float _damage;
    [SerializeField] public int _cost;
    [SerializeField] GameObject _BarrierDestroy;
    [SerializeField] public int _speedChange;

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.GetComponent<PlayerMove>())
        {
           if (PlayerMove._speed < _cost)
            {
                FindObjectOfType<HealthBar>().TakeDamage(_damage);
            }

            FindObjectOfType<BarrierManager>().AddOne();
            Destroy(gameObject);
            //_BarrierDestroy.SetActive(true);

            Instantiate(_BarrierDestroy, transform.position, transform.rotation);

            FindObjectOfType<PlayerMove>().ChangeSpeed(_speedChange);
        }


    }
        
  
}
