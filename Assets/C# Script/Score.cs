using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   public PlayerController Player;

   public void Update() 
   {
       gameObject.GetComponent<Text>().text = Player.Getscore().ToString();
   }
}
