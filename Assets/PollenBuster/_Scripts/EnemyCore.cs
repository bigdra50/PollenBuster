using System.Collections;
using System.Collections.Generic;
using UniRx.Diagnostics;
using UnityEngine;

public class EnemyCore : MonoBehaviour
{


    [SerializeField] AudioClip m_Audio;
    [SerializeField] private GameObject m_DeathEffect;
    
    void Start()
    {
    }


    void Update()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        Death();
    }

    void Death()
    {
        GameManager.Instance.m_Score += 10;
        AudioSource.PlayClipAtPoint(m_Audio, transform.position);
        var eff = Instantiate(m_DeathEffect, transform.position, Quaternion.identity);
        
        Destroy(gameObject);
    }
}
