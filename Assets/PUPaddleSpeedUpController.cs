using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleSpeedUpController : MonoBehaviour
{
    public Collider2D ball;
    public int multiply;
    public PowerUpManager manager;
    private GameObject thepaddle;

    private float PUPSpUTimer;
    private float PUPSpUTimerpluser = 0;

    void Update()
    {
        PUPSpUTimer += PUPSpUTimerpluser;
        if (PUPSpUTimer > 8)
        {
            DeactivatePUPaddleSpeedUp(thepaddle, multiply);
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
            thepaddle = ball.GetComponent<BallController>().bouncer;
            PUPSpUTimerpluser = Time.deltaTime;
            transform.position = new Vector2(10, 10);
        }
    }

    private void DeactivatePUPaddleSpeedUp(GameObject thepaddle, int multiply)
    {
        thepaddle.GetComponent<PaddleController>().speed /= multiply;
    }
}
