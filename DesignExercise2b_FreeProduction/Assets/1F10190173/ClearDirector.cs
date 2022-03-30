using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour
{
    GameObject scoreText;
    GameObject director;

    void Start() 
    {
        this.director = GameObject.Find("GameDirector");
        this.scoreText = GameObject.Find("ScorePoint");
    }
    void Update()
    {
        // スコアの表示
        this.scoreText.GetComponent<Text>().text = "Score: " + GameDirector.getScore().ToString("F1");
        // ゲームを続ける
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Let's go!");
            GameDirector.resetScore();
            SceneManager.LoadScene("GameScene");
        }
    }
}
