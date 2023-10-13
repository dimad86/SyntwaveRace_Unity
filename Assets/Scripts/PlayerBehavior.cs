using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] PlayerMove _playerMove;

    
    // Start is called before the first frame update
    void Start()
    {
        _playerMove.enabled = false; 

        }

  public void StartGame()
    {
        _playerMove.enabled = true;
       

    }

    public void StopMovement()
    {

        _playerMove.enabled = false;
        // Дополнительный код, который может быть необходим для остановки движения, например, установка скорости в ноль.
    }

}
