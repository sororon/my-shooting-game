using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBarrageGenerator3 : MonoBehaviour
{
    public GameObject playerBarragePrefab;
    float span = 1f; // 0.1で連続した弾幕のようになる
    float delta = 0;
    GameObject enemy3;
    void Start()
    {
        this.enemy3 = GameObject.Find("enemy3");
    }

    void Update()
    {
        Vector2 e3 = this.enemy3.transform.position;
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(playerBarragePrefab) as GameObject;
            go.transform.position = new Vector2(this.enemy3.transform.position.x, this.enemy3.transform.position.y);
        }
    }
}
