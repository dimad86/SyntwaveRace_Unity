using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DonDestroySound : MonoBehaviour
{
    // Start is called before the first frame update

    public static DonDestroySound instance;

       void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }


        else
        {

            instance = this;

            DontDestroyOnLoad(gameObject);
        }

    }

     void Update()
    {
        if (SceneManager.GetActiveScene().name != "Options" && SceneManager.GetActiveScene().name != "MainMenu")
        {
            Destroy(gameObject);
        }
    }





}
