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

    /// <summary>
    /// 位置移動が完了しているかの処理
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
        //特定の位置にいるときのメソッドの指定
        if (moveInput == true)
        {
            //１オクターブ上のド
            if (pos == 0)
            {
                OctaveDo();
            }
        }
    }

    /// <summary>
    /// １オクターブ上のドにPlayerがいるときの処理 pos:0
    /// </summary>
    public void OctaveDo()
    {
        Debug.Log("test");
    }
}
