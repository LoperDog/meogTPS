﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManduAnimation : AnimationSuper
{
    ManduCharacter CharacterScript;
    public override void PlayAttack()
    {
        m_Anim.SetBool("Is_Attack", m_Char_State.GetIsAttack());
    }
    public override void SetChar(CharacterSuper CharScript)
    {
        base.SetChar(CharScript);
        CharacterScript = (ManduCharacter)CharScript;
    }
    //강공격
    public void SetStrongAttackReady()
    {

    }
    public void SetStrongAttackDash()
    {

    }
    public void SetStrongAttackEnd()
    {

    }
    //특수기
    public void SetSpecialAttackReady()
    {

    }
    public void SetSpecialAttack_ing()
    {

    }
    public void SetSpecialAttackEnd()
    {

    }
}
