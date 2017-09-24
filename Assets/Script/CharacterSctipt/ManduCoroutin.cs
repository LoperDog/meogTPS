using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManduCoroutin : CoroutinClass
{
    public ManduCharacter ManduChar;

    public override void SetCharacterScript(CharacterSuper CharacterClass)
    {
        base.SetCharacterScript(CharacterClass);
        ManduChar = (ManduCharacter)CharacterClass;
    }
}
