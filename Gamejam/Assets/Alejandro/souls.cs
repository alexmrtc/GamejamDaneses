using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Souls : MonoBehaviour
{
    TriggerActions characterCollider;

    private void Start()
    {
        characterCollider = FindObjectOfType<TriggerActions>().GetComponent<TriggerActions>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "characterCollider")
        {
            this.gameObject.SetActive(false);
            characterCollider.addOneSoul();
        }
    }
}
