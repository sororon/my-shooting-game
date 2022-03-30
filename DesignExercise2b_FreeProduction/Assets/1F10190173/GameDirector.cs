using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject hpGaugePlayer1;
    GameObject hpGaugePlayer2;
    GameObject hpGaugePlayer3;
    GameObject hpGaugeEnemy1;
    GameObject hpGaugeEnemy2;
    GameObject hpGaugeEnemy3;
    GameObject enemy1;
    GameObject enemy2;
    GameObject enemy3;
    GameObject player1;
    GameObject player2;
    GameObject player3;
    GameObject timerText;
    GameObject scoreText;
    float time = 60.0f; // 制限時間
    public static float score = 0f; // スコア
    public static float getScore()
    {
        if (score <= 0)
        {
            score = 0;
        }
        if (score > 10000)
        {
            score = 9999.9f;
        }
        return score;
    }

    public static float resetScore()
    {   
        score = 0;
        return score;
    }
    public class Status
    {
        public int hp = 1;
        public float speed = 0.1f;
    }

    public Status myPlayer1 = new Status();
    public Status myPlayer2 = new Status();
    public Status myPlayer3 = new Status();
    public Status myEnemy1 = new Status();
    public Status myEnemy2 = new Status();
    public Status myEnemy3 = new Status();

    void Start()
    {
        this.hpGaugePlayer1 = GameObject.Find("hpGaugePlayer1");
        this.hpGaugePlayer2 = GameObject.Find("hpGaugePlayer2");
        this.hpGaugePlayer3 = GameObject.Find("hpGaugePlayer3");
        this.hpGaugeEnemy1 = GameObject.Find("hpGaugeEnemy1");
        this.hpGaugeEnemy2 = GameObject.Find("hpGaugeEnemy2");
        this.hpGaugeEnemy3 = GameObject.Find("hpGaugeEnemy3");
        this.enemy1 = GameObject.Find("enemy1");
        this.enemy2 = GameObject.Find("enemy2");
        this.enemy3 = GameObject.Find("enemy3");
        this.timerText = GameObject.Find("Time");
        scoreText = GameObject.Find("Score");
        myPlayer1.speed = 0.1f;
        myPlayer2.speed = 0.1f;
        myPlayer3.speed = 0.1f;
        myEnemy1.speed = 0.1f;
        myEnemy2.speed = 0.2f;
        myEnemy3.speed = 0.15f;
    }

    public void DecreaseEnemy1Hp()
    {
        this.hpGaugeEnemy1.GetComponent<Image>().fillAmount -= 0.01f; //-=0.1f
        if (this.hpGaugeEnemy1.GetComponent<Image>().fillAmount == 0)
        {
            myEnemy1.hp = 0;
            //Destroy(enemy1);
        }
        score += 10 + myEnemy1.speed;
    }

    public void DecreaseEnemy2Hp()
    {
        this.hpGaugeEnemy2.GetComponent<Image>().fillAmount -= 0.01f;
        if (this.hpGaugeEnemy2.GetComponent<Image>().fillAmount == 0)
        {
            myEnemy2.hp = 0;
            //Destroy(enemy2);
        }
        score += 10 + myEnemy2.speed;
    }

    public void DecreaseEnemy3Hp()
    {
        this.hpGaugeEnemy3.GetComponent<Image>().fillAmount -= 0.01f;
        if (this.hpGaugeEnemy3.GetComponent<Image>().fillAmount == 0)
        {
            myEnemy3.hp = 0;
            //Destroy(enemy3);
        }
        score += 10 + myEnemy3.speed;
    }

    public void DecreasePlayer1Hp()
    {
        this.hpGaugePlayer1.GetComponent<Image>().fillAmount -= 0.3f;
        if (this.hpGaugePlayer1.GetComponent<Image>().fillAmount == 0)
        {
            myPlayer1.hp = 0;
            //Destroy(player1);
            score -= 500;
        }
    }

    public void DecreasePlayer2Hp()
    {
        this.hpGaugePlayer2.GetComponent<Image>().fillAmount -= 0.3f;
        if (this.hpGaugePlayer2.GetComponent<Image>().fillAmount == 0)
        {
            myPlayer2.hp = 0;
            //Destroy(player2);
            score -= 500;
        }
    }

    public void DecreasePlayer3Hp()
    {
        this.hpGaugePlayer3.GetComponent<Image>().fillAmount -= 0.3f;
        if (this.hpGaugePlayer3.GetComponent<Image>().fillAmount == 0)
        {
            myPlayer3.hp = 0;
            //Destroy(player3);
            score -= 500;
        }
    }

    void Update()
    {
        // カウントダウン
        this.time -= Time.deltaTime;
        this.timerText.GetComponent<Text>().text = this.time.ToString("F1");
        // スコア表示
        scoreText.GetComponent<Text>().text = score.ToString("F1");
        // ゲームクリア
        if (myEnemy1.hp == 0 && myEnemy2.hp == 0 && myEnemy3.hp == 0)
        {
            Debug.Log("Game clear!");
            score += 100f * time; // 残り時間が多いほど高得点
            //Debug.Log(score);
            SceneManager.LoadScene("ClearScene");
        }
        // ゲームオーバー
        if (myPlayer1.hp == 0 && myPlayer2.hp == 0 && myPlayer3.hp == 0)
        {
            Debug.Log("Game over.");
            SceneManager.LoadScene("GameOverScene");
        }
        if (this.time <= 0)
        {
            Debug.Log("Time over.");
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
