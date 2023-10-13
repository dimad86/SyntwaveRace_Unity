using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderChange : MonoBehaviour
{
    [SerializeField] public float _newBoarderRight;
    [SerializeField] public float _newBoarderLeft;
    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.GetComponent<PlayerMove>())
        {
            FindObjectOfType<PlayerMove>().ChangeBoard(_newBoarderRight, _newBoarderLeft);
        }


    }
}
