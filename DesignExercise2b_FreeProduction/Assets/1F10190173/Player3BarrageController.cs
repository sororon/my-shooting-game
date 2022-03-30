using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3BarrageController : MonoBehaviour
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
        Vector2 p1 = this.player1.transform.position;
        Vector2 p2 = this.player2.transform.position;
        Vector2 p3 = this.player3.transform.position;
        transform.Translate(-0.1f, 0f, 0f);
        if(transform.position.x < -12.0f)
        {
            Destroy(gameObject);
        }

        /* 当たり判定 */
        Vector2 b0 = transform.position; // barrageの中心座標
        Vector2 e1 = this.enemy1.transform.position;
        Vector2 e2 = this.enemy2.transform.position;
        Vector2 e3 = this.enemy3.transform.position;
        Vector2 dir1 = b0 - e1;
        Vector2 dir2 = b0 - e2;
        Vector2 dir3 = b0 - e3;
        float d1 = dir1.magnitude;
        float d2 = dir2.magnitude;
        float d3 = dir3.magnitude;
        float r_b3 = 0.8f;
        float r_e1 = 0.5f;
        float r_e2 = 0.5f;
        float r_e3 = 0.5f;

        if (d1 < r_b3 + r_e1)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseEnemy1Hp();
            Destroy(gameObject);
        }
        if (d2 < r_b3 + r_e2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseEnemy2Hp();
            Destroy(gameObject);
        }
        if (d3 < r_b3 + r_e3)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseEnemy3Hp();
            Destroy(gameObject);
        }
    }
}
