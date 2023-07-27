using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear_control : MonoBehaviour
{
    Camera cam;
    Ray ray;
    Collider cubecoliider;
    RaycastHit hit;
    private Animator animator;
    //initilizing and finding the game components by their respective names
    void Start()
    {
        animator = GetComponent<Animator>();
        cam = GameObject.Find("Main Camera").GetComponent<Camera>(); //camera game object
        cubecoliider = GameObject.Find("child_cube (1)").GetComponent<Collider>(); //car skeleton
    }

    //triggering the animation on clicking the car sekelton
    void Update()
    {
        ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider == cubecoliider)
            {
                if (Input.GetMouseButton(0))
                {
                    animator.SetBool("on_click", true);
                }
            }
            else
            {
                if (Input.GetMouseButton(0))
                {
                    animator.SetBool("on_click", false);
                }
            }
        }
    }
}
