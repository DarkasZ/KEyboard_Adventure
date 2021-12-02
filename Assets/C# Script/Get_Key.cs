using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Get_Key : MonoBehaviour
{
    public Button CloseBtn;
    

       public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
           StartCoroutine(Collected(collision.gameObject));
           
        }
    }


    IEnumerator Collected(GameObject gameObj)
    {
        
            gameObject.GetComponent<AudioSource>().Play();

            Debug.Log("Collected!!");
            PlayerController player = gameObj.GetComponent<PlayerController>();
            gameObject.GetComponent<BoxCollider2D>().enabled = false;

            player.addScore();
            player.ShowBtn();
            

            while( gameObject.GetComponent<AudioSource>().isPlaying)
            {
                yield return new WaitForSeconds(0.1f);
            }
            
            gameObject.SetActive(false);
            CloseBtn.gameObject.SetActive(false);

            
            

            yield return null;
    }
}
