using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIElementController : MonoBehaviour
{
    public GameObject[] UIElements;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UIElementSwitcher(GameObject arg)
    {
        foreach(GameObject obj in UIElements)
        {
            if(obj != arg)
            {
                obj.SetActive(false);
            }
            else
            {
                obj.SetActive(true);
            }
        }
    }
    public void SwitchSCene(string arg)
    {
        SceneManager.LoadScene(arg);
    }
}
