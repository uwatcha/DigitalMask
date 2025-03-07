using System;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR_OSX || UNITY_IOS
// using UnityCoreBluetooth;
using System.Collections;
using System.Collections.Generic;
using Live2D.Cubism.Framework.Expression;

public class SampleUser : MonoBehaviour
{

    // private CoreBluetoothManager manager;
    // private CoreBluetoothPeripheral savedPeripheral;
    private string currentState;  // state を保存するメンバ変数
    // private CoreBluetoothCharacteristic characteristic;
    public GameObject score_object = null; // Textオブジェクト
    private int counter;
    public int neutral;
    public int smile;

    // Use this for initialization
    // void Start()
    // {

    //     DontDestroyOnLoad(this.gameObject);//オブジェクトを消去しない.
    //     manager = CoreBluetoothManager.Shared;

    //     manager.OnUpdateState((string state) =>
    //     {
    //         currentState = state;
    //         Debug.Log("state: " + state);
    //         if (state != "poweredOn") return;
    //         manager.StartScan();
            
    //     });

    //     manager.OnDiscoverPeripheral((CoreBluetoothPeripheral peripheral) =>
    //     {
    //         if (peripheral.name != "")
    //             Debug.Log("discover peripheral name: " + peripheral.name); 
    //         if ((peripheral.name != "Daydream controller") && (peripheral.name != "M5Stack") && (peripheral.name != "M5StickC")) return;

    //         savedPeripheral = peripheral;
    //         manager.StopScan();
    //         //manager.ConnectToPeripheral(peripheral);
    //         manager.ConnectToPeripheral(savedPeripheral);
    //     });

    //     manager.OnConnectPeripheral((CoreBluetoothPeripheral peripheral) =>
    //     {
    //         Debug.Log("connected peripheral name: " + peripheral.name);
    //         peripheral.discoverServices();
    //     });

    //     manager.OnDiscoverService((CoreBluetoothService service) =>
    //     {
    //         Debug.Log("discover service uuid: " + service.uuid);
    //         if (service.uuid != "FE55") return;
    //         service.discoverCharacteristics();
    //     });


    //     manager.OnDiscoverCharacteristic((CoreBluetoothCharacteristic characteristic) =>
    //     {
    //         this.characteristic = characteristic;
    //         string uuid = characteristic.Uuid;
    //         string[] usage = characteristic.Propertis;
    //         Debug.Log("discover characteristic uuid: " + uuid + ", usage: " + usage);
    //         for (int i = 0; i < usage.Length; i++)
    //         {
    //             Debug.Log("discover characteristic uuid: " + uuid + ", usage: " + usage[i]);
    //             if (usage[i] == "notify")
    //                 characteristic.SetNotifyValue(true);
    //         }
    //     });

    //     manager.OnUpdateValue((CoreBluetoothCharacteristic characteristic, byte[] data) =>
    //     {
    //         this.value = data;
    //         this.flag = true;
    //     });

    //     manager.Start();
    // }

    private bool flag = false;
    private byte[] value = new byte[20];
    public int status = 0;
    public int state_avator = 0;
    private float vy = 0.0f;
    public int[] ex_array = { 0, 0, 0, 0, 0};
    private int ex_num = 0;



    // Update is called once per frame
    void Update()
    {
        //private int hp;

        //if (this.transform.position.y < 0)
        //{
        //    vy = 0.0f;
            //transform.position = new Vector3(0, 0, 0);
        //}
        //else
        //{
        //    vy -= 0.006f;
            //transform.position += new Vector3(0, vy, 0);
        //}
        //this.transform.Rotate(2, -3, 4);
        if (flag == false) return;
        flag = false;

        //signal
        status = BitConverter.ToInt32(value, 0);
        

        //Debug.Log(flag);
        //Debug.Log("state: " + state);

        // オブジェクトからTextコンポーネントを取得
        //Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える

        //score_text.text = $"EX: {ex_array[0]},{ex_array[1]},{ex_array[2]},{ex_array[3]},{ex_array[4]}";

        //vy += 0.1f;
        //transform.position += new Vector3(0, vy, 0);
        //ReconnectToDevice();
    }

    // void OnDestroy()
    // {
    //     manager.Stop();
    // }

    

    public void Write()
    {
        // characteristic.Write(System.Text.Encoding.UTF8.GetBytes($"{counter}"));
        counter+= 10;
        Debug.Log(counter);
    }



    public void SoundDown()
    {
        counter = 0;
        // characteristic.Write(System.Text.Encoding.UTF8.GetBytes($"{counter}"));
        
        Debug.Log(counter);
    }

    public void SoundUp()
    {
        counter = 1;
        // characteristic.Write(System.Text.Encoding.UTF8.GetBytes($"{counter}"));
        Debug.Log(counter);
    }

    public void SensorDown()
    {
        counter = 5;
        // characteristic.Write(System.Text.Encoding.UTF8.GetBytes($"{counter}"));
        Debug.Log(counter);
    }

    public void SensorUp()
    {
        counter = 6;
        // characteristic.Write(System.Text.Encoding.UTF8.GetBytes($"{counter}"));
        Debug.Log(counter);
    }

    public void SoundZero()
    {
        counter = 4;
        // characteristic.Write(System.Text.Encoding.UTF8.GetBytes($"{counter}"));
        Debug.Log(counter);
    }

    public void SensorMax()
    {
        counter = 3;
        // characteristic.Write(System.Text.Encoding.UTF8.GetBytes($"{counter}"));
        Debug.Log(counter);
    }

    public void SensorMin()
    {
        counter = 2;
        // characteristic.Write(System.Text.Encoding.UTF8.GetBytes($"{counter}"));
        Debug.Log(counter);
    }

    // public void ReconnectToDevice()
    // {
    //     Debug.Log("ReconnectToDevice called with state: " + currentState);

    //     if (savedPeripheral != null)
    //     {
    //         // 保存されたデバイス情報を使用して再接続、機能していません
    //         manager.ConnectToPeripheral(savedPeripheral);
    //     }
    //     else
    //     {
    //         Debug.LogWarning("No saved device information available for reconnection.");
    //     }
    // }
}
#endif
