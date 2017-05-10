using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Scope_Rifle : MonoBehaviour
{
    public Animator animator;
    public GameObject scopeOverlay;
    public GameObject weaponCamera;
    public Camera mainCamera;

    public float scopedFOV = 15f;
    private float normalFOV;


     // Use this for initialization
    void Start ()
    {
        normalFOV = mainCamera.fieldOfView;
    }
	
	// Update is called once per frame
	void Update ()
    {
       if(Input.GetMouseButtonDown(1))
        {
           StartCoroutine(OnScoped());
        }
       if(Input.GetMouseButtonUp(1))
        {
            OnUnscoped();
        }
    }

    void OnUnscoped()
    {
        animator.SetBool("Scoped", false);
        scopeOverlay.SetActive(false);
        weaponCamera.SetActive(true);

        mainCamera.fieldOfView = normalFOV;
    }

    IEnumerator OnScoped()
    {
        animator.SetBool("Scoped", true);
        yield return new WaitForSeconds(.15f);
        scopeOverlay.SetActive(true);
        weaponCamera.SetActive(false);

        mainCamera.fieldOfView = scopedFOV;
    }

  
}
