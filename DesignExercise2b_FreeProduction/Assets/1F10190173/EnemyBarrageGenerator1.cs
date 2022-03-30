using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBarrageGenerator1 : MonoBehaviour
{
    public GameObject playerBarragePrefab;
    float span = 1f; // 0.1で連続した弾幕のようになる
    float delta = 0;
    GameObject enemy1;
    void Start()
    {
        this.enemy1 = GameObject.Find("enemy1");
    }

    void Update()
    {
        Vector2 e1 = this.enemy1.transform.position;
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(playerBarragePrefab) as GameObject;
            go.transform.position = new Vector2(this.enemy1.transform.position.x, this.enemy1.transform.position.y);
        }
    }
}
