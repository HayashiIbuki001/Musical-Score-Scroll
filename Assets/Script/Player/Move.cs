using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class Move : MonoBehaviour
{
   
    /// <summary>
    /// 現在の位置を数値化
    /// </summary>
    public int pos;

    //x軸の値を固定
    private float pos_x = -8.4f;

    /// <summary>
    /// 位置移動が完了しているかの処理
    /// </summary>
    public bool moveInput;
    // Start is called before the first frame update
    void Start()
    {
        pos = 0;
        moveInput = true;

        //初期の位置を設定
        this.transform.position = new Vector3(pos_x, 1.495f);
    }

    // Update is called once per frame
    void Update()
    {
        //特定の位置にいるときのメソッドの指定
        if (moveInput == true)
        {
            //１オクターブ上のレ
            if (pos == 1)
            {
                OctaveRe();
            }
            //１オクターブ上のド
            else if (pos == 0)
            {
                OctaveDo();
            }
            //シ
            else if (pos == -1)
            {
                Si();
            }
            //ラ
            else if (pos == -2)
            {
                Ra();
            }
            //ソ
            else if (pos == -3)
            {
                So();
            }
        }
    }

    /// <summary>
    /// １オクターブ上のレにPlayerがいるときの処理 pos:1
    /// </summary>
    public void OctaveRe()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //一つ音階を上げる
            this.transform.position = new Vector3(pos_x, 2.37f);
            pos = 2;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //一つ音階を下げる
            this.transform.position = new Vector3(pos_x, 1.495f);
            pos = 0;
        }
    }

    /// <summary>
    /// １オクターブ上のドにPlayerがいるときの処理 pos:0
    /// </summary>
    public void OctaveDo()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //一つ音階を上げる
            this.transform.position = new Vector3(pos_x, 1.93f);
            pos = 1;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //一つ音階を下げる
            this.transform.position = new Vector3(pos_x, 1.07f);
            pos = -1;
        }
    }

    /// <summary>
    /// シにPlayerがいるときの処理 pos:-1
    /// </summary>
    public void Si()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //一つ音階を上げる
            this.transform.position = new Vector3(pos_x, 1.495f);
            pos = 0;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //一つ音階を下げる
            this.transform.position = new Vector3(pos_x, 0.628f);
            pos = -2;
        }
    }

    /// <summary>
    /// ラにPlayerがいるときの処理 pos:-2
    /// </summary>
    public void Ra()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //一つ音階を上げる
            this.transform.position = new Vector3(pos_x, 1.07f);
            pos = -1;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //一つ音階を下げる
            this.transform.position = new Vector3(pos_x, 0.2f);
            pos = -3;
        }
    }

    /// <summary>
    /// ソにPlayerがいるときの処理 pos:-3
    /// </summary>
    public void So()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //一つ音階を上げる
            this.transform.position = new Vector3(pos_x, 0.628f);
            pos = -2;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //一つ音階を下げる
            this.transform.position = new Vector3(pos_x, -0.248f);
            pos = -4;
        }
    }
}
