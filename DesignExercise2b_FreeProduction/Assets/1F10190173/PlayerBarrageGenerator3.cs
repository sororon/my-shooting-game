using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBarrageGenerator3 : MonoBehaviour
{
    public GameObject playerBarragePrefab3;
    float span = 0.2f; // 0.1で連続した弾幕のようになる
    float delta = 0;
    GameObject player3;
    void Start()
    {
        this.player3 = GameObject.Find("player3");
    }

    void Update()
    {
        Vector2 p3 = this.player3.transform.position;
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(playerBarragePrefab3) as GameObject;
            go.transform.position = new Vector2(this.player3.transform.position.x, this.player3.transform.position.y);
        }
    }
}
