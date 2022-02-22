using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickLevel : MonoBehaviour
{
    public GameObject levels;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            levels.SetActive(false);
        }
    }
    public void LevelsHide()
    {
        levels.SetActive(false);
    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene(3);
    }
}
