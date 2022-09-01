using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nutrition : MonoBehaviour
{
    public GameObject darken;
    public GameObject nutrition;

    public void OnNutritionClicked()
    {
        bool state = (nutrition.activeSelf);
        nutrition.SetActive(!state);
        darken.SetActive(!state);
    }
}
