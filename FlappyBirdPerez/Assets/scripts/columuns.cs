using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columuns : MonoBehaviour
{
    private void OnTriggerEnter2D (Collision2D collision)
    {
      if (other.GetComponent<Bird>() != null)
        {
            GameControl.instance.BirdScored();
        }  
    }

}
