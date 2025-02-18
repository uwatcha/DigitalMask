using UnityEngine;
using System.Collections;
using System;

#if UNITY_ANDROID && UNITY_2018_3_OR_NEWER
using UnityEngine.Android;
#endif

namespace PermissionAuthorizationTest
{
    public class AudioPermission : MonoBehaviour
    {
        IEnumerator Start()
        {

            yield return Application.RequestUserAuthorization(UserAuthorization.Microphone);
            if (Application.HasUserAuthorization(UserAuthorization.Microphone))
            {
                Debug.Log("Microphone found xoxo");

                foreach (var device in Microphone.devices)
                {
                    Debug.Log("Name: " + device);
                    //_text.text = _text.text + "\n " + device;
                }
            }
            else
            {
                Debug.Log("Microphone not found");
            }
            /*
            foreach (var device in Microphone.devices)
            {
                Debug.Log("Name: " + device);
                //_text.text = _text.text + "\n " + device;
            }
            */

        }


    }
}