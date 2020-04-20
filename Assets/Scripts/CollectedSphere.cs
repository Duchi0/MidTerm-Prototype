using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CollectedSphere : MonoBehaviour
{
    public TextMeshProUGUI sphereCount;
    private int spheresCollected;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        UpdateScore();
    }
    public void UpdateScore()
    {
        spheresCollected++;
        sphereCount.text = $"Spheres Collected: {spheresCollected}/5 ";
    }
}
