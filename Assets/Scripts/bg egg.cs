﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgegg : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == MyTags.PLAYER_TAG)
        {



            target.gameObject.GetComponent<PlayerDamage>().DealDamage();



            gameObject.SetActive(false);
        }
        if (target.gameObject.tag == "Ground")
        {


            gameObject.SetActive(false);
        }



    }
}

