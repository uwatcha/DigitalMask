using UnityEngine;
using uLipSync;

using System;
using UnityEngine.UI;
#if UNITY_EDITOR_OSX || UNITY_IOS
using UnityCoreBluetooth;
using Live2D.Cubism.Framework.Expression;
using Live2D.Cubism.Framework.MouthMovement;


public class TransExULipsync : MonoBehaviour
{
    [SerializeField] string modelname;
    private string old_status = "-";
    private string new_status = "-";

    private int M5_old_status = 0;
    private int M5_new_status = 0;

    public int expression;
    private float T = 0f;
    float Timescale = 10f;

    public void OnLipSyncUpdate(LipSyncInfo info)
    {
        Debug.LogFormat(
            $"PHENOME: {info.phoneme}, " +
            $"RAWVOL: {info.rawVolume} " +
            $"VOL: {info.volume} "
            );
        

        new_status = info.phoneme;


        CubismExpressionController expressionscript;
        GameObject model = GameObject.Find(modelname);
        expressionscript = model.GetComponent<CubismExpressionController>();

        // Getting M5 Data
        SampleUser Samplescript; //呼ぶスクリプトにあだなつける
        GameObject cube = GameObject.Find("Cube"); //Playerっていうオブジェクトを探す
        Samplescript = cube.GetComponent<SampleUser>(); //付いているスクリプトを取得
        M5_new_status = Samplescript.status;
        

        //Almost No VOL
        if (info.rawVolume < 0.09) {
            M5_new_status = 20;
            expression = 0 + (int)(M5_new_status / 10) * 10;
            old_status = "-";
            expressionscript.CurrentExpressionIndex = expression;
        }


        //        else if (new_status != old_status && M5_new_status % 10 == 1)
        else if (new_status != old_status)
        {
            M5_new_status = 10;
            if (new_status == "-")
            {
                expression = 0 + (int)(M5_new_status / 10) * 10;
            }
            else if (new_status == "A" || new_status == "O")
            {
                expression = 1 + (int)(M5_new_status / 10) * 10;
            }
            else if (new_status == "I" || new_status == "E")
            {
                expression = 2 + (int)(M5_new_status / 10) * 10;
            }
            else if (new_status == "U" || new_status == "S")
            {
                expression = 3 + (int)(M5_new_status / 10) * 10;
            }

            //Destroy(child.gameObject);
            old_status = new_status;
            //kokodehyoujouhennkou
            expressionscript.CurrentExpressionIndex = expression;

        }
    }  
}
#endif


/*
if (new_status == "-")
{
    expression = 1;
    //expression = neutral;
    //T = Mathf.PI / 2f;
    //mouthscript.MouthOpening = 0;
}
else if (new_status == "A" || new_status == "O")
{
    //T = 0f;
    expression = 11;
    //mouthscript.MouthOpening = 1;
    //expression = 11;
}
else if (new_status == "I" || new_status == "E")
{
    //T = Mathf.PI / 2f;
    expression = 12;
    //mouthscript.MouthOpening = 0;
}
else if (new_status == "U")
{
    //T = 0;
    //expression = 12;
    expression = 16;

}
*/