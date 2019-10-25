using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Souls : MonoBehaviour
{
    TriggerActions characterCollider;
    public GameObject soulCount;

    private void Start()
    {
        characterCollider = FindObjectOfType<TriggerActions>().GetComponent<TriggerActions>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.name);

        if (collision.name == "character")
        {
            this.gameObject.SetActive(false);
            characterCollider.addOneSoul();

            soulCount.GetComponent<SoulCount>().AddSoul();
        }
    }
}
