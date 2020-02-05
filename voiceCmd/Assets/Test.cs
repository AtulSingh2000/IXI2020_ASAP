using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {
    Button btn;
	void Start () {
        
        btn = GameObject.Find("Button").GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
	}
	
    void TaskOnClick()
    {   
        AndroidJavaClass pluginClass = new AndroidJavaClass("com.plugin.speech.pluginlibrary.TestPlugin");
        Debug.Log("Call 1 Started");

        pluginClass.CallStatic("setReturnObject", "Capsule");
        Debug.Log("Return Object Set");

        pluginClass.CallStatic("setLanguage", "en_US");
        Debug.Log("Language Set");

        pluginClass.CallStatic("setMaxResults", 3);
        Debug.Log("Max Results Set");

        pluginClass.CallStatic("changeQuestion", "Hello, How can I help you???");
        Debug.Log("Question Set");


        Debug.Log("Call 2 Started");

        pluginClass.CallStatic("promptSpeechInput");

        Debug.Log("Call End");
    }

	void Update () {
		
	}
}
