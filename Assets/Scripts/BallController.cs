using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
#region private

    [Header("Movement")]

    [SerializeField]
    private Vector2 speed;

    [SerializeField]
    public Vector2 resetPosition;


    private Rigidbody2D rig;

#endregion


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        //rig.velocity = speed;
        //GetComponent<Transform>();
        //Vector3 pos = transform.position;
        //Transform.position = transform.position + (new Vector3(0.1f, 0, 0) * Time.deltaTime);
        // transform.Translate (speed * Time.deltaTime);
    }

    //Reset Ball
    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }

    //Movement Rigidbody
    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }

 
}
