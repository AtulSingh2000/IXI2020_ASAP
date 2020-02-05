using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disclaimer : MonoBehaviour
{
    private bool disclaimerBool = true;
    public GameObject disclaimerWindow;
    // Start is called before the first frame update
    void Start()
    {
        //disclaimerBool = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!(disclaimerBool))
        {
            disclaimerWindow.SetActive(false);
        }
    }

    public void setDisclaimerBool(bool setB)
    {
        disclaimerBool = setB;
    }
}
