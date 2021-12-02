using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireDMG : MonoBehaviour
{
 
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {

             Debug.Log("Take Damage");
             SceneManager.LoadScene("Castle");
            
        }

    }
}
