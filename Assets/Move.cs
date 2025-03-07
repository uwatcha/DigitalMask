using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    public float moveDistance = 1f;
    public float scaleFactor = 1f;
    private int px;//position.rotate
    private int fy;//first.position.y
    private int now_state = 0;
    //[SerializeField] string modelname;
    [SerializeField] int position_rotate_x;//position.rotate
    [SerializeField] int position_first_y;//first.position.y


    // Use this for initialization
    void Start()
    {
        //Vector3 Rotation = transform.localEulerAngles;
        //Vector3 Rotation = transform.localEulerAngles;
        //if (modelname == "Mao")
        //{
        //    px = 37;
        //    fy = -35;
        //}
        //else if (modelname == "haru")
        //{
        //    px = 31;
        //    fy = -30;
        //}
        //else if (modelname == "chitose")
        //{
        //    px = 39;
        //    fy = -35;
        //}
        //else if (modelname == "Natori")
        //{
        //    px = 69;
        //    fy = -67;
        //}else if (modelname == "zarashi")
        //{
        //    px = 0;
        //    fy = 0;
        //}

        px = position_rotate_x;
        fy = position_first_y;

        SampleUser Samplescript; //呼ぶスクリプトにあだなつける
        GameObject cube = GameObject.Find("Cube"); //Playerっていうオブジェクトを探す
        Samplescript = cube.GetComponent<SampleUser>(); //付いているスクリプトを取得

        if (/*Samplescript.state_avator == 1*/false) //キャラを選択後、画面に対してキャラが90度回転するので、一旦回転を止める
        {
            transform.Rotate(new Vector3(0, 0, +90));
            transform.position = new Vector3(px, 1, 0);
            now_state = 1;
        }
        else if (/*Samplescript.state_avator == 2*/false)
        {
            transform.Rotate(new Vector3(0, 0, -90));
            transform.position = new Vector3(-px, 1, 0);
            now_state = 2;
        }
        else
        {
            now_state = 0;
        }
    }

    

    

    // Update is called once per frame
    void Update()
    {
        SampleUser Samplescript; //呼ぶスクリプトにあだなつける
        GameObject cube = GameObject.Find("Cube"); //Playerっていうオブジェクトを探す
        Samplescript = cube.GetComponent<SampleUser>(); //付いているスクリプトを取得
        
        // Samplescript.state_avator = now_state;
    }



    public void OnClickUp()
    {
        transform.position += new Vector3(0, moveDistance, 0);
    }

    public void OnClickDown()
    {
        transform.position += new Vector3(0, -moveDistance, 0);
    }
    public void OnClickLeft()
    {
        transform.position += new Vector3(-moveDistance, 0, 0);
    }

    public void OnClickRight()
    {
        transform.position += new Vector3(moveDistance, 0, 0);
    }

    public void OnClickRotate0()
    {
        if (now_state == 1)
        {
            transform.Rotate(new Vector3(0, 0, -90));
            transform.position = new Vector3(0, fy, 0);
            now_state = 0;
        }
        else if (now_state == 2)
        {
            transform.Rotate(new Vector3(0, 0, +90));
            transform.position = new Vector3(0, fy, 0);
            now_state = 0;
        }

    }

    public void OnClickRotate1()
    {
        if(now_state == 0)
        {
            transform.Rotate(new Vector3(0, 0, +90));
            transform.position = new Vector3(px, 1, 0);
            now_state = 1;
        } else if(now_state == 2)
        {
            transform.Rotate(new Vector3(0, 0, +180));
            transform.position = new Vector3(px, 1, 0);
            now_state = 1;
        }
        
    }

    public void OnClickRotate2()
    {
        if (now_state == 0)
        {
            transform.Rotate(new Vector3(0, 0, -90));
            transform.position = new Vector3(-px, 1, 0);
            now_state = 2;
        }
        else if (now_state == 1)
        {
            transform.Rotate(new Vector3(0, 0, -180));
            transform.position = new Vector3(-px, 1, 0);
            now_state = 2;
        }
    }

    public void OnClickBig()
    {
        transform.localScale += new Vector3(scaleFactor, scaleFactor, 0);
        //transform.position += new Vector3(0, -moveDistance, 0);
    }

    public void OnClickSmall()
    {
        transform.localScale += new Vector3(-scaleFactor, -scaleFactor, 0);
        //transform.position += new Vector3(0, -moveDistance, 0);
    }

}

//public float scaleSpeed = 2.0f;  // 拡大縮小の速度

// Update is called once per frame
//void Update()
//{
//    // オブジェクトを拡大縮小する
//    float scaleFactor = Mathf.Sin(Time.time) * scaleSpeed + 1.0f;  // 例：sin関数を使用して拡大縮小する
//    transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
//}