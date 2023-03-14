using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{

    public GameObject[] menuObjects;
    

    public void ChangeSceneIndex(int i)
    {
        SceneManager.LoadScene(i);
    }

    public void TurnOffPanel(int i)
    {
        menuObjects[i].gameObject.SetActive(false);
    }

    public void TurnOnPanel(int i)
    {
        menuObjects[(int)i].gameObject.SetActive(true);
    }

}
