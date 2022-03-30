using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartController : MonoBehaviour
{
    GameObject player1;
    GameObject player2;
    GameObject player3;

    void Start()
    {
        this.player1 = GameObject.Find("player1");
        this.player2 = GameObject.Find("player2");
        this.player3 = GameObject.Find("player3");
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Z))
        {
            if(Input.GetKeyDown(KeyCode.UpArrow) && this.player1.transform.position.y < 4.5f)
            {
                this.player1.transform.Translate(0,0.1f,0);
            }
            if(Input.GetKeyDown(KeyCode.DownArrow) && this.player1.transform.position.y > -4.5f)
            {
                this.player1.transform.Translate(0,-1*0.1f,0);
            }
            if(Input.GetKeyDown(KeyCode.LeftArrow) && this.player1.transform.position.x > -11.5f)
            {
                this.player1.transform.Translate(-1*0.1f,0,0);
            }
            if(Input.GetKeyDown(KeyCode.RightArrow) && this.player1.transform.position.x < 11.5f)
            {
                this.player1.transform.Translate(0.1f,0,0);
            }
        }
        if(Input.GetKey(KeyCode.X))
        {
            if(Input.GetKeyDown(KeyCode.UpArrow) && this.player2.transform.position.y < 4.5f)
            {
                this.player2.transform.Translate(0,0.1f,0);
            }
            if(Input.GetKeyDown(KeyCode.DownArrow) && this.player2.transform.position.y > -4.5f)
            {
                this.player2.transform.Translate(0,-1*0.1f,0);
            }
            if(Input.GetKeyDown(KeyCode.LeftArrow) && this.player2.transform.position.x > -11.5f)
            {
                this.player2.transform.Translate(-1*0.1f,0,0);
            }
            if(Input.GetKeyDown(KeyCode.RightArrow) && this.player2.transform.position.x < 11.5f)
            {
                this.player2.transform.Translate(0.1f,0,0);
            }
        }
        if(Input.GetKey(KeyCode.C))
        {
            if(Input.GetKeyDown(KeyCode.UpArrow) && this.player3.transform.position.y < 4.5f)
            {
                this.player3.transform.Translate(0,0.1f,0);
            }
            if(Input.GetKeyDown(KeyCode.DownArrow) && this.player3.transform.position.y > -4.5f)
            {
                this.player3.transform.Translate(0,-1*0.1f,0);
            }
            if(Input.GetKeyDown(KeyCode.LeftArrow) && this.player3.transform.position.x > -11.5f)
            {
                this.player3.transform.Translate(-1*0.1f,0,0);
            }
            if(Input.GetKeyDown(KeyCode.RightArrow) && this.player3.transform.position.x < 11.5f)
            {
                this.player3.transform.Translate(0.1f,0,0);
            }
        }
    }
}
