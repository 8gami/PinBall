using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    // Scoreを標示するテキスト（オブジェクトで指定しFindで参照する場合）
    // public GameObject ScoreText;

    // Scoreを標示するテキスト
    public Text ScoreText; 

    // Score用の変数
    public int score = 0;

    // Use this for initialization
    void Start()
    {
        // シーン中のScoreTextオブジェクトを取得
        // this.ScoreText = GameObject.Find("ScoreText");
    }

    //Scoreの加算処理
    void OnCollisionEnter(Collision collision)
    {
        //ターゲットの種類をタグで判別。
        string tag = collision.gameObject.tag;

        if (tag == "SmallStarTag" || tag == "SmallCloudTag")
        {
            score += 10;
        }
        else if (tag == "LargeStarTag" || tag == "LargeCloudTag")
        {
            score += 20;
        }
        SetScore();
    }

    void SetScore()
    {
        //Score Controller(Script)の中にScore TextをUnity側でもたせてあります。
        ScoreText.GetComponent<Text>().text = string.Format("Score:{0}", score);
    }

    // Update is called once per frame
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        // Text Score_text = ScoreText.GetComponent<Text>();
        // テキストの表示
        // Score_text.text = "Score:" + score;
        // ↓
        // this.ScoreText.GetComponent<Text>().text = "Score:" + score;
    }

}