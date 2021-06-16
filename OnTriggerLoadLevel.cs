using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Play.Publisher.Editor;
using UnityEngine;

public class OnTriggerLoadLevel : MonoBehaviour
{
    public string levelToLoad;
    public GameObject guiObject;
 
    void Start()
    {
        guiObject.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            guiObject.SetActive(true);
            if (guiObject.activeInHierarchy == true && Input.GetButtonDown("Use"))
            {
                Application.LoadLevel(levelToLoad);
            }
        }
    }

    void OnTriggerExit()
    {
        guiObject.SetActive(false);
    }
}
