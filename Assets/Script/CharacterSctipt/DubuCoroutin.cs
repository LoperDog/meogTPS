using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DubuCoroutin : CoroutinClass
{
    public DubuCharacter DubuChar;
    public override void SetCharacterScript(CharacterSuper CharacterClass)
    {
        base.SetCharacterScript(CharacterClass);
        DubuChar = (DubuCharacter)CharacterClass;
    }

    public override void StartStrongAttckSetting()
    {
        if(config == null)
        {
            config = new ConfigClass();
        }
        thisMgr.StrongAttackCoolTime = config.StatusConfigs["Dubu"]["StrongAttackSpeed"];
        base.StartStrongAttckSetting();
    }
    public override void StartSpecialAttackSetting()
    {

        if (config == null)
        {
            config = new ConfigClass();
        }
        thisMgr.SpecialAttackCoolTime = config.StatusConfigs["Dubu"]["SpecialAttackSpeed"];
        base.StartSpecialAttackSetting();
    }
    //강공격
    public override IEnumerator SetStrongAttack()
    {
        if(config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = false;
        StartCoroutine(SetStrongAttackReady());
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["StrongAttackSpeed"]);
        thisCharacterScript.IsStrongAttack = false;
    }
    public IEnumerator SetStrongAttackReady()
    {
        if(config == null)
        {
            config = new ConfigClass();
        }
        DubuChar.StrongAttackReady();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["StongAttackReady"]);
        StartCoroutine(SetStrongAttackDash());
    }
    public IEnumerator SetStrongAttackDash()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        DubuChar.StrongAttackDash();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["StongAttackTime"]);
        thisMgr.m_StrongAttack.ReSetAttack();
        StartCoroutine(SetStrongAttackEnd());
        thisCharacterScript.CanControll = true;
    }
    public IEnumerator SetStrongAttackEnd()
    {
        if(config == null)
        {
            config = new ConfigClass();
        }
        DubuChar.StrongAttackEnd();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["StongAttackEnd"]);
    }

    //특수기
    public override IEnumerator SetSpecialAttack()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = false;
        DubuChar.SpecialAttackReady();
        StartCoroutine(SetSpecialSpecialAttakReady());
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["SpecialAttackSpeed"]);
        thisCharacterScript.IsSpecialAttack = false;
    }
    public IEnumerator SetSpecialSpecialAttakReady()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        yield return null;
        DubuChar.SpecialAttack_ing();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["SpecialAttackTime"]);
        thisMgr.m_SpecialAttack.ReSetAttack();
        StartCoroutine(SetSpecialAttackEnd());
    }
    public IEnumerator SetSpecialAttackDash()
    {
        if(config == null)
        {
            config = new ConfigClass();
        }
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["SpecialAttackTime"]);
    }
    public IEnumerator SetSpecialAttackEnd()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        DubuChar.SpecialAttackEnd();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["SpecialAttackTime"]);
        thisCharacterScript.CanControll = true;
    }
}
