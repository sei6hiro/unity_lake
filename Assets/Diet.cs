using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum typesOfDiet  
    { Predator, Mix, Herbivores}
class Diet
{
    typesOfDiet typeOfDiet;
    float rangeByWeight;
    float countOfFeedByWeight;

    public Diet(typesOfDiet typeOfDiet, float rangeByWeight, float countOfFeedByWeight)
    {
        this.typeOfDiet = typeOfDiet;
        this.rangeByWeight = rangeByWeight;
        this.countOfFeedByWeight = countOfFeedByWeight;
    }
}
