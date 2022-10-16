using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private bool open = false;
    [SerializeField] private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public bool isOpen()
    {
        return open;
    }

    public void Open()
    {
        animator.SetTrigger("Open");
    }

    public void Close()
    {
        animator.SetTrigger("Close");
    }

    public void OnOpen()
    {
        open = true;
        print(open);
    }

    public void OnClose()
    {
        open = false;
        print(open);
    }
}
