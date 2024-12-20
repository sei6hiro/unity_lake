using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum typesOfDiet  
    { Predator, Mix, Herbivores}
class Diet
{
    typesOfDiet typeOfDiet;
    float rangeByWeight;
    float countOfFeedByWeight;

    public typesOfDiet type() 
    {
        return typeOfDiet;
    }

    public float range() 
    {
        return rangeByWeight;
    }

    public float count() 
    {
        return countOfFeedByWeight;
    }

    public Diet(typesOfDiet typeOfDiet, float rangeByWeight, float countOfFeedByWeight)
    {
        this.typeOfDiet = typeOfDiet;
        this.rangeByWeight = rangeByWeight;
        this.countOfFeedByWeight = countOfFeedByWeight;
    }
}
