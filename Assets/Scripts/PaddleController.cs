using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    #region Private
    [Header("Paddle Settings")]

    [SerializeField]
    private KeyCode upKey;

    [SerializeField]
    private KeyCode downKey;

    [SerializeField]
    private Vector3 vector;

    [SerializeField]
    private float timesUp;

    [SerializeField]
    private int scale = 4;

    [SerializeField]
    private int speed;

    [SerializeField]
    private int TimesSpeed = 2 ;


    private Rigidbody2D rig;

    

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
        rig = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }

        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        //Debug.Log("Test :" + movement);
        rig.velocity = movement;
    }

    //Adding Scale Up for Paddle, Collide with Ball
    public void ActivatePUScaleUp()
    {
        this.gameObject.transform.localScale += new Vector3(0,scale, 0);
        StartCoroutine(NormalScale());
    }

    public void ActivatePUHandleUp()
    {
        speed = TimesSpeed * speed;
        StartCoroutine(NormalSpeed());
    }

    IEnumerator NormalScale()
    {
        //Debug.Log("Started Coroutine at timestamp : " + Time.time);
        yield return new WaitForSeconds(timesUp);
        Debug.Log("Test");
        this.gameObject.transform.localScale -= new Vector3(0, scale, 0);
    }

    IEnumerator NormalSpeed()
    {
        yield return new WaitForSeconds(timesUp);
        Debug.Log("Speed Abis");
        speed = speed / TimesSpeed;
    }


}
