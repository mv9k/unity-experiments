using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharClass : MonoBehaviour {

    private string characterClassName;
    private string characterClassDescription;

    // Stats
    private int stamina;
    // private int health;
    // private int attack;
    // private int defense;
    private int speed;
    private int strength;
    private int intellect;

    public string CharacterClassName
    {
        get { return CharacterClassName; }
        set { characterClassName = value; }
    }
    public string CharacterClassDescription
    {
        get { return characterClassDescription; }
        set { characterClassDescription = value; }
    }
    public int Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }
    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }
    public int Intellect
    {
        get { return intellect; }
        set { intellect = value; }
    }

}
