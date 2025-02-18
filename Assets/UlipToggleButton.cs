using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class UlipToggleButton : MonoBehaviour
{
    public bool ulipMode = true;
    public Toggle myToggle;
    //public static Toggle myToggle;
    //[SerializeField] Toggle myToggle; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ulipMode = myToggle.isOn;        
    }

    public void UpdateUlipMode()
    {
        //ulipMode = !ulipMode;
        //myToggle.isOn
        //GetComponent<ToggleTest>().;
        ulipMode = myToggle.isOn;
        Debug.Log("Press the toggle " + ulipMode);
        //Debug.Log(ulipMode);
    }
}
