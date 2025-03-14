using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using UnityEngine.UI;
#if UNITY_EDITOR_OSX || UNITY_IOS || UNITY_STANDALONE_WIN
// using UnityCoreBluetooth;


public class Write : MonoBehaviour
{

    public SampleUser Samplescript; //呼ぶスクリプトにあだなつける
    public GameObject cube = GameObject.Find("Cube"); //Playerっていうオブジェクトを探す
    
    // Start is called before the first frame update
    void Start()
    {

    }
    

   

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnclickSoundUp()
    {
        Samplescript = cube.GetComponent<SampleUser>(); //付いているスクリプトを取得
        Samplescript.SoundUp();
    }

    public void OnclickSoundDown()
    {
        Samplescript = cube.GetComponent<SampleUser>(); //付いているスクリプトを取得
        Samplescript.SoundDown();
    }

    public void OnclickSensorUp()
    {
        Samplescript = cube.GetComponent<SampleUser>(); //付いているスクリプトを取得
        Samplescript.SensorUp();
    }

    public void OnclickSensorDown()
    {
        Samplescript = cube.GetComponent<SampleUser>(); //付いているスクリプトを取得
        Samplescript.SensorDown();
    }

}
#endif