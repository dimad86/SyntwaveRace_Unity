using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] public Image _bar;
    [SerializeField] public float _fill;
    [SerializeField] public GameObject _endMenu;
    [SerializeField] public ParticleSystem _smoke;
    [SerializeField] AudioSource _soundDamage;
    [SerializeField] AudioSource _soundHealth;

    [SerializeField] public GameObject _CameraRotate;
    private CameraRotator rotate;

    private bool _isGameOver = false;


    // Start is called before the first frame update
    void Start()
    {
      // _bar.fillAmount = _fill;
    }

    // Update is called once per frame
    public void TakeDamage(float _damage)
    {
        if (_fill>1)
        {
            _fill = 1;
        }
        
        if (_isGameOver)
            return;

        _fill -= _damage; // Уменьшаем здоровье на указанное количество
        _bar.fillAmount = _fill;
        
        if (_damage>0)
        {
            _soundDamage.Play();
        }
       
        else
        {
            _soundHealth.Play();
        }

        if (_fill <= 0)
        {
           
            _isGameOver = true;
            
            _smoke.Play();

            FindObjectOfType<PlayerBehavior>().StopMovement();
            
            //Time.timeScale = 0f; // Останавливаем проигрывание сцены


            // Здоровье достигло 0 или ниже, вызываем указанный Canvas
            _endMenu.gameObject.SetActive(true);


            rotate = _CameraRotate.GetComponent<CameraRotator>();

            rotate.gameObject.SetActive(true);
        }
    }
}
