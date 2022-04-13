using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightScript : MonoBehaviour
{
    public GameObject flashlight;
    public bool isOn;

    // Start is called before the first frame update
    void Start()
    {
        flashlight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("f") & isOn == true)
        {
            StartCoroutine(TurnOff());
        }
        
        if(Input.GetKeyDown("f") & isOn == false)
        {
            flashlight.SetActive(true);

            isOn = true;
        }
    }

    IEnumerator TurnOff()
    {
        yield return new WaitForSeconds(0.1f);
        flashlight.SetActive(false);
        isOn = false;
    }
}
