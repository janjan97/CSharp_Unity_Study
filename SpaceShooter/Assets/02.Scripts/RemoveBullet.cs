using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour{
        
        // �浹�� ������ �� �߻��ϴ� �̺�Ʈ
        void OnCollisionEnter(Collision coll)
        {
            // �浹�� ���ӿ�����Ʈ�� �±װ� ��
            //if (coll.collider.tag == "BULLET")
            if (coll.collider.CompareTag("BUULET"))
            {
                // �浹�� ���ӿ�����Ʈ ����
                Destroy(coll.gameObject);
            }
        }     
} 

