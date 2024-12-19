using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrucianCarp : MonoBehaviour
{
    public int weight;
    public int maxAge;
    public int currentAge;
    Diet diet;
    public int maxDayWithoutFeed;
    public int currentDayWithoutFeed;

    private void Awake()
    {
        diet = new Diet(typesOfDiet.Herbivores, 0.15f, 0.15f);
    }


}
