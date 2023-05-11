using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayrtController : MonoBehaviour
{
    public Rigidbody playerRigidbody; // �̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f; // �̵� �ӷ�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Keycode.UpArrow) == true){
            // ���� ����Ű �Է��� ������ ��� z ���� �� �ֱ�
            playerRigidbody.AddForce(0f, 0f, speed);

        }
        if (Input.GetKey(Keycode.DownArrow) == true)
        {
            // �Ʒ��� ����Ű �Է��� ������ ��� -z ���� �� �ֱ�
            playerRigidbody.AddForce(0f, 0f, -speed);

        }
        if (Input.GetKey(Keycode.RightArrow) == true)
        {
            // ������ ����Ű �Է��� ������ ��� x ���� �� �ֱ�
            playerRigidbody.AddForce(speed, 0f, 0f);

        }
        if (Input.GetKey(Keycode.LeftArrow) == true)
        {
            // ���� ����Ű �Է��� ������ ��� -x ���� �� �ֱ�
            playerRigidbody.AddForce(-speed, 0f, 0f);

        }

    }
}
