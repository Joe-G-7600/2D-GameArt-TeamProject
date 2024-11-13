using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CollectablePickUp : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Capitalization and Spelling must be same")]
    string CollectablePickupTagName = "Collectable";

    private void Start()
    {
        GetListOfPickups();
    }

    private void GetListOfPickups()
    {
        try
        {
            GameObject[] pickups = GameObject.FindGameObjectsWithTag(CollectablePickupTagName);
            if (pickups.Length == 0)
            {
                Debug.LogWarning("ZERO objects found tagged with " + CollectablePickupTagName);
            }
        }
        catch (Exception ex)
        {
            Debug.LogWarning("Make sure Tag is created that matche spelling and capitilizatin for Collectable.");
            Debug.Log(ex.Message);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        try
        {
            if (collision.CompareTag(CollectablePickupTagName))
            {
                Destroy(collision.gameObject);
            }
        }
        catch(Exception ex)
        {
            Debug.LogWarning("Make sure Tag is created that matche spelling and capitilizatin for Collectable.");
            Debug.Log(ex.Message);
        }
    }
}
