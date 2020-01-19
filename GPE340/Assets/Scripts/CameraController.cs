using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
    //the players transform value
    [SerializeField]
    private Transform target;

    //reference to the main camera
    private Camera main;

    //the rotation speed of the target
    [SerializeField]
    private float targetRotationSpeed;

    //the camera offset from the player
    Vector3 offset;

    private void Start()
    {
        //get a reference to the camera and set the global variable
        main = GetComponent<Camera>();

        //set the offset
        offset = transform.position - target.transform.position;
    }

    private void Update()
    {
        //every frame rotate the player to the mouse position
        RotateToMousePosition();
        //every frame update the camera position relative to the player
        MoveCameraToTarget();
    }

    private void RotateToMousePosition()
    {
        //Define the plane that the target is on
        Plane groundPlane;
        groundPlane = new Plane(Vector3.up, target.position);

        //Find the distance down the ray that the plane intersection is at
        float distance;
        Ray ray = main.ScreenPointToRay(Input.mousePosition);

        //raycast 
        if(groundPlane.Raycast(ray, out distance))
        {
            //Find world point of intersection
            Vector3 intersectionPoint = ray.GetPoint(distance);

            //rotate towards the intersection point
            Quaternion targetRotation;
            Vector3 lookVector = intersectionPoint - target.position;
            targetRotation = Quaternion.LookRotation(lookVector, Vector3.up);
            target.rotation = Quaternion.RotateTowards(target.rotation, targetRotation, targetRotationSpeed * Time.deltaTime);
        }


    }

    private void MoveCameraToTarget()
    {
        //set the new camera position
        transform.position = target.transform.position + offset;
    }
}
