using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleSizeUpController : MonoBehaviour
{
    public Collider2D ball;
    public float multiply;
    public PowerUpManager manager;

    private float PUPSiUTimer;
    private float PUPSiUTimerpluser = 0;

    void Update()
    {
        PUPSiUTimer += PUPSiUTimerpluser;
        if (PUPSiUTimer > 5)
        {
            PUPSiUTimer -= PUPSiUTimer;
            PUPSiUTimerpluser = 0;
            manager.RemovePowerUp(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            ball.GetComponent<BallController>().ActivatePUPaddleSizeUp(multiply);
            ball.GetComponent<BallController>().TellTheBouncer();
            PUPSiUTimerpluser = Time.deltaTime;
            transform.position = new Vector2(10, 10);
        }
    }
}
