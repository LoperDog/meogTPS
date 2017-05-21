using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSuper : MonoBehaviour
{
    protected Animator m_Anim;
    
    public AnimationSuper()
    {
        m_Anim = GetComponent<Animator>();
    }

    ~AnimationSuper()
    {
        m_Anim = null;
    }
}
