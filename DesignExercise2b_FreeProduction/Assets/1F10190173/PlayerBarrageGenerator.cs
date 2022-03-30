using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBarrageGenerator : MonoBehaviour
{
    public GameObject playerBarragePrefab;
    float span = 0.15f; // 0.1で連続した弾幕のようになる
    float delta = 0;
    GameObject player1;
    void Start()
    {
        this.player1 = GameObject.Find("player1");
    }

    void Update()
    {
        Vector2 p1 = this.player1.transform.position;
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(playerBarragePrefab) as GameObject;
            go.transform.position = new Vector2(this.player1.transform.position.x, this.player1.transform.position.y);
        }
    }
}
