using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject rain;
    public Text totalScoreTxt;
    public Text timeText;
    public GameObject endPanel;

    public void Awake()
    {
        Instance = this;
        Time.timeScale = 1.0f;
    }

    void Start()
    {
        InvokeRepeating("MakeRain",0,1f);
    }
    void MakeRain()
    {
        Instantiate(rain);
    }

    int totalScore = 0;
    
    public void AddScore(int score)
    {
        totalScore += score;
        totalScoreTxt.text = totalScore.ToString();
    }

    float totlaTime = 30.0f;
    void Update()
    {
        if(totlaTime >0f)
        {
            totlaTime -= Time.deltaTime;
        }
        else
        {
           
            totlaTime = 0.0f;
            endPanel.SetActive(true);
            Time.timeScale = 0.0f;
        }
        timeText.text = totlaTime.ToString("N2");
    }
}
