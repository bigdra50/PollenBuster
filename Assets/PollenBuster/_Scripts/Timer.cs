using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    [SerializeField] private ObjectsSwitcher m_objSwitch;
    public float m_TotalTime;
    private int m_second;
    private Text m_Text;
    private float m_TimeBuff;
    
    void Start()
    {
        m_Text = GetComponent<Text>();
        
    }


    void Update()
    {

        m_TotalTime -= Time.deltaTime;
        m_second = (int)m_TotalTime;
        m_Text.text = m_second.ToString();
        if (m_second == 0)
        {
            m_objSwitch.GameFinish();
        }
        
    }
}
