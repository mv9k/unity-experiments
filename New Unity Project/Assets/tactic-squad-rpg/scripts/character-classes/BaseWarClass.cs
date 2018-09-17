using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWarClass : BaseCharClass {

    public void WarClass()
    {
        CharacterClassName = "warrior";
        CharacterClassDescription = "Descriptiong goes here";
        Stamina = 15;
        Strength = 13;
        Speed = 11;
        Intellect = 7;
    }
	
}
