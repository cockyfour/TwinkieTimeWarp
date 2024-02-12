using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switchy : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {

        SceneManager.LoadScene(3);


    }
    
   
}