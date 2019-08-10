using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text m_Text;
    public int m_score;
    void Start()
    {
        m_score = GameManager.Instance.m_Score;
        m_Text = GetComponent<Text>();
    }


    void Update()
    {
        m_score = GameManager.Instance.m_Score;
        m_Text.text = m_score.ToString();
    }

       
}
