using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using UnityEngine.UI;
#if UNITY_EDITOR_OSX || UNITY_IOS || UNITY_STANDALONE_WIN
// using UnityCoreBluetooth;
using Live2D.Cubism.Framework.Expression;
using Live2D.Cubism.Framework.MouthMovement;


public class TransEx : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private int old_status = 0;
    private int new_status = 0;
    public int expression;
    private float T = 0f;
    float Timescale = 10f;



    [SerializeField] string modelname;

    

    // Update is called once per frame
    void Update()
    {
        SampleUser Samplescript; //呼ぶスクリプトにあだなつける
        GameObject cube = GameObject.Find("Cube"); //Playerっていうオブジェクトを探す
        Samplescript = cube.GetComponent<SampleUser>(); //付いているスクリプトを取得
        new_status = Samplescript.status;

        CubismExpressionController expressionscript;
        GameObject model = GameObject.Find(modelname);
        expressionscript = model.GetComponent<CubismExpressionController>();

        // Progress time.
        
        CubismMouthController mouthscript;
        mouthscript = model.GetComponent<CubismMouthController>();


        //expressionscript.CurrentExpressionIndex = BitConverter.ToInt32(value, 0);

        


        if (new_status != old_status)
        {
            if (new_status >= 10)
            {

                if (new_status == 10)
                {
                    expression = Samplescript.neutral;
                    //expression = neutral;
                    //T = Mathf.PI / 2f;
                    //mouthscript.MouthOpening = 0;
                }
                else if (new_status == 11)
                {
                    //T = 0f;
                    expression = (Samplescript.neutral + 10);
                    //mouthscript.MouthOpening = 1;
                    //expression = 11;
                }
                else if (new_status == 20)
                {
                    //T = Mathf.PI / 2f;
                    expression = Samplescript.smile;
                    //mouthscript.MouthOpening = 0;
                }
                else if (new_status == 21)
                {
                    //T = 0;
                    //expression = 12;
                    expression = (Samplescript.smile + 10);

                }
                

            }
            
            //Destroy(child.gameObject);
            old_status = new_status;
            //kokodehyoujouhennkou
            expressionscript.CurrentExpressionIndex = expression;
            
        }

        //T=audioValume
        //if (new_status % 10 == 1)
        //{
        //    float preT = T;
        //    T += (Time.deltaTime * Timescale);
        //    mouthscript.MouthOpening += Mathf.Abs(Mathf.Sin(T-preT));
        //    mouthscript.MouthOpening = Mathf.Clamp(mouthscript.MouthOpening, 0.0f, 1.0f);
        //    //mouthscript.MouthOpening = Mathf.Abs(Mathf.Sin(1));
        //}
        //else
        //{
        //    mouthscript.MouthOpening = 0;
        //    //float preT = T;
        //    //T += (Time.deltaTime * Timescale);
        //    //mouthscript.MouthOpening -= (Mathf.Sin(-T + preT));
        //    //mouthscript.MouthOpening = Mathf.Clamp(mouthscript.MouthOpening, 0.0f, 1.0f);
        //}


    }
}
#endif