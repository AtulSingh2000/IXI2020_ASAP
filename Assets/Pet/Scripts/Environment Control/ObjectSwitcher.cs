using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSwitcher : MonoBehaviour
{
    public GameObject[] objectHolder;
    public GameObject[] canvasElements;

    private GameObject sceneController;
    // Start is called before the first frame update
    void Start()
    {
        sceneController = GameObject.Find("MenuScene Controller");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectTarget(string arg)
    {
        foreach(GameObject obj in objectHolder)
        {
            if (obj.name != arg)
            {
                obj.SetActive(false);
            }
            else
            {
                obj.SetActive(true);
            }
        }
        foreach (GameObject obj in canvasElements)
        {
            if (obj.name != arg)
            {
                obj.SetActive(false);
            }
            else
            {
                obj.SetActive(true);
            }
        }
        sceneController.GetComponent<GlobalSettingsControl>().prefabTitle = arg;
        sceneController.GetComponent<GlobalSettingsControl>().SaveState();
    }
}
