using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject Gameobject = null; // Textオブジェクト
    // Start is called before the first frame update
    void Start()
    {

    }
    private int old_status = 0;
    private int new_status = 0;
    private int[] score_array = { 0, 0, 0, 0, 0 };


    // Update is called once per frame
    void Update()
    {
        SampleUser Samplescript; //呼ぶスクリプトにあだなつける
        GameObject cube = GameObject.Find("Cube"); //Playerっていうオブジェクトを探す
        Samplescript = cube.GetComponent<SampleUser>(); //付いているスクリプトを取得
        score_array = Samplescript.ex_array;

        
        //expressionscript.CurrentExpressionIndex = BitConverter.ToInt32(value, 0);



        // オブジェクトからTextコンポーネントを取得
        Text score_text = Gameobject.GetComponent<Text>();
        // テキストの表示を入れ替える

        score_text.text = $"EX: {score_array[0]},{score_array[1]},{score_array[2]},{score_array[3]},{score_array[4]}";



    }
}
