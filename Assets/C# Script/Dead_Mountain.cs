using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead_Mountain : MonoBehaviour
{
      public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {

             Debug.Log("Take Damage");
             SceneManager.LoadScene("Mountain");
            
        }

    }

}
