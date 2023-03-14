using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
  
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


    public void ChangeSceneIndex(int i)
    {
        SceneManager.LoadScene(i);
    }

}
