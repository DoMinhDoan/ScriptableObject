using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public void UpdateDisplayUI(AnimalData animalData)
    {
        Debug.Log("UpdateDisplayUI Animal=" + animalData.animalName);
    }
}
