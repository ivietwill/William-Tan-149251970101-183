using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider2D ball;
    public bool isRight;
    public ScoreManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (isRight)
            {
                manager.AddRightScore(1);
            }

            else
            {
                manager.AddLeftScore(1);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //manager.AddLeftScore(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
