using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleDialogShow : MonoBehaviour
{
    public void OnClickShowButton()
    {
        SampleDialogData data = new SampleDialogData();
        data.title = "タイトル書換";
        data.content = "内容書換";
        StartCoroutine(DialogManager.instance.DialogShow(DialogSelector.DialogType.SampleDialog, data));
    }
}
