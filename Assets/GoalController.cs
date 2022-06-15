using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider2D ball;
    public bool isLeftGoal;
    public bool isOutArea;
    public ScoreManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (isLeftGoal)
            {
                manager.AddRightScore(1);
            }
            else 
            {
                if (isOutArea)
                {
                    manager.OutBall();
                }
                else
                {
                    manager.AddLeftScore(1);
                }
            }
        }

    }
}
