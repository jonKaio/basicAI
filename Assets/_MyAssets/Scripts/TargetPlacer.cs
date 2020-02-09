using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPlacer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myTarget;
    public GameObject myEnemy;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 relocateTarget = Input.mousePosition;
            relocateTarget = Camera.main.ScreenToWorldPoint(
                new Vector3(relocateTarget.x, relocateTarget.y, 0)
                );
            relocateTarget.z = 0;
            myTarget.transform.position = relocateTarget;
            myTarget.SetActive(true);

        }
        if (Input.GetMouseButtonUp(1))
        {
            Vector3 relocateTarget = Input.mousePosition;
            relocateTarget = Camera.main.ScreenToWorldPoint(
                new Vector3(relocateTarget.x, relocateTarget.y, 0)
                );
            relocateTarget.z = 0;
            myEnemy.transform.position = relocateTarget;
            myEnemy.SetActive(true);

        }



    }
}
