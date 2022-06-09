using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text UILeftScore;
    public Text UIRightScore;

    public ScoreManager manager;
    
    void Start()
    {    
    }

    void Update()
    {
        UILeftScore.text = manager.leftScore.ToString();
        UIRightScore.text = manager.rightScore.ToString();
    }
}
