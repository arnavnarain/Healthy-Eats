using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingedients : MonoBehaviour
{
    public GameObject darken;
    public GameObject ingredients;

    public void OnIngredientsClicked()
    {
        bool state = (ingredients.activeSelf);
        ingredients.SetActive(!state);
        darken.SetActive(!state);
    }
}
