using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ItemType
    {
        None,
        BlueDiamond,
        GoldenSkull,
        GoldenCoin,
    }

    [SerializeField] private bool havePopAnimation = false;
    [SerializeField] private ItemType itemType = ItemType.None;
    [SerializeField] private bool pickable = true;
    [SerializeField] private AudioSource audioSource;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayAnimationAndDestroy()
    {
        if (animator && havePopAnimation)
        {
            audioSource.Play();
            animator.SetTrigger("Pop");
            pickable = false;
            Destroy(gameObject, animator.GetCurrentAnimatorStateInfo(0).length);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public ItemType getItemType()
    {
        return itemType;
    }

    public bool isPickable()
    {
        return pickable;
    }
}
