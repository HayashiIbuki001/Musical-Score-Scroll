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

    //x���̒l���Œ�
    private float pos_x = -8.4f;

    /// <summary>
    /// �ʒu�ړ����������Ă��邩�̏���
    /// </summary>
    public bool moveInput;
    // Start is called before the first frame update
    void Start()
    {
        pos = 0;
        moveInput = true;

        //�����̈ʒu��ݒ�
        this.transform.position = new Vector3(pos_x, 1.495f);
    }

    // Update is called once per frame
    void Update()
    {
        //����̈ʒu�ɂ���Ƃ��̃��\�b�h�̎w��
        if (moveInput == true)
        {
            //�P�I�N�^�[�u��̃�
            if (pos == 1)
            {
                OctaveRe();
            }
            //�P�I�N�^�[�u��̃h
            else if (pos == 0)
            {
                OctaveDo();
            }
            //�V
            else if (pos == -1)
            {
                Si();
            }
        }
    }

    /// <summary>
    /// �P�I�N�^�[�u��̃���Player������Ƃ��̏��� pos:1
    /// </summary>
    public void OctaveRe()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //����K���グ��
            this.transform.position = new Vector3(pos_x, 2.37f);
            pos = 2;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //����K��������
            this.transform.position = new Vector3(pos_x, 1.495f);
            pos = 0;
        }
    }

    /// <summary>
    /// �P�I�N�^�[�u��̃h��Player������Ƃ��̏��� pos:0
    /// </summary>
    public void OctaveDo()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //����K���グ��
            this.transform.position = new Vector3(pos_x, 1.93f);
            pos = 1;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //����K��������
            this.transform.position = new Vector3(pos_x, 1.07f);
            pos = -1;
        }
    }

    /// <summary>
    /// �V��Player������Ƃ��̏��� pos:-1
    /// </summary>
    public void Si()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //����K���グ��
            this.transform.position = new Vector3(pos_x, 1.495f);
            pos = 0;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //����K��������
            this.transform.position = new Vector3(pos_x, 0.628f);
            pos = -2;
        }
    }
}
