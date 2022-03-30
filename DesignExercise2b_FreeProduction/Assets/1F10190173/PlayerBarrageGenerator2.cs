using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBarrageGenerator2 : MonoBehaviour
{
    public GameObject playerBarragePrefab2;
    float span = 0.1f; // 0.1で連続した弾幕のようになる
    float delta = 0;
    GameObject player2;
    void Start()
    {
        this.player2 = GameObject.Find("player2");
    }

    void Update()
    {
        Vector2 p2 = this.player2.transform.position;
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(playerBarragePrefab2) as GameObject;
            go.transform.position = new Vector2(this.player2.transform.position.x, this.player2.transform.position.y);
        }
    }
}
