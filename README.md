# DialogManager
Unity ダイアログ表示する機能

<h2>概要</h2>

アプリ上にてダイアログを表示したい時に表示非表示などの管理を行う機能です。

<h2>開発環境</h2>

Unity2019.1

<h2>使い方</h2>

1. DialogManagerプレハブをシーンへ配置します  
これはシングルトンインスタンスとなるので配置するシーンは一箇所だけでも問題ありません  
適時Canvasの設定を解像度に応じて変更してください  
   
2. ResourcesフォルダにDialogという名前のフォルダを作成します  
このフォルダはResources/Dialogという配置さえ間違えてなければ複数作成しても問題ありません　
表示させたいダイアログを作成とプレハブ化を行い上で作成したDialogフォルダへ入れてください　

3. 作成したダイアログプレハブにDialogBaseもしくはDialogBaseを継承したクラスをアタッチしてください  
以下の関数をオーバーライドし処理を書くことでそれぞれ表示時、非表示時の処理を記述することができます  

```
    //ダイアログ初期化処理
    public virtual IEnumerator DialogInitialize(DialogData data = null) { yield return null; }
    //ダイアログ終了処理
    public virtual IEnumerator DialogFinalize(DialogData data = null) { yield return null; }
```

また初期化時もしくは終了時にデータが渡せるようにDialogDataというクラスを用意しています  
こちらは各ダイアログクラス毎にDialogDataを継承したクラスを作成し表示タイミングで渡すことでダイアログ側に値を渡すことが可能です  
その後、DialogSelectorクラスのDialogTypeに今回作成したプレハブ名のenumを追加してください  

4. 以上で前設定は終わりです  
表示をさせたいタイミングで以下の処理をすると表示させることができます。
表示させた後に非表示にさせるには作成したDialogのshowDialiogWaitFlgをfalseにすると非表示になります  
こちらのダイアログ表示→非表示までの流れはコルーチンで動作していますのでダイアログ終了待ちなどさせるときに活用してください  

```
    StartCoroutine(DialogManager.instance.DialogShow(DialogSelector.DialogType.今回作成したプレハブ名, 設定したDialoData　nullでもOK));
```

<h2>備考</h2>

この機能が動作するサンプルがAssets/DialogManager/Sampleに入っています  
