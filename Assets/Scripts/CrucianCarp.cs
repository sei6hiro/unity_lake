using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrucianCarp : MonoBehaviour
{
    public int weight;
    public int maxAge;
    public int currentAge;
    public int maxDayWithoutFeed;
    public int currentDayWithoutFeed;
    public typesOfDiet typeOfDiet;
    public float rangeByWeight;
    public float countOfFeedByWeight;

    Diet diet;

    private void Awake()
    {
        diet = new Diet(typesOfDiet.Herbivores, 0.15f, 0.15f);
        typeOfDiet = diet.type();
        rangeByWeight = diet.range();
        countOfFeedByWeight = diet.count();
    }


}