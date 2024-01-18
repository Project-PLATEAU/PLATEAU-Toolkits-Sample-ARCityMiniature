# PLATEAU-Toolkits-Sample-ARCityMiniature
PLATEAU SDK-Toolkits for Unityを使ったサンプルアプリケーション

## 更新履歴

|  2023/12/13  |  AR City Miniature 初回リリース|
| :--- | :--- |

# 目次

- [1. サンプルプロジェクトの概要](#1-サンプルプロジェクトの概要)
  - [1-1. サンプルプロジェクトで体験できること](#1-1-サンプルプロジェクトで体験できること)
  - [1-2. Unityプロジェクト情報](#1-2-Unityプロジェクト情報)
  - [1-3. 利用している PLATEAU SDK-Toolkits の機能](#1-2-利用している-PLATEAU-SDK-Toolkits-の機能)
- [2. 利用手順](#2-利用手順)
  - [2-1. 推奨環境](#2-1-推奨環境)
  - [2-2. サンプルプロジェクトのビルド方法](#2-2-サンプルプロジェクトのビルド方法)
  - [2-3. ビルドしたアプリケーションの操作方法](#2-3-ビルドしたアプリケーションの操作方法)
- [3. サンプルプロジェクトのカスタマイズ方法](#3-サンプルプロジェクトのカスタマイズ方法)
  - [3-1. 任意のPLATEAU 3D都市モデルをインポートしたい場合](#3-1-任意のPLATEAU-3D都市モデルをインポートしたい場合)
  - [3-2. ARマーカーに使用する画像を変更したい場合](#3-2-ARマーカーに使用する画像を変更したい場合)
- [4. サンプルプロジェクトで使用しているミニチュア3D都市モデルの構成手順](#4-サンプルプロジェクトで使用しているミニチュア3D都市モデルの構成手順)
  - [4-1. 3D都市モデルのプレハブ化](#4-1-3D都市モデルのプレハブ化)
  - [4-2. モバイル端末を対象にした3D都市モデルの作成](#4-2-モバイル端末を対象にした3D都市モデルの作成)
  - [4-3. モデルの加工と出力](#4-3-モデルの加工と出力)
  - [4-4. ライトマップの適用](#4-4-ライトマップの適用)
  - [4-5. ナビメッシュの作成と人の配置](#4-5-ナビメッシュの作成と人の配置)
- [ライセンス](#ライセンス)
- [注意事項/利用規約](#注意事項利用規約)

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

## 1-3. 利用している PLATEAU SDK-Toolkits の機能
### PLATEAU SDK Rendering Toolkit
- 窓用の頂点カラー調整

### PLATEAU SDK AR Extensions
- ARマーカーを用いた3D都市モデルの位置合わせ機能

### PLATEAU SDK Utilities
- メッシュレンダラーの選択機能
- メッシュ頂点の平面化機能
- 選択地物の整列機能
- シーンのライトマップをプレハブに設定する機能

# 2. 利用手順
## 2-1. 推奨環境
### 参考開発環境
以下は本プロジェクトに使用した開発環境です。

- Windows11
- macOS Ventura 13.2
- Android 13
- iOS 16.7.1

## 2-2. サンプルプロジェクトのビルド方法
1. メニューより "File" > "Build Settings" を選択し Build Settings ウィンドウを表示します。
<img width="600" alt="miniature_sample_05_projectview" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/blob/manual/images/SampleSceneReadmeImages/ARCityMiniature/miniature_sample_05_projectview.png">

2. プラットフォームがAndroidかiOS以外になっている場合は、アプリケーションを動作させる端末に合わせてプラットフォームを選択し、画面下部にある「Switch Platform」ボタンからプラットフォームを切り替えます。<br>

3. Build Settings ウィンドウの画面下部にある「Build」ボタンを押下し、ビルドの出力先を選択してビルドを開始します。iOSの場合は Xcode プロジェクト、Androidの場合は .apk ファイルもしくはAndroid Gradleプロジェクトを生成します。<br />
ビルドが完了したら、各プラットフォームに合わせて端末へアプリケーションをインストールしてください。

<img width="600" alt="miniature_sample_07_switchplatform" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/15b2282e-a2c9-44eb-8ac9-30612d191d16">

## 2-3. ビルドしたアプリケーションの操作方法
1. ビルドしたアプリケーションを端末で開くと、オープニング画面が表示されます。<br>
「始めましょう」のボタンをタップすると、ARマーカー読み取り画面に遷移します。<br>

<img width="600" alt="miniature_sample_01_title" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/292f15c3-1b9c-47d6-ab53-956dd3c7d85d">

2. ARマーカー読み取り画面で対象のARマーカーをカメラで読み取る（ARマーカーをカメラで写す）と、ARマーカー上にPLATEAU 3D都市モデルのミニチュアオブジェクトが表示されます。<br>

<img width="600" alt="miniature_sample_02_markerscan" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/blob/manual/images/SampleSceneReadmeImages/ARCityMiniature/miniature_sample_arscan.jpg">

<img width="600" alt="miniature_sample_miniature_app" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/8748d204-6f08-4299-8fdc-286cee92a209">

3. ミニチュアオブジェクトを表示すると、画面上にミニチュアオブジェクトを操作できるUIが表示されます。画面右側に表示されるスケールバーを調整することで3D都市モデルの大きさを変更することができ、画面下側に表示される回転バーを調整すると、3D都市モデルを回転させることができます。

# 3. サンプルプロジェクトのカスタマイズ方法
本サンプルプロジェクトを元に、表示させる3D都市モデルの変更などを行いたい場合は以下を参考にサンプルプロジェクトを改変して利用してください。

## 3-1. 任意のPLATEAU 3D都市モデルをインポートしたい場合

1. PLATEAU SDKを使って、任意のシーン内に3D都市モデルをインポートします。
    - 以降の手順では一時的に3D都市モデルをシーンにインポートしてFBXに変換します。
    - モバイル端末上で3D都市モデルを表示する場合は、大きさなどによって最適化が必要になる場合があります。モバイルアプリ向けの3D都市モデルの最適化の手順については次章の [4. サンプルミニチュア都市モデルのメイキング](#4-サンプルミニチュア都市モデルのメイキング) を参照してください。

2. インポートの完了後、PLATEAU SDK を使用し、インポートした3D都市モデルを FBX ファイルとしてプロジェクトに保存します。

3. シーン上に新規のゲームオブジェクトを作成し、その中に保存した FBX ファイルをドラッグアンドドロップで子オブジェクトとして追加します。
    - このオブジェクトがARマーカー上に表示される3D都市モデルオブジェクトの本体になります。
    - 分かりやすさのため、ゲームオブジェクトはインポートした場所の名前などを設定してください。

3. 作成したゲームオブジェクトをもとにプレハブを作成します。
    - ヒエラルキーからプロジェクト内の任意のフォルダにゲームオブジェクトをドラッグアンドドロップすることでプレハブを作成することができます。

4. プロジェクトから "Assets/Prefabs/MiniatureCityModels" を選択し、"MiniatureCityModels" プレハブのインスペクターを開きます。

5. `City Models` フィールド内の `City Model Prefab` に作成したプレハブを設定してください。


<img width="600" alt="miniature_sample_makeprefab" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/341a86a3-12b0-43cf-8052-7a45e210af2b">

<img width="600" alt="miniature_sample_arsession_pos" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/5bef215c-c7ad-485d-a093-9f291ca05b52">

<img width="600" alt="miniature_sample_makeprefab" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_imageprefab.png">

## 3-2. ARマーカーに使用する画像を変更したい場合

1. 用意したARマーカーの画像ファイルをプロジェクトに追加します。
    - UnityではOSのファイルシステム（Windows エクスプローラー / macOS Finder）からUnityエディタのプロジェクト内の任意のフォルダに画像ファイルをドラッグアンドドロップすることでアセットをインポートできます。
    - サンプルでは "/Assets/Images" の中に "ARMarkerImage.png" が格納されています。

<img width="600" alt="miniature_sample_markerpath" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/98328083-8e52-4f03-9ecb-f9f85b2196c9">


2. インポートした画像をARマーカーとして登録します。
    - "/Assets" の中にある "ReferencedImageLibrary" を選択してインスペクターを表示し、 "Add Image" を押下してARマーカー画像データを追加します。
    - プロジェクトにインポートした画像アセットをARマーカーのテクスチャに設定します。
    - ARマーカー名はファイル名から自動で設定されますが、任意の名前を設定することが可能です。
    - ARマーカー画像は現実空間に配置する大きさをメートル単位で指定する必要があります。印刷するARマーカー画像の大きさなどに合わせて大きさを設定してください。
    - "Assets/Prefabs/MiniatureCityModels" のインスペクタから、追加したARマーカーに紐付ける `City Models` の `ARMarkerName` に設定したARマーカー名を指定してください。

3. Unity プロジェクトをビルドし、用意したARマーカーを読み取ると、紐づけられた3D都市モデルオブジェクトが表示されます。

<img width="600" alt="miniature_sample_reflibpath" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/e23457b7-4b5f-4e14-83c1-0d1c06e5c540">


<img width="600" alt="miniature_sample_reflib_before" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/9174f57e-d0c6-4ee5-afaf-9fd86b39d291">

# 4. サンプルプロジェクトで使用しているミニチュア3D都市モデルの構成手順
ここでは、サンプルプロジェクトで用意している3D都市モデルの構成手順について紹介します。任意の3D都市モデルを導入して同じような演出を行いたい場合は以下の手順を参考にアセットを作成してください。

主にサンプルプロジェクトでは以下のような調整を3D都市モデルに実装しています。
- モバイル端末でも快適に動作するように3D都市モデルを最適化しています。
- モバイル端末でのパフォーマンスを考慮した上で、頂点カラーやライトマップを設定することでモデルの審美性を高めています。
- 臨場感のある3D都市モデルを演出するために、ナビゲーション ([ナビメッシュ](https://docs.unity3d.com/ja/2021.3/Manual/nav-Buildingnavmesh.html)) を導入して都市を移動するアバターを追加しています。

## 4-1. 3D都市モデルのプレハブ化

3D都市モデルをプレハブ化するためには、以下のような機能を利用することで3D都市モデルのプレハブを作成することができます。

- **PLATEAU SDK**: シーンにインポートした3D都市モデルのからFBXやGLTFへのエクスポート
- **Unity公式FBXエクスポーター**: シーン上で選択したメッシュのエクスポート

### サンプルプロジェクトと3D都市モデル
サンプルプロジェクトでは、ARマーカーを読み取ると対応するオブジェクトが表示されます。サンプルプロジェクトの構成では、これらのオブジェクトをプレハブとして準備する必要があります。インポートされたPLATEAU 3D都市モデルはシーン上にメッシュなどのデータを保持しているため、プレハブ化するためには以下の手順に従う必要があります。

### 3D都市モデルの汎用3Dファイルへのエクスポート
PLATEAU 3D都市モデルをプレハブ化する最初のステップは、モデルを汎用的な3Dデータ形式へと変換することです。この変換には複数の方法があり、以下にいくつかの主要なエクスポート方法を挙げます。

#### PLATEAU SDKのエクスポート機能の利用
PLATEAU SDKのエクスポート機能を使用することで、シーンにインポートした3D都市モデルオブジェクトからFBXやGLTFなどのフォーマットでプレハブをエクスポートすることが可能です。この際、シーンに埋め込まれているテクスチャも外部ファイルとして出力できます。ただし、インポートされた3D都市モデルの持つCityGMLを元に変換を行うため、Unityのヒエラルキー上で選択した範囲での出力やシーン上ででメッシュに対して行われた変更は出力できません。

<img width="400" alt="miniature_sample_plateausdk_export_options" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/0184b22e-856d-4bd9-9665-9774773c9989">

#### Unity公式FBXエクスポーターの利用
Unity公式のFBXエクスポーターを使用すると、Unityで選択したオブジェクトや、Unityで行った変更を含めたモデルの出力が可能になります。この方法では、頂点カラーのペイントやメッシュのマージなど、Unityで加工されたデータをそのまま出力できます。ただし、シーンに埋め込まれたテクスチャはこの方法では出力されないため、建物のテクスチャを出力する場合はPLATEAU SDKのエクスポート機能を使用する必要があります。

<img width="600" alt="miniature_sample_fbxexporter_selection" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/fff65e52-6afa-4cf0-8bf5-3392e7859206">

<img width="600" alt="miniature_sample_fbxexporter_settings" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/3ba14f7f-3e65-4745-ae7c-3c910e57fd52">


## 4-2. モバイル端末を対象にした3D都市モデルの作成
### アートスタイルの選定
今回のサンプル作成では、シンプルかつスタイリッシュな都市模型風のアートスタイルを採用しました。
 
<img width="600" alt="miniature_sample_artstyle" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/cf86a7ed-d3be-4623-9b0a-727cd93fbf30">
 
### 頂点カラーの活用
頂点カラーを応用したグラフィック表現はモバイル端末上でのパフォーマンスを維持しつつ、リッチなビジュアル表現を加えるための確立された手法です。各頂点にカラーデータを割り当て、シェーダーを介して多様な表現を行うことが可能です。

<img width="600" alt="miniature_sample_vertexcolor_result" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/a1624ed3-d81f-4a4c-b834-035b15fb46e9">

### ポリゴン数と最適化
ポリゴン数の管理はモバイルアプリケーションのパフォーマンスに直接関係します。建物のモデルにおいては、幅広いモバイル端末での動作を考慮し、約15万トライアングルを目安にしました。

<img width="600" alt="miniature_sample_triangle_count" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/7075432e-9567-4faf-a7ea-476ab22e379d">

### 頂点カラーのペイント
今回のサンプルでは、RenderingToolkitの窓の頂点カラーマスク調整機能を使用し、ビルに頂点カラーを一括で割り当てました。
 
<img width="600" alt="miniature_sample_vertexcolor_painting" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/f0932a41-1c36-4ae0-a1c6-c65c6bb301df">

### 頂点カラーGチャンネル
グリーンチャンネルは、地物のバウンディングボックスの底から頂上に向かって、白から黒へのグラデーションが塗られています。

<img width="600" alt="miniature_sample_green_channel" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/aa750068-15ee-444d-8ad7-a4d386ce5761">

### 頂点カラーAチャンネル
アルファチャンネルは地物ごとにランダムに割り当てられます。ランダムな値を設定することで、多様な表現を行うことができます。例えば、カラーグラデーションをシェーダーグラフを介して頂点アルファにマッピングすることで、カラフルな街が簡単に作成できます。

<img width="600" alt="miniature_sample_alpha_random" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/14a98e2f-29b4-4b3e-9bd4-0e6e65aac595">


<img width="600" alt="miniature_sample_shadergraph_mapping" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/db8be143-77ae-4888-9b65-34669315f9f9">


<img width="600" alt="miniature_sample_gradation_mapping" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/ed97e5c1-560d-40c2-b7bd-c40f10df9f39">

## 4-3. モデルの加工と出力
### 地物の高さの調整とメッシュのマージ
モデルの加工には地物の高さを揃える工程とメッシュのマージが含まれます。これらの工程は、サンプルプロジェクトの Unity エディタメニュー上の "MiniatureViewer" にある専用のツールを介して行われます。これにより、モデルは一貫性のある外観と最適化されたメッシュ構造を持つことができます。

<img width="600" alt="miniature_sample_merge_mesh" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/317fc81b-f33b-4fbc-a5ed-4be0aeb33faf">

### FBXエクスポーターでの出力
加工が完了したモデルはUnity FBXエクスポーターを使用してFBXフォーマットで出力します。ヒエラルキーからエクスポートするゲームオブジェクトを右クリックし、"Export To FBX" を選択します。
 
<img width="400" alt="miniature_sample_rightclick_export_fbx" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/127069970/77903075-2074-4277-a886-1f17a9a3c63e">


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

### ライトマップベイクの実行
ベイクする準備が完了したらライティング設定からライトマップをベイクします。以下の画像はサンプルプロジェクトで用意しているライトマップの設定です。

<img width="600" alt="miniature_sample_lightmap_settings" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_lightmap_settings.png">

### プレハブへのライトマップ適用
Unityのライトマップはシーン上のオブジェクトを対象としているため標準機能ではプレハブにライトマップを適用する機能はありませんが、拡張スクリプトを作成してプレハブにライトマップの情報を保存することが可能です。この手順により、異なるシーンでベイクされたライティング情報をのオブジェクトを一つのシーンで使うことができます。
`PrefabLightmapData` コンポーネントをプレハブのルートに追加し、Unityエディタメニューから "MiniatureViewer" > "シーンのライトマップをプレハブに設定" を選択してプレハブのライトマップ生成を実行します。

<img width="600" alt="miniature_sample_lightmap_component" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_lightmap_component.png">

<img width="600" alt="miniature_sample_lightmap_bakeprefab" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_lightmap_bakeprefab.png">

## 4-5. ナビメッシュの作成と人の配置
### ナビメッシュ追加パッケージのインストール
ナビメッシュの基本機能ではナビメッシュのデータはシーン内に保存されるため、プレハブ上でナビメッシュを実行するためには追加のパッケージが必要です。サンプルプロジェクトではすでに追加パッケージがインストールされているため、このプロジェクトを元に改変を行う場合はインストールは必要ありません。別のプロジェクトで追加パッケージのインストールが必要な場合はパッケージマネージャーからインストールを行います。

<img width="600" alt="miniature_sample_ainavigation_url" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_ainavigation_url.png">

<img width="600" alt="miniature_sample_ainavigation_package" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_ainavigation_package.png">

### ナビメッシュのベイク方法
`NavMeshSurface` コンポーネントを空のゲームオブジェクトにアタッチしてベイクします。ナビメッシュは小さすぎるオブジェクトに対応していないので、一時的にミニチュア都市モデルのスケールを拡大してベイクし、その後障害物や侵入させたくないエリアの設定を追加で行います。<br>

<img width="600" alt="miniature_sample_ナビメッシュ_surface_component" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_navmesh_surface_component.png">

<img width="600" alt="miniature_sample_lightmap_bakeprefab" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_lightmap_bakeprefab.png">

### サンプルプロジェクトに合わせたナビメッシュ調整
ARでは3D都市モデル全体のスケーリングや回転等の機能が実装されていますが、通常のナビメッシュはこれらに対応していません。専用のカスタムコンポーネントを追加することで、固定位置のナビメッシュからアプリケーション上の3D都市モデルミニチュアオブジェクト上でスポーンするすべてのアバターにトランスフォームの再マッピングを行います。
  
<img width="600" alt="miniature_sample_ナビメッシュ_transform_remapping" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_navmesh_transform_remapping.png">

#### 人の配置
ナビメッシュ上に人のモデルを配置し、AR環境内でのリアルタイムインタラクションを提供します。これにより、都市モデルがより現実的で臨場感のあるものになります。

<img width="600" alt="miniature_sample_ナビメッシュ_human" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_navmesh_human.png">


# ライセンス
- 本リポジトリはMITライセンスで提供されています。
- 本システムの開発はユニティ・テクノロジーズ・ジャパン株式会社が行っています。
- ソースコードおよび関連ドキュメントの著作権は国土交通省に帰属します。

# 注意事項/利用規約
- 本ツールはベータバージョンです。バグ、動作不安定、予期せぬ挙動等が発生する可能性があり、動作保証はできかねますのでご了承ください。
- 本ツールをアンインストールした場合、本ツールの機能で作成されたアセットの動作に不備が発生する可能性があります。
- 本ツールをアップデートした際は、一度 Unity エディターを再起動することを推奨しています。
- パフォーマンスの観点から、3km²の範囲に収まる3D都市モデルをダウンロード・インポートすることを推奨しています。
- インポートする範囲の広さや地物の種類（建物、道路、災害リスクなど）が量に比例して処理負荷が高くなる可能性があります。
- 本リポジトリの内容は予告なく変更・削除される可能性があります。
- 本リポジトリの利用により生じた損失及び損害等について、国土交通省はいかなる責任も負わないものとします。
