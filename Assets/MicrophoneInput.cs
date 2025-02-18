using UnityEngine;

public class MicrophoneInput : MonoBehaviour
{
    AudioClip micInput;
    int sampleRate;

    void Start()
    {
        // マイクデバイスの確認
        string[] devices = Microphone.devices;
        if (devices.Length == 0)
        {
            Debug.LogError("No microphone devices found.");
            return;
        }

        // マイク入力の開始
        micInput = Microphone.Start(devices[0], true, 1, AudioSettings.outputSampleRate);
        sampleRate = AudioSettings.outputSampleRate;
    }

    void Update()
    {
        // サンプルの処理
        if (micInput != null)
        {
            int position = Microphone.GetPosition(null);
            float[] samples = new float[micInput.samples * micInput.channels];
            micInput.GetData(samples, 0);

            // ここでサンプルを処理する（例: 可視化、音声解析など）
        }
    }
}
