using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
public transform teleportPoint;
{
    void OnTriggerEnter(Collider other)
    {
        other.transform.position = teleportPoint.position;
    }
}
