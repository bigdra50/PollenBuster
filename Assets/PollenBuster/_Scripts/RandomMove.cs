using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;

public class RandomMove : MonoBehaviour
{

    [SerializeField] private float m_Speed;
    [SerializeField] private float m_RotationSmooth = 1f;
    [SerializeField] private Vector3 m_PlayerPos;

    private Vector3 m_TargetPos;
    private float m_ChangeTargetSqrDistance = 0.5f;
    
    void Start()
    {
        m_TargetPos = GetRandomPos();
    }


    void Update()
    {
        float sqrDistance2Player = Vector3.SqrMagnitude(transform.position - m_PlayerPos);
        if (sqrDistance2Player < 0.3f)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * -2f);
        }
        else
        {
            float sprDistance2Target = Vector3.SqrMagnitude(transform.position - m_TargetPos);
            if (sprDistance2Target < m_ChangeTargetSqrDistance)
            {
                m_TargetPos = GetRandomPos();
            }

            Quaternion targetRotation = Quaternion.LookRotation(m_TargetPos - transform.position);
            transform.rotation =
                Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * m_RotationSmooth);

            transform.Translate(Vector3.forward * m_Speed * Time.deltaTime);

        }
    }

    private Vector3 GetRandomPos()
    {

        float mapSize = 0.5f;
        return new Vector3(Random.Range(-mapSize, mapSize), Random.Range(-0.3f, 0.5f), Random.Range(-mapSize, mapSize));
    }
}
