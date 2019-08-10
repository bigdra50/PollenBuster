using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity;
using UnityEngine;
using UnityEngine.UI;

public class ObjectsSwitcher : MonoBehaviour
{
    [SerializeField] private List<GameObject> m_GameContents = new List<GameObject>();
    [SerializeField] private List<GameObject> m_FinishedContents = new List<GameObject>();
    
    void Start()
    {
        
    }


    void Update()
    {
        
    }
       public void GameActive()
    {
        foreach (var content in m_GameContents)
        {
            if (!content.activeSelf)
            {
                content.SetActive(true);
            }
        }

        foreach (var content in m_FinishedContents)
        {
            if (content.activeSelf)
            {
                content.SetActive(false);
            }
        }
    }

    public void GameFinish()
    {
        foreach (var content in m_GameContents)
        {
            if (content.activeSelf)
            {
                content.SetActive(false);
            }
        }

        foreach (var content in m_FinishedContents)
        {
            if (!content.activeSelf)
            {
                content.SetActive(true);
            }
        }

        
        m_FinishedContents[1].GetComponent<Text>().text = GameManager.m_instance.m_Score.ToString();
    }
}
