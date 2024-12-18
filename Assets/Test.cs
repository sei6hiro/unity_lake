using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public GameObject cube;

    private void Start()
    {
        cube.transform.position = new Vector3(0, 0.5f, 1);
    }
}
