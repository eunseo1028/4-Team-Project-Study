using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 8f; //ź�� �̵� �ӷ�
    private Rigidbody bulletRigidbody; // �̵��� ����� ������ٵ� ������Ʈ

    // Start is called before the first frame update
    void Start()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();
        //������ٵ��� �ӵ�=���� ����*�̵� �ӷ�
        bulletRigidbody.velocity = transforward * speed;
        //3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
        Destroy(gameObject, 3f);

    }
    void OnTriggerEnter(Collider other)
    {
        //�浹�� ���� ���� ������Ʈ�� �÷��̾� �±׸� ���� ���
        if (other.tag == "player")
        {
            //���� ���� ������Ʈ���� PlayerController ������Ʈ ��������
            PlayerController playerController = other.GetComponent<PlayerController>();

            //�������κ��� PlayerController ������Ʈ�� �������� �� �����ߴٸ�
            if (playerController != null)
            {
                //���� playerController ������Ʈ�� Die() �޼��� ����
                playerController.Die();

            }
        }
    }
}
