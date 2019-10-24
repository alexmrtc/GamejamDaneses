using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class souls : MonoBehaviour
{
    collision characterCollider;

    private void Start()
    {
        characterCollider = FindObjectOfType<collision>().GetComponent<collision>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);

        if (collision.name == "characterCollider")
        {
            this.gameObject.SetActive(false);
            characterCollider.addOneSoul();
        }
    }
}
