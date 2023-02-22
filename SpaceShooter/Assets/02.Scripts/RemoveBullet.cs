using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    public GameObject sparkEffect;

    

        // �浹�� ������ �� �߻��ϴ� �̺�Ʈ
        void OnCollisionEnter(Collision coll)
        {
            // �浹�� ���ӿ�����Ʈ�� �±װ� ��
            //if (coll.collider.tag == "BULLET")
            if (coll.collider.CompareTag("BUULET"))
            {
            ContactPoint cp = coll.GetContact(0);

            Quaternion rot = Quaternion.LookRotation(-cp.normal);

            GameObject spark =Instantiate(sparkEffect, coll.transform.position, Quaternion.identity);
            Destroy(spark, 0.5f);    

                // �浹�� ���ӿ�����Ʈ ����
                Destroy(coll.gameObject);
            }
        }     
} 

