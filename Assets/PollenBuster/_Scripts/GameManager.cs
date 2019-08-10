using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private ActionReceiver m_ActReceiver;

    
    // ----Singleton------
    public static GameManager m_instance;


    public static GameManager Instance
    {
        get
        {
            if (m_instance == null)
            {
                GameObject obj = new GameObject("GameManager");
                m_instance = obj.AddComponent<GameManager>();
            }
            return m_instance;
        }
    }
    
    // -------------------


    public int m_Score;
    void Start()
    {
        m_Score = 0;
    }


    void Update()
    {
        
    }


    public void GameActive()
    {
        
    }

}
