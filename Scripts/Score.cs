using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text ScoreText;
    public CarControl arabaHareket;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = arabaHareket.puan.ToString();
    }
}
