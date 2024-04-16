using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject rain;

    public GameObject endPanel;

    public Text totalScoreTxt;
    public Text timeTxt;

    float totalTime = 30.0f;

    int totalScore;

    public void Awake()
    {
        Instance = this;
        Time.timeScale = 1.0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeRain", 0f, 1.0f);

    }

    // Update is called once per frame
    void Update()
    {
        if (totalTime > 0f)
        {
            totalTime -= Time.deltaTime;

        }
        else
        {
            endPanel.SetActive(true);
            totalTime = 0f;
            Time.timeScale = 0f;
        }
        timeTxt.text = totalTime.ToString("N2");
    }    
    void MakeRain()
    {
        Instantiate(rain);
    }

    public void AddScore(int score)
    {
        totalScore += score;
        totalScoreTxt.text = totalScore.ToString("N");
    }
}
