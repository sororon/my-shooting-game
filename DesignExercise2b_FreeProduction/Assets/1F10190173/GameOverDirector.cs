using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverDirector : MonoBehaviour
{
    GameObject director;
    void Start() 
    {
        this.director = GameObject.Find("GameDirector");
    }
    void Update()
    {
        // コンティニュー
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Let's go!");
            GameDirector.resetScore();
            SceneManager.LoadScene("GameScene");
        }
    }
}
