using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletar : MonoBehaviour
{
    private SpriteRenderer sr;
    private CircleCollider2D circle;
    public int scoreC;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            sr.enabled = false;
            circle.enabled = false;
            
            GameController.instance.totalScoreC += scoreC;
            GameController.instance.UpdateScoreTextC();

            Destroy(gameObject, 0.25f);
        }
    }
    
    
}
