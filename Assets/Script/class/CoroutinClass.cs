﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinClass : MonoBehaviour
{
    public CharacterSuper thisCharacterScript;
    static public ConfigClass config;

    // 코루틴으로 사용할 컴포넌트에 스크립트를 설정한다.
    public virtual void SetCharacterScript(CharacterSuper CharacterClass)
    {
        thisCharacterScript = CharacterClass;
    }
    public virtual void StartAttackSetting()
    {
        StartCoroutine(SetAttackState());
    }
    public virtual void StartStrongAttckSetting()
    {
        StartCoroutine(SetStrongAttack());
    }
    public virtual void StartSpecialAttack()
    {
        StartCoroutine(SetSpecialAttack());
    }
    public virtual void StartReLoad()
    {
        StartCoroutine(SetReLoad());
    }
    public virtual void StartRolling()
    {
        StartCoroutine(SetRolling());
    }
    public virtual void StartBuffSetting(float time, CharacterSuper.ItemCode code, float value)
    {
        switch (code)
        {
            case CharacterSuper.ItemCode.Buff_Attack:
                break;
            case CharacterSuper.ItemCode.Buff_Speed:

                break;
            case CharacterSuper.ItemCode.Buff_DotHill:

                break;
            case CharacterSuper.ItemCode.Nuff_Attack:

                break;
            case CharacterSuper.ItemCode.Nuff_Speed:

                break;
            case CharacterSuper.ItemCode.Nuff_DotDemage:

                break;
            default:
                break;
        }
        StartCoroutine(EndBuffItem(time, code, value));
    }
    

    // 시간초 후에 캐릭터를 확인한다.
    public virtual IEnumerator SetAttackState()
    {
        yield return new WaitForSeconds(thisCharacterScript.CurrentAttack);
        thisCharacterScript.IsAttack = false;
    }
    public virtual IEnumerator SetStrongAttack()
    {
        yield return new WaitForSeconds(thisCharacterScript.CurrentStrongAttack);
        thisCharacterScript.IsStrongAttack = false;
    }
    public virtual IEnumerator SetSpecialAttack()
    {
        yield return new WaitForSeconds(thisCharacterScript.CurrentSpecialAttack);
        thisCharacterScript.IsSpecialAttack = false;
    }
    // 리로딩
    public virtual IEnumerator SetReLoad()
    {
        yield return new WaitForSeconds(thisCharacterScript.m_TimeReload);
        thisCharacterScript.SetBullet(thisCharacterScript.m_Max_Bullet);
        thisCharacterScript.IsReLoad = false;
    }
    public virtual IEnumerator SetRolling()//구르기
    {
        if (thisCharacterScript.Is_Rolling == true)
        {
            thisCharacterScript.Player_rb.AddForce(thisCharacterScript.Player_tr.forward * 4000);
            yield return new WaitForSeconds(thisCharacterScript.m_Time_Rolling);
            thisCharacterScript.Is_Rolling = false;
        }
        else
        {

        }
    }
    // 아직은 작업 중.
    public virtual IEnumerator SetWhileBuff(float time)
    {
        yield return new WaitForSeconds(time);
    }

    // 추후 공격력 버프나 뭔가를 만들때 쓰자구.
    public virtual IEnumerator EndBuffItem(float time, CharacterSuper.ItemCode Code, float value)
    {
        yield return new WaitForSeconds(time);
        switch (Code)
        {
            case CharacterSuper.ItemCode.Buff_Attack:
                break;
            case CharacterSuper.ItemCode.Buff_Speed:

                break;
            case CharacterSuper.ItemCode.Buff_DotHill:

                break;
            case CharacterSuper.ItemCode.Nuff_Attack:

                break;
            case CharacterSuper.ItemCode.Nuff_Speed:

                break;
            case CharacterSuper.ItemCode.Nuff_DotDemage:

                break;
            default:
                break;
        }
    }
}