using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoldenSkull : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private int sceneIndex = -1;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

   public void OnPop()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(sceneIndex);
    }

    public void OnPickupAndChangeScene()
    {
        audioSource.Play();
        animator.SetTrigger("Pop");
    }
}
