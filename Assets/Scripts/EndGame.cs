using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour

{
    [SerializeField] public GameObject _final;
    [SerializeField] public GameObject _CameraRotate;
    
    

    private CameraRotator rotate;
        // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.GetComponent<PlayerMove>())
        {
            FindObjectOfType<PlayerBehavior>().StopMovement();
            _final.gameObject.SetActive(true);

            rotate = _CameraRotate.GetComponent<CameraRotator>();


            rotate.gameObject.SetActive(true);
            

        }
    }
}
