using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Animal.asset", menuName = "Animal", order = 51)]
public class AnimalData : ScriptableObject
{
    public string animalName;
    public string animalSound;
    public Sprite animalIcon;
    public int animalGoldCost;
    public int animalAge;
}
