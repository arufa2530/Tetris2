using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCORE : MonoBehaviour
{
    //スコアの表示
    public Text scoreText;

    
    //スコア
    private float Score;

    

    // Start is called before the first frame update
    void Start()
    {
        //初期化
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Score.ToString();

        //ポイント100P追加
        if(Input.GetKeyDown(KeyCode.S))
        {
            Score += 100;
        }

        //途中でリセットするためのキー
        if(Input.GetKeyDown(KeyCode.R))
        {
            Score *= 0;
        }

        //フレームごとに1追加する処理
        if (Input.GetKey(KeyCode.N))
        {
            Score += 1f;
        }
    }

    //初期化
    private void Initialize()
    {
        Score = 0;
    }

    //ポイントの処理
    private void Addpoint(int point)
    {
        Score = Score + point;
    }

    

}
