using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableFinder
{
    public Interactable OverlapSphere(Vector3 position, float radius)
    {
        int mask = Constants.interactableMask.value;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(position, radius, mask);
        //Collider[] colliders = Physics.OverlapSphere(position, radius, mask, QueryTriggerInteraction.Collide);

        Interactable result = null;
        foreach (var item in colliders)
        {
            Interactable interactable = item.GetComponent<Interactable>();
            if (interactable == null) continue;
            result = interactable;
            break;
        }
        return result;
    }
}
