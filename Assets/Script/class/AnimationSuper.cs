using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSuper : MonoBehaviour
{
    protected Animator m_Anim;
    protected CharacterSuper m_Char_State;
        
    public AnimationSuper()
    {
        m_Anim = GetComponent<Animator>();
    }
    // 이동 애니매이션 정의
    protected virtual void PlayMove()
    {

    }
    // 공격 애니매이션 정의
    protected virtual void PlayAttack()
    {

    }
    // 재장전 애니매이션 정의
    protected virtual void PlayReload()
    {

    }
    ~AnimationSuper()
    {
        m_Anim = null;
    }
}
