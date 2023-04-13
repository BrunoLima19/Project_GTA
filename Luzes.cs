using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luzes : MonoBehaviour
{
    [ SerializeField] public Light Sol;

    void Start()
    {
        Sol.gameObject.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) {
            Debug.Log("Estado do Sol: " + Sol.enabled);
            Sol.enabled = !Sol.enabled;
        }
    }
}