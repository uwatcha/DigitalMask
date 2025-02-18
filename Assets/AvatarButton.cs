using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class AvatarButton : MonoBehaviour
{
    [SerializeField] string scenename;
    //private bool now_state;

    private bool myToggleState;

    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {

        UlipToggleButton Samplescript; //呼ぶスクリプトにあだなつける
        GameObject cube = GameObject.Find("UlipToggle"); //UlipToggleっていうオブジェクトを探す
        Samplescript = cube.GetComponent<UlipToggleButton>(); //UlipToggleに付いているスクリプトを取得
        myToggleState = Samplescript.ulipMode;

        Debug.Log(scenename + "Scene " + myToggleState);  // ログを出力

        if (myToggleState)
        {
            SceneManager.LoadScene(scenename + "UlipScene");
        }
        else
        {
            SceneManager.LoadScene(scenename + "Scene");
        }
    }
}
