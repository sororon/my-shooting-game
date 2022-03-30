using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Rigidbody2D rigid2D;
    GameObject player1;
    GameObject player2;
    GameObject player3;
    GameObject enemy1;
    GameObject enemy2;
    GameObject enemy3;

    void Start()
    {
        //this.rigid2D = GetComponent<Rigidbody2D>();
        this.player1 = GameObject.Find("player1");
        this.player2 = GameObject.Find("player2");
        this.player3 = GameObject.Find("player3");
        this.enemy1 = GameObject.Find("enemy1");
        this.enemy2 = GameObject.Find("enemy2");
        this.enemy3 = GameObject.Find("enemy3");
    }

    void Update()
    {
        GameObject director = GameObject.Find("GameDirector");
        // Behavior of player1
        int hp_p1 = director.GetComponent<GameDirector>().myPlayer1.hp;
        float sp_p1 = director.GetComponent<GameDirector>().myPlayer1.speed;
        if (hp_p1 != 0)
        {
            if(Input.GetKey(KeyCode.Z))
            {
                if(Input.GetKeyDown(KeyCode.UpArrow) && this.player1.transform.position.y < 4.5f)
                {
                    this.player1.transform.Translate(0,sp_p1,0);
                    //this.rigid2D.AddForce(transform.up * 1000);
                }
                if(Input.GetKeyDown(KeyCode.DownArrow) && this.player1.transform.position.y > -4.5f)
                {
                    this.player1.transform.Translate(0,-1*sp_p1,0);
                }
                if(Input.GetKeyDown(KeyCode.LeftArrow) && this.player1.transform.position.x > -11.5f)
                {
                    this.player1.transform.Translate(-1*sp_p1,0,0);
                }
                if(Input.GetKeyDown(KeyCode.RightArrow) && this.player1.transform.position.x < 11.5f)
                {
                    this.player1.transform.Translate(sp_p1,0,0);
                }
            }
        }
        else
        {
            this.player1.transform.Translate(-20,-20,0);
        }
        // Behavior of player2
        int hp_p2 = director.GetComponent<GameDirector>().myPlayer2.hp;
        float sp_p2 = director.GetComponent<GameDirector>().myPlayer2.speed;
        if (hp_p2 != 0)
        {
            if(Input.GetKey(KeyCode.X))
            {
                if(Input.GetKeyDown(KeyCode.UpArrow) && this.player2.transform.position.y < 4.5f)
                {
                    this.player2.transform.Translate(0,sp_p2,0);
                }
                if(Input.GetKeyDown(KeyCode.DownArrow) && this.player2.transform.position.y > -4.5f)
                {
                    this.player2.transform.Translate(0,-1*sp_p2,0);
                }
                if(Input.GetKeyDown(KeyCode.LeftArrow) && this.player2.transform.position.x > -11.5f)
                {
                    this.player2.transform.Translate(-1*sp_p2,0,0);
                }
                if(Input.GetKeyDown(KeyCode.RightArrow) && this.player2.transform.position.x < 11.5f)
                {
                    this.player2.transform.Translate(sp_p2,0,0);
                }
            }
        }
        else
        {
            this.player2.transform.Translate(-20,-20,0);
        }
        // Behavior of player3
        int hp_p3 = director.GetComponent<GameDirector>().myPlayer3.hp;
        float sp_p3 = director.GetComponent<GameDirector>().myPlayer3.speed;
        if (hp_p3 != 0)
        {
            if(Input.GetKey(KeyCode.C))
            {
                if(Input.GetKeyDown(KeyCode.UpArrow) && this.player3.transform.position.y < 4.5f)
                {
                    this.player3.transform.Translate(0,sp_p3,0);
                }
                if(Input.GetKeyDown(KeyCode.DownArrow) && this.player3.transform.position.y > -4.5f)
                {
                    this.player3.transform.Translate(0,-1*sp_p3,0);
                }
                if(Input.GetKeyDown(KeyCode.LeftArrow) && this.player3.transform.position.x > -11.5f)
                {
                    this.player3.transform.Translate(-1*sp_p3,0,0);
                }
                if(Input.GetKeyDown(KeyCode.RightArrow) && this.player3.transform.position.x < 11.5f)
                {
                    this.player3.transform.Translate(sp_p3,0,0);
                }
            }
        }
        else
        {
            this.player3.transform.Translate(-20,-20,0);
        }

        // Behavior of enemy1
        int di_e1 = Random.Range(-1, 3); // Decide for distance
        int hp_e1 = director.GetComponent<GameDirector>().myEnemy1.hp;
        float sp_e1 = director.GetComponent<GameDirector>().myEnemy1.speed;
        if (hp_e1 != 0)
        {
            switch (di_e1)
            {
                case 2: // up
                    if (this.enemy1.transform.position.y < 4.5)
                    {
                        this.enemy1.transform.Translate(0,sp_e1,0);
                    }
                    break;
                case 1: // down
                    if (this.enemy1.transform.position.y > -4.5)
                    {
                        this.enemy1.transform.Translate(0,-1*sp_e1,0);
                    }
                    break;
                case 0: // left
                    if (this.enemy1.transform.position.x > -11.5)
                    {
                        this.enemy1.transform.Translate(-1*sp_e1,0,0);
                    }
                    break;
                case -1: // right
                    if (this.enemy1.transform.position.x < 5.5)
                    {
                        this.enemy1.transform.Translate(sp_e1,0,0);
                    }
                    break;
                default:
                    break;
            }
        }
        else
        {
            this.enemy1.transform.Translate(20,20,0);
        }
        // Behavior of enemy2
        int di_e2 = Random.Range(-1, 3);
        int hp_e2 = director.GetComponent<GameDirector>().myEnemy2.hp;
        float sp_e2 = director.GetComponent<GameDirector>().myEnemy2.speed;
        if (hp_e2 != 0)
        {
            switch (di_e2)
            {
                case 2: // up
                    if (this.enemy2.transform.position.y < 4.5)
                    {
                        this.enemy2.transform.Translate(0,sp_e2,0);
                    }
                    break;
                case 1: // down
                    if (this.enemy2.transform.position.y > -4.5)
                    {
                        this.enemy2.transform.Translate(0,-1*sp_e2,0);
                    }
                    break;
                case 0: // left
                    if (this.enemy2.transform.position.x > -11.5)
                    {
                        this.enemy2.transform.Translate(-1*sp_e2,0,0);
                    }
                    break;
                case -1: // right
                    if (this.enemy2.transform.position.x < 5.5)
                    {
                        this.enemy2.transform.Translate(sp_e2,0,0);
                    }
                    break;
                default:
                    break;
            }
        }
        else
        {
            this.enemy2.transform.Translate(20,20,0);
        }
        // Behavior of enemy3
        int di_e3 = Random.Range(-1, 3);
        int hp_e3 = director.GetComponent<GameDirector>().myEnemy3.hp;
        float sp_e3 = director.GetComponent<GameDirector>().myEnemy3.speed;
        if (hp_e3 != 0)
        {
            switch (di_e3)
            {
                case 2: // up
                    if (this.enemy3.transform.position.y < 4.5)
                    {
                        this.enemy3.transform.Translate(0,sp_e3,0);
                    }
                    break;
                case 1: // down
                    if (this.enemy3.transform.position.y > -4.5)
                    {
                        this.enemy3.transform.Translate(0,-1*sp_e3,0);
                    }
                    break;
                case 0: // left
                    if (this.enemy3.transform.position.x > -11.5)
                    {
                        this.enemy3.transform.Translate(-1*sp_e3,0,0);
                    }
                    break;
                case -1: // right
                    if (this.enemy3.transform.position.x < 5.5)
                    {
                        this.enemy3.transform.Translate(sp_e3,0,0);
                    }
                    break;
                default:
                    break;
            }
        }
        else //画面外に移動させることでHP0を表現
        {
            this.enemy3.transform.Translate(20,20,0);
        }
    }
}
