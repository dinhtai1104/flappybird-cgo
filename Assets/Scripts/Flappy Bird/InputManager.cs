using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public VectorIntroduction objectNeedMove;
    public SpriteRenderer spriteRenderer;

    public KeyCode key = KeyCode.A;
    public int mouseButton;
    public float timeRest = 1f;

    private float timeControl = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is InputManager run on Start()");
        //objectNeedMove = new VectorIntroduction();
        objectNeedMove = GetComponent<VectorIntroduction>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Xử lý phát hiện ra Input của người dùng
        // class Input - là class chịu trách nhiệm đọc input của người dùng
        InputAxis();
    }
    protected void InputAxis()
    {
        //Input.GetAxis("Horizontal"); // -1..0..1
        float horizontalAxis = Input.GetAxisRaw("Horizontal"); // -1..0..1
        float verticalAxis = Input.GetAxisRaw("Vertical");

        objectNeedMove.Move(new Vector3(horizontalAxis, verticalAxis, 0));
    }
    protected void InputMouseClick()
    {
        // Read Input from Mouse - Mobile
        bool startClick = Input.GetMouseButtonDown(mouseButton);
        bool holdClick = Input.GetMouseButton(mouseButton);
        bool releaseClick = Input.GetMouseButtonUp(mouseButton);

        // Câu lệnh điều kiện if else
        if (startClick == true)
        {
            timeControl = 0;
            Debug.Log("Bắt đầu click chuột");
        }
        if (holdClick == true)
        {
            // 60fps -> 60frames / s
            timeControl += Time.deltaTime;
            if (timeControl >= timeRest)
            {
                timeControl = 0;
                Debug.Log("Đang giữ click chuột");
            }
        }
        if (releaseClick == true)
        {
            Debug.Log("Đã nhả click chuột");
        }
    }
    protected void InputKeyboard()
    {
        // bắt đầu bấm phím
        bool startPressKey = Input.GetKeyDown(key);

        // giữ phím
        bool holdPressKey = Input.GetKey(key);

        // nhả phím
        bool releasePressKey = Input.GetKeyUp(key);

        // Câu lệnh điều kiện if else
        if (startPressKey == true)
        {
            Debug.Log("Bắt đầu bấm phím " + key.ToString());
        }
        if (holdPressKey == true)
        {
            Debug.Log("Đang giữ phím " + key.ToString());
        }
        if (releasePressKey == true)
        {
            Debug.Log("Đã nhả phím " + key.ToString());
        }
    }
}
