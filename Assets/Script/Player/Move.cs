using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class Move : MonoBehaviour
{
   
    /// <summary>
    /// ���݂̈ʒu�𐔒l��
    /// </summary>
    public int pos;

    /// <summary>
    /// �ʒu�ړ����������Ă��邩�̏���
    /// </summary>
    public bool moveInput;
    // Start is called before the first frame update
    void Start()
    {
        pos = 0;
        moveInput = true;
    }

    // Update is called once per frame
    void Update()
    {
        //����̈ʒu�ɂ���Ƃ��̃��\�b�h�̎w��
        if (moveInput == true)
        {
            //�P�I�N�^�[�u��̃h
            if (pos == 0)
            {
                OctaveDo();
            }
        }
    }

    /// <summary>
    /// �P�I�N�^�[�u��̃h��Player������Ƃ��̏��� pos:0
    /// </summary>
    public void OctaveDo()
    {
        Debug.Log("test");
    }
}
