using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public int totalScoreM;
    public Text ScoreTextM;
    public int totalScoreC;
    public Text ScoreTextC;

    public static GameController instance;
    
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScoreTextM()
    {
        ScoreTextM.text = totalScoreM.ToString();
        

    }
    public void UpdateScoreTextC(){
        ScoreTextC.text = totalScoreC.ToString();
    }
}
