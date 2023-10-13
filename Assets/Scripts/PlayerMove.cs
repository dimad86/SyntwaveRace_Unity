using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] public float _speedStart;
    [SerializeField] float _borderLeft;
    [SerializeField] float _borderRight;
    [SerializeField] TextMeshProUGUI _speedView;
    [SerializeField] public GameObject _endMenu;
    [SerializeField] AudioSource _soundSpeed;

    public static float _speed;

    private float _fixedDeltaTime;


    private Vector3 _newPosition;
    private Quaternion _rotation;
    

    private float _crashCooldawn = 0.5f;

   

    // Start is called before the first frame update
    void Start()
    {
        _rotation = transform.rotation;

        _speed = _speedStart;

       // _fixedDeltaTime = Time.fixedDeltaTime;

    }

    internal void ChangeBoard(object newBoarderRight, object newBoarderLeft)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {

        

        transform.position += transform.forward *Time.deltaTime * _speed;

        _speedView.text = (_speed*10).ToString();

       _crashCooldawn -= Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {


            //_newPosition = transform.position + new Vector3(-0.05f, 0, 0);
            _newPosition = transform.position + new Vector3(-1*_speed*Time.deltaTime, 0, 0);
            _newPosition.x = Mathf.Clamp(_newPosition.x,_borderLeft,_borderRight);
            transform.position = _newPosition;

            if (_rotation != transform.rotation)
            {
                if (_crashCooldawn <= 0)
                {
                    transform.rotation = _rotation;
                    _crashCooldawn = 2;
                }
            }
        }

       if (Input.GetKey(KeyCode.D))
        {
            // _newPosition = transform.position + new Vector3(0.05f, 0, 0);
            _newPosition = transform.position + new Vector3(_speed * Time.deltaTime, 0, 0);
            _newPosition.x = Mathf.Clamp(_newPosition.x,_borderLeft,_borderRight);
            transform.position = _newPosition;

            if (_rotation != transform.rotation)
            {
                if (_crashCooldawn <= 0)
                {
                    transform.rotation = _rotation;
                }
            }
        }

           }

   
    public void ChangeSpeed(int _speedChange)
    {
        _speed += _speedChange;
        _speedView.text = _speed.ToString();

        if (_speedChange>0)
        {
            _soundSpeed.Play();
        }

        if (_speed<8)
        {
            _speedView.color = Color.green;
        }
        
        if (_speed >= 8 && _speed < 12)
        {

            _speedView.color = Color.yellow;
        }


        if (_speed >= 12)
        {
            _speedView.color = Color.red;


        }
        
           
                   
        if (_speed<=0)
        {
            FindObjectOfType<PlayerBehavior>().StopMovement();
            _endMenu.gameObject.SetActive(true);
        }


    }

    public void ChangeBoard(float _newBorderRight, float _newBorderLeft)
    {
        _borderLeft = _newBorderLeft;
        _borderRight = _newBorderRight;

    }
}
