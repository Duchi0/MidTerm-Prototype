using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedSphere : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
