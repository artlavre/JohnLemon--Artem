using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject pressKey;
    public GameObject menu;
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            pressKey.SetActive(false);
            menu.SetActive(true);
        }
    }

    
}
