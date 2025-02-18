using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManu : MonoBehaviour
{
    [SerializeField] string scenename;

    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        Debug.Log(scenename + "Scene");  // ログを出力
        SceneManager.LoadScene(scenename + "Scene");
    }
}