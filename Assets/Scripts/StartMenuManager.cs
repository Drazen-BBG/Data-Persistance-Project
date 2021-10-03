using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StartMenuManager : MonoBehaviour
{
    public static StartMenuManager Instance;

    private string playerName; 

    

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

  

    public void GetName(string name)
    {
        playerName = name;

        Debug.Log(Instance.playerName);
    }
}
