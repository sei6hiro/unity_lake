using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perch : MonoBehaviour
{
    public int weightPerch;
    public int maxAgePerch;
    public int currentAgePerch;
    public int maxDayWithoutFeedPerch;
    public int currentDayWithoutFeedPerch;
    public typesOfDiet typeOfDiet;
    public float rangeByWeight;
    public float countOfFeedByWeight;
    Diet diet;

    private void Awake()
    {
        diet = new Diet(typesOfDiet.Mix, 0.3f, 0.3f);
        typeOfDiet = diet.type();
        rangeByWeight = diet.range();
        countOfFeedByWeight = diet.count();
    }
}

