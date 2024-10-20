using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyEgg : MonoBehaviour
{
    public float limiteY = -5f;

    void Update() {
        if (transform.position.y < limiteY)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Basket"))
        {
            ScoreManager.Instance.AddPoint();

            Destroy(gameObject);
        }
    }
}
