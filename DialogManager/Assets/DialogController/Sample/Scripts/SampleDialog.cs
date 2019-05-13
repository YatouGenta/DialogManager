using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// サンプル用ダイアログクラス
/// </summary>
public class SampleDialog : AnimationDiadlogBase
{
    //タイトルText
    [SerializeField]
    private Text titleText = null;
    //内容Text
    [SerializeField]
    private Text contentText = null;

    //初期化
    public override IEnumerator DialogInitialize(DialogData data = null)
    {
        //取得したデータを元に内容を書き換え
        if (data != null)
        {
            SampleDialogData dData = (SampleDialogData)data;
            titleText.text = dData.title;
            contentText.text = dData.content;
        }
        yield return base.DialogInitialize(data);
    }
    //終了時
    public override IEnumerator DialogFinalize(DialogData data = null)
    {
        Debug.Log("終了処理開始");
        yield return base.DialogFinalize(data);
    }

    /// <summary>
    /// 閉じるボタン
    /// </summary>
    public void OnClickCloseButton()
    {
        Debug.Log("ボタン押した");
        showDialiogWaitFlg = false;
    }
}
/// <summary>
/// サンプルダイアログ用データクラス
/// </summary>
public class SampleDialogData : DialogData
{
    public string title;
    public string content;
}
