using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Fish", menuName = "Fish")]

public class FishScriptableObject : ScriptableObject
{

    [SerializeField] string title;
    [SerializeField] int weight;
    [SerializeField] typesOfDiet typeOfDiet;
}
