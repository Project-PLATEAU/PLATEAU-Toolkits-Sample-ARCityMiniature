# PLATEAU-Toolkits-Sample-ARCityMiniature
PLATEAU SDK-Toolkits for Unityを使ったサンプルアプリケーション

### 更新履歴

|  2023/12/13  |  AR City Miniature 初回リリース|
| :--- | :--- |


# 目次

- [1. サンプルプロジェクトの概要](#1-サンプルプロジェクトの概要)
  * [1-1. 体験の概要](#1-1-体験の概要)
  * [1-2. Toolkitの利用機能](#1-2-toolkitの利用機能)
- [2. 利用手順](#2-利用手順)
  * [2-1. 必要環境](#2-1-必要環境)
  * [2-2. サンプルシーンのビルド方法](#2-2-サンプルシーンのビルド方法)
  * [2-3. ビルドしたアプリケーションの操作方法](#2-3-ビルドしたアプリケーションの操作方法)
- [3. サンプルシーンのカスタマイズ方法](#3-サンプルシーンのカスタマイズ方法)
  * [3-1. 自分でPLATEAUモデルをインポートしたい時](#3-1-自分でPLATEAUモデルをインポートしたい時)
  * [3-2. 自分で作ったマーカーを入れたいとき](#3-2-自分で作ったマーカーを入れたいとき)
- [4. サンプルミニチュア3D都市モデルのメイキング](#4-サンプルミニチュア3D都市モデルのメイキング)
  * [4-1. 3D都市モデルのプレハブ化](#4-1-3D都市モデルのプレハブ化)
  * [4-2. モバイルデバイスをターゲットにしたミニチュア3D都市モデルの作成](#4-2-モバイルデバイスをターゲットにした3Dミニチュア都市モデルの作成)
  * [4-3. モデルの加工と出力](#4-3-モデルの加工と出力)
  * [4-4. ライトマップの適用](#4-4-ライトマップの適用)
  * [4-5. ナブメッシュの作成と人の配置](#4-5-ナブメッシュの作成と人の配置)
 

# 1. サンプルプロジェクトの概要
## 1-1. サンプルプロジェクトで体験できること
- このサンプルプロジェクトでは端末のカメラを利用したARアプリケーションを体験することができます。
- アプリケーションで読み取ったARマーカーの上にPLATEAU 3D都市モデルのミニチュアオブジェクトを表示します。
- AR空間に表示したPLATEAU 3D都市モデルを用いて都市計画を行うユースケースなどを想定したアプリケーションです。


## 1-2. Unityプロジェクト情報
### Unity バージョン
- Unity 2021.3.30f1

### レンダリングパイプライン
- URP (Universal Rendering Pipeline)

## 1-2. 利用している PLATEAU SDK-Toolkits の機能
### PLATEAU SDK Rendering Toolkit
- 窓用の頂点カラー調整

# 2. 利用手順
## 2-1. 推奨環境
### 参考開発環境
以下は本プロジェクトに使用した開発環境です。

- Windows11
- macOS Ventura 13.2
- Android 13
- iOS 16.7.1

## 2-2. サンプルシーンのビルド方法
1. メニューより File > Build Settings を選択し Build Settings ウィンドウを表示します。
<img width="600" alt="miniature_sample_05_projectview" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_05_projectview.png">

2. プラットフォームがAndroidかiOS以外になっている場合は、アプリケーションを動作させる端末に合わせてプラットフォームを選択し、画面下部にある「Switch Platform」ボタンからプラットフォームを切り替えます。<br>

<img width="600" alt="miniature_sample_07_switchplatform" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_07_switchplatform.png">

3. Build Settings ウィンドウの画面下部にある「Build」ボタンを押下し、ビルドの出力先を選択してビルドを開始します。iOSの場合は Xcode プロジェクトフォルダ、Androidの場合は .apk ファイルもしくはAndroid Gradleプロジェクトを生成します。<br />
ビルドが完了したら、各プラットフォームに合わせて端末へアプリケーションをインストールしてください。

<img width="600" alt="miniature_sample_06_buildsettings" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_06_buildsettings.png">

## 2-3. ビルドしたアプリケーションの操作方法
1. ビルドしたアプリケーションを端末で開くと、オープニング画面が表示されます。<br>
「始めましょう」のボタンをタップすると、ARマーカー読み取り画面に遷移します。<br>

<img width="600" alt="miniature_sample_01_title" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_01_title.png">

2. ARマーカー読み取り画面で対象のARマーカーをカメラで読み取る（ARマーカーをカメラで写す）と、ARマーカー上にPLATEAU 3D都市モデルのミニチュアオブジェクトが表示されます。<br>

<img width="600" alt="miniature_sample_02_markerscan" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_02_markerscan.png">

<img width="600" alt="miniature_sample_miniature_app" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_miniature_app.png">

3. ミニチュアオブジェクトを表示すると、画面上にミニチュアオブジェクトを操作することのできるUIが表示されます。画面右側に表示されるスケールバーを調整することで3D都市モデルの大きさを変更することができ、画面下側に表示される回転バーを調整すると、3D都市モデルを回転させることができます。

# 3. サンプルプロジェクトのカスタマイズ方法
本サンプルプロジェクトを元に、表示させる3D都市モデルの変更などを行いたい場合は以下を参考にサンプルプロジェクトに改変を加えて利用してください。

## 3-1. 任意のPLATEAU 3D都市モデルをインポートしたい場合

1. PLATEAU SDKを使って、サンプルシーン内に3D都市モデルをインポートします。
    - モバイル端末上で3D都市モデルを表示する場合は、大きさなどによって最適化が必要になる場合があります。モバイルアプリ向けの3D都市モデルの最適化の手順については次章の [4. サンプルミニチュア都市モデルのメイキング](#4-サンプルミニチュア都市モデルのメイキング) を参照してください。

2. インポートの完了後、PLATEAU SDK を使用し、インポートした3D都市モデルを FBX ファイルとしてプロジェクトに保存します。

3. シーン上に新規のゲームオブジェクトを作成し、その中に保存した FBX ファイルをドラッグアンドドロップで子オブジェクトとして追加します。
    - このオブジェクトがARマーカー上に表示される3D都市モデルオブジェクトの本体になります。
    - 分かりやすさのため、ゲームオブジェクトはインポートした場所の名前などを設定してください。

3. 作成したゲームオブジェクトをもとにプレハブを作成します。
    - ヒエラルキーからプロジェクト内の任意のフォルダにゲームオブジェクトをドラッグアンドドロップすることでプレハブを作成することができます。

4. プロジェクトから "Assets/Prefabs/MiniatureCityModels" を選択し、"MiniatureCityModels" プレハブのインスペクターを開きます。

5. `City Models` フィールド内の `City Model Prefab` に作成したプレハブを設定してください。

<img width="600" alt="miniature_sample_makeprefab" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_makeprefab.png">


## 3-2. ARマーカーに使用する画像を変更したい場合

1. 用意したマーカーの画像ファイルをプロジェクトに追加します。
    - UnityではOSのファイルシステム（Windows エクスプローラー / macOS Finder）からUnityエディタのプロジェクト内の任意のフォルダに画像ファイルをドラッグアンドドロップすることでアセットをインポートできます。
    - サンプルでは "/Assets/Images" の中に "ARMarkerImage.png" が格納されています。

<img width="600" alt="miniature_sample_markerpath" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_markerpath.png">

2. インポートした画像をARマーカーとして登録します。
    - "/Assets" の中にある "ReferencedImageLibrary" を選択してインスペクターを表示し、 "Add Image" を押下してARマーカー画像データを追加します。
    - プロジェクトにインポートした画像アセットをARマーカーのテクスチャに設定します。
    - ARマーカー名はファイル名から自動で設定されますが、任意の名前を設定することが可能です。
    - ARマーカー画像は現実空間に配置する大きさをメートル単位で指定する必要があります。印刷するARマーカー画像の大きさなどに合わせて大きさを設定してください。
    - "Assets/Prefabs/MiniatureCityModels" のインスペクタから、追加したARマーカーに紐付ける `City Models` の `ARMarkerName` に設定したARマーカー名を指定してください。

3. Unity プロジェクトをビルドし、用意したARマーカーを読み取ると、紐づけられた3D都市モデルオブジェクトが表示されます。

<img width="600" alt="miniature_sample_reflib_before" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_reflibpath.png">

<img width="600" alt="miniature_sample_reflib_before" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_reflib_before.png">

# 4. サンプルプロジェクトで使用しているミニチュア3D都市モデルの構成手順
ここでは、サンプルプロジェクトで用意している3D都市モデルの構成手順について紹介します。サンプルプロジェクトに予め用意された3D都市モデル以外の3D都市モデルを導入する際に、同じような演出を行いたい場合は以下の手順を参考にアセットを作成してください。

主にサンプルプロジェクトでは以下のような調整を3D都市モデルに実装しています。
- モバイル端末でも快適に動作するように3D都市モデルを最適化しています。
- モバイル端末でのパフォーマンスを考慮した上で、頂点カラーやライトマップを設定することでモデルの審美性を高めています。
- 臨場感のある3D都市モデルを演出するために、ナビゲーション ([ナビメッシュ](https://docs.unity3d.com/ja/2021.3/Manual/nav-Buildingナビメッシュ.html)) を導入して都市を移動するアバターを追加しています。

## 4-1. 3D都市モデルのプレハブ化
- **SDKのエクスポート機能による出力**: CityGMLからFBXやGLTFへのエクスポート
- **UnityのFBX Exporterによる出力**: 選択したメッシュのエクスポート

### 3D都市都市モデルのプレハブ化
#### サンプルプロジェクトと3D都市モデル
サンプルプロジェクトでは、ARマーカーを読み取ると対応するオブジェクトが表示されます。一般的には、これらのオブジェクトをプレハブとして準備する必要があります。インポートされたPLATEAU 3D都市モデルはシーン上にメッシュなどのデータを保持しているため、プレハブ化するためには以下の手順に従う必要があります。

#### 3D都市モデルの汎用3Dファイルへのエクスポート
PLATEAU 3D都市モデルをプレハブ化する最初のステップは、モデルを汎用的な3Dデータ形式へと変換することです。この変換には複数の方法があり、以下にいくつかの主要なエクスポート方法を挙げます。

##### SDKのエクスポート機能の利用
PLATEAU SDKのエクスポート機能を使用することで、CityGMLからFBXやGLTFなどのフォーマットにエクスポートすることが可能です。シーンに埋め込まれているテクスチャも外部ファイルとして出力できます。注意点としてはインポートされたCityGMLから直接変換を行うため、Unityのヒエラルキー上で選択した範囲での出力やシーン上ででメッシュに対して行われた変更は出力できません。

<img width="400" alt="miniature_sample_plateausdk_export_options" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_plateausdk_export_options.png">
<br>

##### Unity公式FBXエクスポーターの利用
Unity公式のFBXエクスポーターを使用すると、Unityで選択したオブジェクトや、Unityで行った変更を含めたモデルの出力が可能になります。この方法では、頂点カラーのペイントやメッシュのマージなど、Unityで加工されたデータをそのまま出力できます。ただし、シーンに埋め込まれたテクスチャはこの方法では出力されないため、建物のテクスチャを出力する場合はSDKのエクスポート機能を使用する必要があります。

<img width="600" alt="miniature_sample_fbxexporter_selection" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_fbxexporter_selection.png">

<img width="600" alt="miniature_sample_fbxexporter_settings" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_fbxexporter_settingss.png">
<br>

## 4-2. モバイル端末を対象にした3D都市モデルの作成
### アートスタイルの選定
今回のサンプル作成では、シンプルかつスタイリッシュな都市模型風のアートスタイルを採用しました。
 
<img width="600" alt="miniature_sample_artstyle" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_artstyle.png">
<br>
 
### 頂点カラーの活用
頂点カラーを応用したグラフィック表現はモバイル端末上でのパフォーマンスを維持しつつ、リッチなビジュアル表現を加えるための確立された手法です。各頂点にカラーデータを割り当て、シェーダーを介して多様な表現を行うことが可能です。

<img width="600" alt="miniature_sample_vertexcolor_result" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_vertexcolor_result.png">
<br>

### ポリゴン数と最適化
ポリゴン数の管理はモバイルアプリケーションのパフォーマンスに直接関係します。建物のモデルにおいては、幅広いモバイル端末での動作を考慮し、約15万トライアングルを目安にしました。

<img width="600" alt="miniature_sample_triangle_count" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_triangle_count.png">
<br>

### 頂点カラーのペイント
今回のサンプルでは、RenderingToolkitの窓の頂点カラーマスク調整機能を使用し、ビルに頂点カラーを一括で割り当てました。
 
<img width="600" alt="miniature_sample_vertexcolor_painting" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_vertexcolor_painting.png">
<br>

### 頂点カラーGチャンネル
グリーンチャンネルは、地物のバウンディングボックスの底から頂上に向かって、白から黒へのグラデーションが塗られています。

<img width="600" alt="miniature_sample_green_channel" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_green_channel.png">
<br>

### 頂点カラーAチャンネル
アルファチャンネルは地物ごとにランダムに割り当てられます。ランダムな値を設定することで、多様な表現を行うことができます。例えば、カラーグラデーションをシェーダーグラフを介して頂点アルファにマッピングすることで、カラフルな街が簡単に作成できます。

<img width="600" alt="miniature_sample_alpha_random" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_alpha_random.png">

<img width="600" alt="miniature_sample_shadergraph_mapping" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_shadergraph_mapping.png">

<img width="600" alt="miniature_sample_gradation_mapping" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_gradation_mapping.png">
<br>

## 4-3. モデルの加工と出力
### 地物の高さの調整とメッシュのマージ
モデルの加工には地物の高さを揃える工程とメッシュのマージが含まれます。これらの工程は、サンプルプロジェクトの Unity エディタメニュー上の "MiniatureViewer" にある専用のツールを介して行われます。これにより、モデルは一貫性のある外観と最適化されたメッシュ構造を持つことができます。

<img width="600" alt="miniature_sample_merge_mesh" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_merge_mesh.png">
<br>

### FBXエクスポーターでの出力
加工が完了したモデルはUnity FBXエクスポーターを使用してFBXフォーマットで出力します。ヒエラルキーからエクスポートするゲームオブジェクトを右クリックし、"Export To FBX" を選択します。
 
<img width="400" alt="miniature_sample_rightclick_export_fbx" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_rightclick_export_fbx.png">
<br>

## 4-4. ライトマップの適用

### ライトマップとは
ライトマップはゲームやアプリケーションのシーンにおける光の影響を事前に計算し、その結果をテクスチャ（画像）として保存する技術です。これにより、実際の光源からの影や光の拡散をリアルタイムに計算する代わりに、予め計算されたライティング効果をシーンに適用することができます。特にモバイル端末のように処理能力が限られている環境では、ライトマップの使用により、リアルタイムレンダリング時の負荷を大幅に軽減できます。

### モバイル端末でのキャストシャドウと処理負荷
モバイル端末では、リアルタイムのキャストシャドウ（影の投射）は大きな処理負荷を伴います。リアルタイムで影を計算することはレンダリングの処理負荷が高く、特に処理能力が限られているモバイル端末には不向きです。このため、ライトマップを利用することが重要となります。

### ライトマップのベイク方法
#### ライトの設定
シーン内に必要な光源を配置し、任意のライティング設定を行います。ライトマップをベイクするためには、FBXファイルの「ライトマップUV」の項目をチェックし、対象のオブジェクトのStaticフラグを有効にします。この設定はオブジェクトにライトマップのデータが適切にマッピングされる為のUVを作成します。

<img width="600" alt="miniature_sample_lightmap_uv" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_lightmap_uv.png">
<img width="600" alt="miniature_sample_lightmap_static" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_lightmap_static.png">
<br>

### ライトマップベイクの実行
ベイクする準備が完了したらライティング設定からライトマップをベイクします。以下の画像はサンプルプロジェクトで用意しているライトマップの設定です。

<img width="600" alt="miniature_sample_lightmap_settings" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_lightmap_settings.png">
<br>

### プレハブへのライトマップ適用
Unityのライトマップはシーン上のオブジェクトを対象としているため標準機能ではプレハブにライトマップを適用する機能はありませんが、拡張スクリプトを作成してプレハブにライトマップの情報を保存することが可能です。この手順により、異なるシーンでベイクされたライティング情報をのオブジェクトを一つのシーンで使うことができます。
`PrefabLightmapData` コンポーネントをプレハブのルートに追加し、Unityエディタメニューから "MiniatureViewer" > "シーンのライトマップをプレハブに設定" を選択してプレハブのライトマップ生成を実行します。

<img width="600" alt="miniature_sample_lightmap_component" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_lightmap_component.png">

<img width="600" alt="miniature_sample_lightmap_bakeprefab" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_lightmap_bakeprefab.png">
<br>

## 4-5. ナビメッシュの作成と人の配置
### ナビメッシュ追加パッケージのインストール
ナビメッシュの基本機能ではナビメッシュのデータはシーン内に保存されるため、プレハブ上でナビメッシュを実行するためには追加のパッケージが必要です。サンプルプロジェクトではすでに追加パッケージがインストールされているため、このプロジェクトを元に改変を行う場合はインストールは必要ありません。別のプロジェクトで追加パッケージのインストールが必要な場合はパッケージマネージャーからインストールを行います。

<img width="600" alt="miniature_sample_ainavigation_url" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_ainavigation_url.png">

<img width="600" alt="miniature_sample_ainavigation_package" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_ainavigation_package.png">

### ナビメッシュのベイク方法
`NavMeshSurface` コンポーネントを空のゲームオブジェクトにアタッチしてベイクします。ナビメッシュは小さすぎるオブジェクトに対応していないので、一時的にミニチュア都市モデルのスケールを拡大してベイクし、その後障害物や侵入させたくないエリアの設定を追加で行います。<br>

<img width="600" alt="miniature_sample_ナビメッシュ_surface_component" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_ナビメッシュ_surface_component.png">

<img width="600" alt="miniature_sample_lightmap_bakeprefab" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_lightmap_bakeprefab.png">
<br>

### サンプルプロジェクトに合わせたナビメッシュ調整
ARでは3D都市モデル全体のスケーリングや回転等の機能が実装されていますが、通常のナビメッシュはこれらに対応していません。専用のカスタムコンポーネントを追加することで、固定位置のナビメッシュからアプリケーション上の3D都市モデルミニチュアオブジェクト上でスポーンするすべてのアバターにトランスフォームの再マッピングを行います。
  
<img width="600" alt="miniature_sample_ナビメッシュ_transform_remapping" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_ナビメッシュ_transform_remapping.png">
<br>

#### 人の配置
ナビメッシュ上に人のモデルを配置し、AR環境内でのリアルタイムインタラクションを提供します。これにより、都市モデルがより現実的で臨場感のあるものになります。

<img width="600" alt="miniature_sample_ナビメッシュ_human" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_ナビメッシュ_human.png">
 <br>