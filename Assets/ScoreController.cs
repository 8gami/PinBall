using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    // Scoreを標示するテキスト
    public GameObject ScoreText;

    //public Text ScoreText; //Text用変数

    // Score用の変数
    public int score = 0;

    // Use this for initialization
    void Start()
    {
        //シーン中のScoreTextオブジェクトを取得
        this.ScoreText = GameObject.Find("ScoreText");

        //score = 0;
        //SetScore();   //初期スコアを代入して表示

    }

    //Scoreの加算

    void OnCollisionEnter(Collision collision)
    {
        //ターゲットの種類をタグで判別。
        string Tag = collision.gameObject.tag;

        if (tag == "SmallStartag" || tag == "SmallCloudTag")
        {
            score += 10;
        }
        else if (tag == "LargeStarTag" || tag == "LargeCloudTag")
        {
            score += 20;
        }
        //SetScore();
    }

    //void SetScore()
    //{
    //    ScoreText.text = string.Format("Score:{0}", score);
    //}

    // Update is called once per frame
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        // Text Score_text = ScoreText.GetComponent<Text>();
        // テキストの表示
        // Score_text.text = "Score:" + score;

        this.ScoreText.GetComponent<Text>().text = "Score:" + score;
    }

}