using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleSpeedUpController : MonoBehaviour
{
    public Collider2D ball;
    public int multiply;
    public PowerUpManager manager;

    private float PUPSpUTimer;
    private float PUPSpUTimerpluser = 0;

    void Update()
    {
        PUPSpUTimer += PUPSpUTimerpluser;
        if (PUPSpUTimer > 5)
        {
            PUPSpUTimer -= PUPSpUTimer;
            PUPSpUTimerpluser = 0;
            manager.RemovePowerUp(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            ball.GetComponent<BallController>().ActivatePUPaddleSpeedUp(multiply);
            PUPSpUTimerpluser = Time.deltaTime;
            transform.position = new Vector2(10, 10);
        }
    }
}
