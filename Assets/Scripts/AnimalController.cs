using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    public AnimalData animal;

    public GameEvent animalEvent;

    private void OnMouseDown()
    {
        Debug.Log("Animal : " + animal.animalName);
        animalEvent.RaiseEvent();
    }
}
