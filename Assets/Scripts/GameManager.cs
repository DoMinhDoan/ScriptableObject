using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text animalName;
    public Text animalSound;
    public Text animalAge;
    public Text animalCost;
    public Image animalIcon;

    public void UpdateDisplayUI(AnimalData animalData)
    {
        animalName.text = animalData.animalName;
        animalSound.text = animalData.animalSound;
        animalAge.text = animalData.animalAge.ToString();
        animalCost.text = animalData.animalGoldCost.ToString();
        animalIcon.sprite = animalData.animalIcon;
    }
}
