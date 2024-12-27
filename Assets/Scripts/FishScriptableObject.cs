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

}
