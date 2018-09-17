using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSupportClass : BaseCharClass {

    public void SupportClass()
    {
        CharacterClassName = "support";
        CharacterClassDescription = "Descriptiong goes here";
        Stamina = 10;
        Strength = 10;
        Speed = 10;
        Intellect = 10;
    }

}
