using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullenEmit : MonoBehaviour
{


    [SerializeField] private List<GameObject> m_Trees;
    [SerializeField] private GameObject m_Pullen;
    [SerializeField] private int m_MaxPullen;
    [SerializeField] private Transform m_Parent;
    
    private List<GameObject> m_Pullens = new List<GameObject>();
    private int m_Interval;
    private float m_time = 0;
    
    void Start()
    {
        transform.parent = m_Parent;
        m_Interval = Random.Range(2, 5);
    }


    void Update()
    {
        m_time += Time.deltaTime;
        
        if (m_time >= m_Interval)
        {
            foreach (var tree in m_Trees)
            {
                if (tree != null)
                {
                    var obj = Instantiate(m_Pullen, tree.transform);
                    obj.transform.localScale = new Vector3(20, 20, 20);
                    if (m_Pullens.Count == m_MaxPullen)
                    {
                        Destroy(m_Pullens[0]);
                        m_Pullens[0] = null;
                        m_Pullens.RemoveAt(0);
                    }

                    m_Pullens.Add(obj);
                }
            }
            m_Interval = Random.Range(2, 4);
            m_time = 0f;
        }
    }
    
    
    
}
