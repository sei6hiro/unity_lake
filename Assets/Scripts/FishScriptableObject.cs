using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Fish", menuName = "Fish")]

public class FishScriptableObject : MonoBehaviour
{

    [SerializeField] string title;
    [SerializeField] int weight;
    [SerializeField] typesOfDiet typeOfDiet;

    public Pike thePike = new Pike();
    public Perch thePerch = new Perch();

    private void Start()
    {
        Debug.Log(thePike.countOfPike);
        Debug.Log(thePerch.countOfPerch);
    }

    public void modifyValue(string fishType, int value)
    {
        switch (fishType)
        {
            case "Pike":
                thePike.countOfPike = 50;
                break;
            case "Perch":
                break;
        }
    }
}
