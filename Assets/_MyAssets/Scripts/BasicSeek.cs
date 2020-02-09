using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSeek : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myTarget;
    public float speed;
    public Vector3 currentVelocity = Vector3.zero;
    public float angleOffset = -90;

    Vector3 v;
    Vector3 force;
    float angle = 0f;
    // Update is called once per frame
    void Update()
    {
        // Early exit if myTaget isn't active
        if (!myTarget.activeInHierarchy)
            return;

        // Calculate the Vector for this object to reach the target
        v = (myTarget.transform.position - transform.position).normalized;
        //Calculate the required change in velocity
        force = v - currentVelocity;
        // Add the force to the current velocity to accomodate the change in target position
        currentVelocity += force;
        // Move our Sprite
        transform.position += currentVelocity * Time.deltaTime;

        //Handle Rotation
        // Calculate the new angle required to point in the correct direction
        // As this is a relatively straight forward 2d operation we can use Atan2 and convert the result to degrees
        angle = angleOffset + Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
        // Using that degree value we can use the Quaternion Class to generate the required Quaternion the 
        // transform's rotation needs to be for it to look at the target
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

    }
}
