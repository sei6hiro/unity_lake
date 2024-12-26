using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pike: MonoBehaviour
{
    private FishScriptableObject _pikeDetails;

    public int countOfPike;
    public int weightPike;
    public int maxAgePike;
    public int currentAgePike;
    public int maxDayWithoutFeedPike;
    public int currentDayWithoutFeedPike;
    public typesOfDiet typeOfDiet;
    public float rangeByWeight;
    public float countOfFeedByWeight;
    Diet diet;

    private void Awake()
    {
        diet = new Diet(typesOfDiet.Predator, 0.5f, 0.5f);
        typeOfDiet = diet.type();
        rangeByWeight = diet.range();
        countOfFeedByWeight = diet.count();
    }
}
