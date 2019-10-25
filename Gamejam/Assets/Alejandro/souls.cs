using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Souls : MonoBehaviour
{
    TriggerActions characterCollider;
    SoulCount soulCount;

    private void Start()
    {
        characterCollider = FindObjectOfType<TriggerActions>().GetComponent<TriggerActions>();
        soulCount = GameObject.FindGameObjectWithTag("SoulCounter").GetComponent<SoulCount>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "character")
        {
            this.gameObject.SetActive(false);
            characterCollider.addOneSoul();

            soulCount.AddSoul();
        }
    }
}
