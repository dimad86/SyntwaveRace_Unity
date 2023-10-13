using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float _rotateSpeed;
    //[SerializeField] AudioSource _sound;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, _rotateSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
       // _sound.Play();

        FindObjectOfType<CoinManager>().AddOne();
        Destroy(gameObject);
        
       
    }
}
