using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Pawn :  BaseItem
{
    protected override bool CheckAnyposition(GameObject item)
    {
        if (homePosition.y == 6 )
        {
            if ((item.transform.position.x == homePosition.x) && (homePosition.y == item.transform.position.y + 1
                                                                  || homePosition.y == item.transform.position.y + 2))
            {
                item.GetComponent<ItemPosition>().canComeHere = true;
                return true;
            }
                
            else
            {
                return false;
            }
        }
        else
        {
            if ((item.transform.position.x == homePosition.x) && (homePosition.y == item.transform.position.y + 1))
            {
                item.GetComponent<ItemPosition>().canComeHere = true;
                return true;
            }
                
            else
            {
                return false;
            }
        }
    }

    protected override bool CheckCorners(Vector3 anyPosition, Transform hit)
    {
        if (hit.GetComponent<ItemPosition>().GetIsAnyItemHere() &&
            hit.GetComponent<ItemPosition>().item.CompareTag("BlackItem"))
        {
            if (anyPosition.y  + 1 == homePosition.y)
            {
                if (anyPosition.x - 1 == homePosition.x || anyPosition.x + 1 == homePosition.x)
                {
                    hit.GetComponent<ItemPosition>().canComeHere = true;
                    return true;
                    
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    
   
      
}
