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
    [SerializeField] private SampleUser avator;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private int old_status = 0;
    private int new_status = 0;
    public int expression;
    private float T = 0f;
    float Timescale = 10f;



    [SerializeField] CubismExpressionController cubismExpressionController;
    [SerializeField] private CubismMouthController cubismMouthController;

    

    void Update()
    {
        new_status = avator.status;
        //cubismExpressionController.CurrentExpressionIndex = BitConverter.ToInt32(value, 0);
        if (new_status != old_status)
        {
            if (new_status >= 10)
            {

                if (new_status == 10)
                {
                    expression = avator.neutral;
                    //expression = neutral;
                    //T = Mathf.PI / 2f;
                    //cubismExpressionController.MouthOpening = 0;
                }
                else if (new_status == 11)
                {
                    //T = 0f;
                    expression = (avator.neutral + 10);
                    //cubismExpressionController.MouthOpening = 1;
                    //expression = 11;
                }
                else if (new_status == 20)
                {
                    //T = Mathf.PI / 2f;
                    expression = avator.smile;
                    //cubismExpressionController.MouthOpening = 0;
                }
                else if (new_status == 21)
                {
                    //T = 0;
                    //expression = 12;
                    expression = (avator.smile + 10);

                }
                

            }
            
            //Destroy(child.gameObject);
            old_status = new_status;
            //kokodehyoujouhennkou
            cubismExpressionController.CurrentExpressionIndex = expression;
            
        }

        //T=audioValume
        //if (new_status % 10 == 1)
        //{
        //    float preT = T;
        //    T += (Time.deltaTime * Timescale);
        //    cubismExpressionController.MouthOpening += Mathf.Abs(Mathf.Sin(T-preT));
        //    cubismExpressionController.MouthOpening = Mathf.Clamp(cubismExpressionController.MouthOpening, 0.0f, 1.0f);
        //    //cubismExpressionController.MouthOpening = Mathf.Abs(Mathf.Sin(1));
        //}
        //else
        //{
        //    cubismExpressionController.MouthOpening = 0;
        //    //float preT = T;
        //    //T += (Time.deltaTime * Timescale);
        //    //cubismExpressionController.MouthOpening -= (Mathf.Sin(-T + preT));
        //    //cubismExpressionController.MouthOpening = Mathf.Clamp(cubismExpressionController.MouthOpening, 0.0f, 1.0f);
        //}


    }
}
#endif