using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartDirector : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Well come to the Lunatic World!");
    }
    void Update()
    {
        // ゲームスタート
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
