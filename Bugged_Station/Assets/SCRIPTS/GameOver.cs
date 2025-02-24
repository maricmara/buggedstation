using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string lvlName;

   void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.tag == "Player"){
            SceneManager.LoadScene(lvlName);
        }
   }
}
