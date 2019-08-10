using System.Collections;
using System.Collections.Generic;
using ARKit.Utils;
using HoloToolkit.Unity.InputModule;
using UnityEngine;
using UnityEngine.Playables;

public class ActionReceiver : MonoBehaviour, IInputHandler, IHoldHandler
{

    public bool m_IsPlaying;
    [SerializeField] private ParticleSystem m_Particle;
    void Start()
    {
        InputManager.Instance.AddGlobalListener(gameObject);
        m_IsPlaying = true;    // tmp
    }


    void Update()
    {
        
    }

    public void OnInputDown(InputEventData eventData)
    {
       if (m_IsPlaying && m_Particle.isStopped)
        {
            m_Particle.Play();
        }
    }

    public void OnInputUp(InputEventData eventData)
    {
        if (m_IsPlaying)
        {
            m_Particle.Stop();
        }
    }

    public void OnHoldStarted(HoldEventData eventData)
    {
         if (m_IsPlaying && m_Particle.isStopped)
        {
            m_Particle.Play();
        }       
    }

    public void OnHoldCompleted(HoldEventData eventData)
    {
         if (m_IsPlaying)
        {
            m_Particle.Stop();
        }
    }

    public void OnHoldCanceled(HoldEventData eventData)
    {
          if (m_IsPlaying)
        {
            m_Particle.Stop();
        }
    }
}
