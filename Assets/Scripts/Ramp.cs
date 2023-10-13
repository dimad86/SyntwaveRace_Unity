using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramp : MonoBehaviour
{
    [SerializeField] Transform _target;

    [SerializeField] public float _newBoarderRight;
    [SerializeField] public float _newBoarderLeft;
    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.GetComponent<PlayerMove>())
        {
            _newBoarderLeft = _target.position.x;
            _newBoarderRight = _target.position.x;

            
            FindObjectOfType<PlayerMove>().ChangeBoard(_newBoarderRight, _newBoarderLeft);
        }


    }
}
