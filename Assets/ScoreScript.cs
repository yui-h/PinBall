using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    private GameObject scoreText; //Text用変数
    private int score = 0; //スコア計算用変数

	// Use this for initialization
    void Start () {
        //シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
	}

	//SmallStarとの衝突+5,LargeStarとの衝突+10, SmallCloudとの衝突+15, LargeCloudとの衝突+20
	public void OnCollisionEnter(Collision collision)
	{
        string yourTag = collision.gameObject.tag;

        if (yourTag == "SmallStarTag")
        {
            score += 5;
        }
        else if (yourTag == "LargeStarTag")
        {
            score += 10;
        }
        else if (yourTag == "SmallCloudTag")
        {
            score += 15;
        }
        else if (yourTag == "LargeCloudTag")
        {
            score += 20;
        }

        this.scoreText.GetComponent<Text>().text = "Score: " + score;
	}


	// Update is called once per frame
	void Update () {
		
	}
}
