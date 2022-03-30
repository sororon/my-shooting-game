using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBarrageGenerator2 : MonoBehaviour
{
    public GameObject playerBarragePrefab;
    float span = 1f; // 0.1で連続した弾幕のようになる
    float delta = 0;
    GameObject enemy2;
    void Start()
    {
        this.enemy2 = GameObject.Find("enemy2");
    }

    void Update()
    {
        Vector2 e2 = this.enemy2.transform.position;
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(playerBarragePrefab) as GameObject;
            go.transform.position = new Vector2(this.enemy2.transform.position.x, this.enemy2.transform.position.y);
        }
    }
}
