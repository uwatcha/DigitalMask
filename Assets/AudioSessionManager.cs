using UnityEngine;

public class AudioSessionManager : MonoBehaviour
{
    void Start()
    {
        // iOSプラットフォームでのみマイクの利用を試みる
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            string[] devices = Microphone.devices;

            if (devices.Length > 0)
            {
                string selectedDevice = devices[0]; // AirPodsが接続されていると仮定
                AudioClip audioClip = Microphone.Start(selectedDevice, true, 10, 44100);

                // 録音中の処理などを行う
            }
            else
            {
                Debug.LogError("No microphone devices found.");
            }
        }
        else
        {
            Debug.LogError("This code is intended for iOS platform.");
        }
    }
}