using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

[System.Serializable]
public class CharacterAnimator : CharacterComponent
{
    [SerializeField] protected List<Animator> animators;

    public CharacterAnimator(Character character, List<Animator> animators) : base(character)
    {
        this.animators = animators;
        ChangeTorso(null);
        ChangeLegs(null);
    }
    
    public void Move(Vector2 direction)
    {
        float speed = direction.magnitude;
        foreach (Animator animator in animators)
        {
            if (!animator.isActiveAndEnabled) continue;
            animator.SetFloat("Speed", speed);
            if (speed <= 0) continue;
            animator.SetFloat("Horizontal", direction.x);
            animator.SetFloat("Vertical", direction.y);
        }
    }

    public void InventoryChange(Inventory inventory)
    {
        TorsoClothing torsoClothing = inventory.Torso.Get() as TorsoClothing;
        LegsClothing legsClothing = inventory.Legs.Get() as LegsClothing;
        ChangeTorso(torsoClothing?.itemData.AnimatorController);
        ChangeLegs(legsClothing?.itemData.AnimatorController);
    }

    public void ChangeTorso(AnimatorController animatorController)
    {
        Change(1, animatorController);
    }

    public void ChangeLegs(AnimatorController animatorController)
    {
        Change(2, animatorController);
    }

    private void Change(int index, AnimatorController animatorController)
    {
        if (index >= animators.Count)
        {
            Debug.LogWarning($"{character.characterData.IdName} attempted to use a Animator that doesn't exist.");
            return;
        }

        Animator animator = animators[index];
        animator.runtimeAnimatorController = animatorController;
        animator.gameObject.SetActive(animatorController);
    }
}
