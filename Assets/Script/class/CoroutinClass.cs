using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinClass : MonoBehaviour
{
    public CharacterSuper thisCharacterScript;
    public CharacterMgr thisMgr;
    static public ConfigClass config;

    // 코루틴으로 사용할 컴포넌트에 스크립트를 설정한다.
    public virtual void SetCharacterScript(CharacterSuper CharacterClass)
    {
        thisCharacterScript = CharacterClass;
    }
    public virtual void SetMgr(CharacterMgr mg) { thisMgr = mg; }

    // 외부에서 실행시키는 기본공격
    public virtual void StartAttackSetting()
    {
        StartCoroutine(SetAttackState());
    }
    // 외부에서 실행시키는 강공격
    public virtual void StartStrongAttckSetting()
    {
        StartCoroutine(SetStrongAttack());
        StartCoroutine(StartStrongCoolTime());
    }
    // 외부에서 실행시키는 특수기
    public virtual void StartSpecialAttack()
    {
        //StartCoroutine(SetSpecialAttack());
        StartCoroutine(StartSpecialCoolTime());
    }
    // 외부에서 실행시키는 재장전
    public virtual void StartReLoad()
    {
        StartCoroutine(SetReLoad());
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
    //강공격
    public virtual IEnumerator SetStrongAttack()
    {
        yield return new WaitForSeconds(thisCharacterScript.CurrentStrongAttack);
        thisCharacterScript.IsStrongAttack = false;
    }
    //특수기
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

    public virtual IEnumerator StartStrongCoolTime()
    {
        while (thisMgr.StrongAttackCoolTime >= 0.0)
        {
            yield return new WaitForSeconds(0.05f);
            thisMgr.StrongAttackCoolTime -= 0.05f;
        }
        thisMgr.StrongAttackCoolTime = 0.0f;
    }
    public virtual IEnumerator StartSpecialCoolTime()
    {
        while (thisMgr.SpecialAttackCoolTime >= 0.0)
        {
            yield return new WaitForSeconds(0.05f);
            thisMgr.SpecialAttackCoolTime -= 0.05f;
        }
        thisMgr.SpecialAttackCoolTime = 0.0f;
    }
}