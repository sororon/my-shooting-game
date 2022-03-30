using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3BarrageController : MonoBehaviour
{
    GameObject player1;
    GameObject player2;
    GameObject player3;
    GameObject enemy1;
    GameObject enemy2;
    GameObject enemy3;
    void Start()
    {
        this.player1 = GameObject.Find("player1");
        this.player2 = GameObject.Find("player2");
        this.player3 = GameObject.Find("player3");
        this.enemy1 = GameObject.Find("enemy1");
        this.enemy2 = GameObject.Find("enemy2");
        this.enemy3 = GameObject.Find("enemy3");
    }

    void Update()
    {
        transform.Translate(0.1f, 0f, 0f);
        if(transform.position.x > 12.0f)
        {
            Destroy(gameObject);
        }

        /* 当たり判定 */
        Vector2 b0 = transform.position; // barrageの中心座標
        Vector2 p1 = this.player1.transform.position;
        Vector2 p2 = this.player2.transform.position;
        Vector2 p3 = this.player3.transform.position;
        Vector2 dir1 = b0 - p1;
        Vector2 dir2 = b0 - p2;
        Vector2 dir3 = b0 - p3;
        float d1 = dir1.magnitude;
        float d2 = dir2.magnitude;
        float d3 = dir3.magnitude;
        float r_b3 = 0.2f;
        float r_p1 = 0.5f;
        float r_p2 = 0.5f;
        float r_p3 = 0.5f;

        if (d1 < r_b3 + r_p1)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreasePlayer1Hp();
            Destroy(gameObject);
        }
        if (d2 < r_b3 + r_p2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreasePlayer2Hp();
            Destroy(gameObject);
        }
        if (d3 < r_b3 + r_p3)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreasePlayer3Hp();
            Destroy(gameObject);
        }
    }
}
