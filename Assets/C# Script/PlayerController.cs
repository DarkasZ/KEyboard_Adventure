using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int Score = 0;
    private Rigidbody2D rigidbody2D;
    public Animator animation;
    public Button Nextbutton;
    public float Movespeed = 5;
    public float jumpForce = 5;

     public void addScore()
    {
       Score = Score +1 ;
    }

    public int Getscore()
    {
       return Score;
    }
    


    private void Start() 
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        Nextbutton.gameObject.SetActive(false);
    }

    private void Update() 
    {
        var Movement = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(Movement,0,0) * Time.deltaTime * Movespeed;

        animation.SetFloat("speed", Mathf.Abs(Movement));
    

        if(!Mathf.Approximately(0,Movement))
        {
            transform.rotation = Movement < 0 ? Quaternion.Euler(0,180,0) : Quaternion.identity; 
        }

        if(Input.GetButtonDown("Jump") && Mathf.Abs(rigidbody2D.velocity.y) < 0.001f)
        {
            rigidbody2D.AddForce(new Vector2(0,jumpForce),ForceMode2D.Impulse);
        }
    }
    public void ShowBtn()
    {
        Nextbutton.gameObject.SetActive(true);
    }
  

}
