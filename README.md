# PLATEAU-Toolkits-Sample-ARCityMiniature
### PLATEAU-SDK-Toolkits-for-Unityを使ったサンプルアプリケーション


### 更新履歴

|  2023/12/13  |  AR City Miniature　初回リリース|
| :--- | :--- |


# 目次

- [1. サンプルシーンの概要](#1-サンプルシーンの概要)
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
 

# 1. サンプルシーンの概要
## 1-1. 体験の概要
このサンプルシーンを使うことで、マーカーを使ったミニチュア都市モデルの表示を行うことができます。<br>
テーブルトップでシティプランニングを行うようなユースケースを想定したアプリです。<br>


## 1-2. Toolkitの利用機能
### Rendering Toolkit
- 窓用の頂点カラー調整

### AR Extensions
- マーカーによる3D都市モデルの配置

# 2. 利用手順
## 2-1. 必要環境
### OS環境
- Windows11
- macOS Ventura 13.2
- Android 13
- iOS 16.7.1

### Unity Version
- Unity 2021.3.31f1 (2023/10/10現在 2021 LTSバージョン)
    - Unity 2021.3系であれば問題なく動作する見込みです。

### Rendering Pipeline
- URP

HDRP, Built-in Rendering Pipelineでは動作しません。<br>

## 2-2. サンプルシーンのビルド方法
①Assets/Scenes/Main.unityを開きます。<br>
②メニューよりFile > Build Settingsを選択します。<br>

<img width="600" alt="miniature_sample_05_projectview" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/7f4ad73c-0ec6-44ab-b718-692f77755783">


③PlatformがAndroidとiOS以外になっている場合は、AndroidもしくはiOSを選択して、画面下部にある「Switch Platform」ボタンを押下し、Platformを切り替えます。<br>

<img width="600" alt="miniature_sample_07_switchplatform" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/15b2282e-a2c9-44eb-8ac9-30612d191d16">


④画面下部にある「Build」ボタンを押下します。<br>
出力先を選択してビルドを開始します（iOSの場合はフォルダ、Androidの場合は.apkファイルもしくはAndroid Gradleプロジェクト）。

ビルドが完了したら、各プラットフォームに合わせて端末へアプリケーションをインストールしてください。

<img width="600" alt="miniature_sample_06_buildsettings" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/44656cdd-a094-4b31-89a3-cf2b76b19089">


## 2-3. ビルドしたアプリケーションの操作方法
①ビルドしたアプリケーションを開くと、オープニング画面が表示されます。<br>
「始めましょう」のボタンをタップすると、ARによるスキャン画面に遷移します。<br>


<img width="600" alt="miniature_sample_01_title" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/292f15c3-1b9c-47d6-ab53-956dd3c7d85d">


②マーカースキャン画面に遷移するとARカメラがオンになるので、対象となるマーカーをカメラでスキャンしてください。<br>

<img width="600" alt="miniature_sample_02_markerscan" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/db7e55b0-3ee8-4899-8a28-f41ba183f364">



するとミニチュアサイズの3D都市モデルが表示されます。

<img width="600" alt="miniature_sample_miniature_app" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/8748d204-6f08-4299-8fdc-286cee92a209">

③画面右側に表示されるスケールバーを調整すると、3D都市モデルの大きさを変更することができます。<br>
画面右側に表示される回転バーを調整すると、3D都市モデルを回転することができます。<br>


# 3. サンプルシーンのカスタマイズ方法
## 3-1. 自分でPLATEAUモデルをインポートしたい時

①PLATEAU SDKを使って、サンプルシーン内に3D都市モデルをインポートします。<br>
モバイルアプリ向けの3D都市モデルの最適化の手順については次章の[4. サンプルミニチュア都市モデルのメイキング](#4-サンプルミニチュア都市モデルのメイキング)をご参照ください。

②ヒエラルキーに３D都市モデルを追加したら, prefabを作成します。<br>
Project内の任意のフォルダにドラッグアンドドロップするとprefabを作成することができます。<br>
prefabの名前は任意です。（Sampleの例だと"MiniatureCityModels"としています。）


<img width="600" alt="miniature_sample_makeprefab" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/341a86a3-12b0-43cf-8052-7a45e210af2b">



③Prefabを作成したらマーカー上に表示するための設定をします。シーン中にあるAR Session Originを選択し、アタッチされている"AR Tracked Image Manager"のTracked Image Prefab"のPrefabを作成したPrefabに入れ替えます。<br>


<img width="600" alt="miniature_sample_arsession_pos" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/5bef215c-c7ad-485d-a093-9f291ca05b52">


<img width="600" alt="miniature_sample_makeprefab" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_imageprefab.png">



## 3-2. 自分で作ったマーカーを入れたいとき

①用意したマーカーの画像データをProject内に配置します。エクスプローラーからUnityのProject内の任意のフォルダにドラッグアンドドロップすると追加することができます。<br>
サンプルでは/Assets/Imagesの中にARMarkerImage.pngが格納されています。<br>


<img width="600" alt="miniature_sample_markerpath" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/98328083-8e52-4f03-9ecb-f9f85b2196c9">


②インポートした画像をARマーカーとして登録します。<br>
/Assets/の中にあるReferencedImageLibraryを選択し、画像を入れ替えます。


<img width="600" alt="miniature_sample_reflibpath" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/e23457b7-4b5f-4e14-83c1-0d1c06e5c540">


<img width="600" alt="miniature_sample_reflib_before" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/9174f57e-d0c6-4ee5-afaf-9fd86b39d291">



登録すると指定したマーカーをスキャンしたときに対象オブジェクトが表示されるようになります。

# 4. サンプルミニチュア3D都市モデルのメイキング
モバイルアプリで3D都市モデルを使用する際には、3D都市モデルを最適化することでパフォーマンスを向上できます。<br>
また、カラーの設定を行うことでモデルの審美性を高めることができます。<br>
具体的な手順は以下の通りです。<br>

## 4-1. 3D都市モデルのプレハブ化
- **SDKのエクスポート機能による出力**: CityGMLからFBXやGLTFへのエクスポート
- **UnityのFBX Exporterによる出力**: 選択したメッシュのエクスポート

### 3D都市都市モデルのプレハブ化
#### テーブルトップARアプリケーションと3D都市モデル
テーブルトップのARアプリケーションでは、ARマーカーをスキャンすると対応するオブジェクトが表示されます。一般的には、これらのオブジェクトをプレハブとして準備する必要があります。Plateauの3D都市モデルは元々シーンに強く紐づいているため、これをプレハブ化する工程について説明します。

#### 3D都市モデルの汎用3Dファイルへのエクスポート
Plateauモデルをプレハブ化する最初のステップは、モデルを汎用的な3Dデータ形式へと変換することです。この変換には複数の方法があり、以下にいくつかの主要なエクスポート方法を挙げます。

##### SDKのエクスポート機能の利用
PLATEAUSDKのエクスポート機能を使用することで、CityGMLからFBXやGLTFなどのフォーマットにエクスポートすることが可能です。シーンに埋め込まれているテクスチャも外部ファイルとして出力できます。注意点としてはCityGMLから直接変換するため、Unityで選択した範囲での出力やUnity内でメッシュに対して行われた変更は出力できません。

<img width="400" alt="miniature_sample_plateausdk_export_options" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/0184b22e-856d-4bd9-9665-9774773c9989">
<br>

##### Unity公式FBXエクスポーターの利用
Unity公式のFBXエクスポーターを使用すると、Unityで選択したオブジェクトや、Unityで行った変更を含めたモデルの出力が可能になります。この方法では、頂点カラーのペイントやメッシュのマージなど、Unityで加工されたデータをそのまま出力できます。ただし、シーンに埋め込まれたテクスチャはこの方法では出力されないため、建物のテクスチャを出力する場合はSDKのエクスポート機能を使用する必要があります。


<img width="600" alt="miniature_sample_fbxexporter_selection" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/fff65e52-6afa-4cf0-8bf5-3392e7859206">

<img width="600" alt="miniature_sample_fbxexporter_settings" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/3ba14f7f-3e65-4745-ae7c-3c910e57fd52">
<br>

## 4-2. モバイルデバイスをターゲットにしたミニチュア3D都市モデルの作成
 **アートスタイルの選定**: 今回のサンプル作成においては、シンプルかつスタイリッシュな都市模型風のアートスタイルを採用しました。
 
<img width="600" alt="miniature_sample_artstyle" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/cf86a7ed-d3be-4623-9b0a-727cd93fbf30">
<br>
 
**頂点カラーの活用**: 頂点カラーを応用したグラフィック表現はモバイルデバイス上でのパフォーマンスを維持しつつ、リッチなビジュアル表現を加えるための確立された手法です。各頂点にカラーデータを割り当て、シェーダーを介することで多様な表現を行うことが可能です。

<img width="600" alt="miniature_sample_vertexcolor_result" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/a1624ed3-d81f-4a4c-b834-035b15fb46e9">
<br>

 **ポリゴン数と最適化**: ポリゴン数の管理は、モバイルアプリケーションのパフォーマンスに直接関係します。建物のモデルにおいては、幅広いモバイル端末での動作を考慮し、約15万トライアングルを目安にしました。


<img width="600" alt="miniature_sample_triangle_count" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/7075432e-9567-4faf-a7ea-476ab22e379d">
<br>

 **頂点カラーのペイント**: 今回のサンプルでは、RenderingToolkitの窓の頂点カラーマスク調整機能を使用し、ビルに頂点カラーを一括で割り当てました。



<img width="600" alt="miniature_sample_vertexcolor_painting" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/f0932a41-1c36-4ae0-a1c6-c65c6bb301df">
<br>

 **頂点カラーGチャンネル**: グリーンチャンネルは、地物のバウンディングボックスの底から頂上に向かって、白から黒へのグラデーションが塗られています。


<img width="600" alt="miniature_sample_green_channel" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/aa750068-15ee-444d-8ad7-a4d386ce5761">
<br>

**頂点カラーAチャンネル**: アルファチャンネルは、地物ごとにランダムに割り当てられます。ランダムな値を設定することで、多様な表現を行うことができます。例えば、カラーグラデーションをシェーダーグラフを介して頂点アルファにマッピングすることで、カラフルな街が簡単に作成できます。


<img width="600" alt="miniature_sample_alpha_random" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/14a98e2f-29b4-4b3e-9bd4-0e6e65aac595">


<img width="600" alt="miniature_sample_shadergraph_mapping" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/db8be143-77ae-4888-9b65-34669315f9f9">


<img width="600" alt="miniature_sample_gradation_mapping" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/ed97e5c1-560d-40c2-b7bd-c40f10df9f39">
<br>

## 4-3. モデルの加工と出力
**地物の高さの調整とメッシュのマージ**: モデルの加工には地物の高さを揃える工程とメッシュのマージが含まれます。これらの工程は、MiniatureViewerメニュー内にある専用のツールを介して行われます。これにより、モデルは一貫性のある外観と最適化されたメッシュ構造を獲得します。

<img width="600" alt="miniature_sample_merge_mesh" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/317fc81b-f33b-4fbc-a5ed-4be0aeb33faf">

<br>

 **FBXエクスポーターでの出力**: 加工が完了したモデルはFBXエクスポーターを使用してFBXフォーマットで出力します。ヒエラルキーでエクスポートするゲームオブジェクト選択後、左クリック > Export To FBX。
 
<img width="400" alt="miniature_sample_rightclick_export_fbx" src="https://github.com/unity-shimizu/PLATEAU-Toolkits-Sample-ARCityMiniature/assets/137732437/f9d2f7fa-14e5-4924-bc7c-5d709d375ae">

<br>

## 4-4. ライトマップの適用

### ライトマップとは
ライトマップは、ゲームやアプリケーションのシーンにおける光の影響を事前に計算し、その結果をテクスチャ（画像）として保存する技術です。これにより、実際の光源からの影や光の拡散をリアルタイムに計算する代わりに、予め計算されたライティング効果をシーンに適用することができます。特にモバイル端末のように処理能力が限られている環境では、ライトマップの使用により、リアルタイムレンダリング時の負荷を大幅に軽減できます。

### モバイル端末でのキャストシャドウと処理負荷
モバイルデバイスでは、リアルタイムのキャストシャドウ（影の投射）は大きな処理負荷を伴います。リアルタイムで影を計算することはレンダリングの処理負荷が高く、特に処理能力が限られているモバイル端末には不向きです。このため、ライトマップを利用することが重要となります。

### ライトマップのベイク方法
ライトの設定:
まず、シーン内に必要な光源を配置し、それぞれの設定を行います。ライトマップをベイクするための基本的な設定には、FBXファイルの「ライトマップUV」の項目をチェックし、対象のオブジェクトのStaticフラグをONにします。この設定はオブジェクトにライトマップのデータが適切にマッピングされる為のUVを作成します。

<img width="600" alt="miniature_sample_lightmap_uv" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_lightmap_uv.png">
<img width="600" alt="miniature_sample_lightmap_static" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_lightmap_static.png">
<br>


### ライトマップベイクの実行
ベイクする準備が完了したライティング設定からライトマップをベイクします。今回のシーンのライトマップの設定になります。

<img width="600" alt="miniature_sample_lightmap_settings" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_lightmap_settings.png">
<br>

### プレハブへのライトマップ適用
Unityのライトマップはシーンに紐づいており、標準機能ではプレハブにライトマップを適用する機能はありませんが、拡張スクリプトを作成し、プレハブにライトマップの情報を保存することは可能です。このプロセスにより、異なるシーンでベイクされたライティング情報をのオブジェクトを一つのシーンで使うことができます。
PrefabLightmapDataコンポーネントをプレハブのルートに追加して、(メニュー > MiniatureViewer > シーンのライトマップをプレハブに設定) を実行します。

<img width="600" alt="miniature_sample_lightmap_component" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_lightmap_component.png">

<img width="600" alt="miniature_sample_lightmap_bakeprefab" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_lightmap_bakeprefab.png">
<br>

## 4-5. Navmeshの作成と人の配置
**Navmesh追加パッケージのインストール**: 通常のNavmeshはシーンに紐づいているため、プレハブ上でNavmeshを実行するための追加パッケージが必要です。追加パッケージのインストールはパッケージマネージャーから行います。

<img width="600" alt="miniature_sample_ainavigation_url" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_ainavigation_url.png">

<img width="600" alt="miniature_sample_ainavigation_package" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_ainavigation_package.png">
<br>

### Navmeshのベイク方法
NavmeshSurfaceコンポーネントを空のゲームオブジェクトにアタッチしてベイクします。ナブメッシュは小さすぎるオブジェクトに対応していないので、一旦ミニチュア都市モデルをリアルスケールに拡大してベイクし、その後障害物や侵入させたくないエリアの設定を追加で行います。<br>

<img width="600" alt="miniature_sample_navmesh_surface_component" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_navmesh_surface_component.png">

<img width="600" alt="miniature_sample_lightmap_bakeprefab" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_lightmap_bakeprefab.png">
<br>

### ARミニチュア表示アプリに合わせたNavmesh調整
ARでは都市全体のスケーリングや回転等の機能が実装されており、通常のNavmeshはこれらに対応していません。専用のカスタムコンポーネントを追加することで、固定位置のナブメッシュからミニチュア都市でスポーンする群衆にトランスフォームの再マッピングを行います。
  
<img width="600" alt="miniature_sample_navmesh_transform_remapping" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_navmesh_transform_remapping.png">
<br>

 **人の配置**:Navmesh上に人のモデルを配置し、AR環境内でのリアルタイムインタラクションを提供します。これにより、都市モデルがより現実的で生活感のあるものになります。

<img width="600" alt="miniature_sample_navmesh_human" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_navmesh_human.png">
 <br>


