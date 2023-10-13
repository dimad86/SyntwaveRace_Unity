using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    public float _speedRotate;
    [SerializeField] Transform _target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _target.position;
        transform.Rotate(0, _speedRotate * Time.deltaTime, 0);
    }
}
