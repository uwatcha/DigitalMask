using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeExpressionList : MonoBehaviour
{


    //Dropdownを格納する変数
    //[SerializeField] private Dropdown dropdown;
    //Cubeを格納する変数
    //[SerializeField] private GameObject cube;

    
    //int number = TransEx.neutral;

    //private Dropdown _dropdown;

    void Start()
    {
        SampleUser Samplescript; //呼ぶスクリプトにあだなつける
        GameObject cube = GameObject.Find("Cube"); //Playerっていうオブジェクトを探す
        Samplescript = cube.GetComponent<SampleUser>(); //付いているスクリプトを取得
        Samplescript.neutral = 1;
        Samplescript.smile = 2;
    }

    [SerializeField] string targetExpression;

    public void OnValueChanged(int value)//値更新後の処理
    {
        Debug.Log($"{value}番目の要素が選ばれた");
        SampleUser Samplescript; //呼ぶスクリプトにあだなつける
        GameObject cube = GameObject.Find("Cube"); //Playerっていうオブジェクトを探す
        Samplescript = cube.GetComponent<SampleUser>(); //付いているスクリプトを取得

        
        if (targetExpression == "neutral")
        {
            Samplescript.neutral = value+1;
        }
        else if (targetExpression == "smile") {
            Samplescript.smile = value+1;
        }


    }



    // Update is called once per frame
    void Update()
    {
        

        ////DropdownのValueが0のとき（赤が選択されているとき）
        //if (dropdown.value == 0)
        //{
        //    TransEx.neutral = 1;
        //}
        ////DropdownのValueが1のとき（青が選択されているとき）
        //else if (dropdown.value == 1)
        //{
        //    TransEx.neutral = 3;
        //}
        ////DropdownのValueが2のとき（黄が選択されているとき）
        //else if (dropdown.value == 2)
        //{
        // //   cube.GetComponent<Renderer>().material.color = Color.yellow;
        //}
        ////DropdownのValueが3のとき（白が選択されているとき）
        //else if (dropdown.value == 3)
        //{
        // //   cube.GetComponent<Renderer>().material.color = Color.white;
        //}
        ////DropdownのValueが4のとき（黒が選択されているとき）
        //else if (dropdown.value == 4)
        //{
        // //   cube.GetComponent<Renderer>().material.color = Color.black;
        //}
    }
}