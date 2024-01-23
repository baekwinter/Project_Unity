using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour

{

    public float speed = 5f;
    private SpriteRenderer spriteRenderer;
    //Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    //Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        //Debug.Log($"{x} , {y}");

        transform.position += new Vector3(x, y).normalized * Time.deltaTime * speed;

        Vector3 mousePos = Input.mousePosition;

        Debug.Log(mousePos);

        if (mousePos.x > Screen.width / 2)
        {
            spriteRenderer.flipX = false;
        }
        else if (mousePos.x < Screen.width / 2)
        {
            spriteRenderer.flipX = true;
        }

    }

}


//{
//    public event Action<Vector2> OnMoveEvent;
//    public event Action<Vector2> OnLookEvent;

//    public void CallMoveEvent(Vector2 direction) 
//    {
//        OnMoveEvent?.Invoke(direction);

//    }

//    public void CallLookEvent(Vector2 direction)
//    {
//        OnLookEvent?.Invoke(direction);
//    }