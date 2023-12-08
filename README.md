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

1. 用意したマーカーの画像データをProject内に配置します。エクスプローラーからUnityのProject内の任意のフォルダにドラッグアンドドロップすると追加することができます。
    - サンプルでは "/Assets/Images" の中に "ARMarkerImage.png" が格納されています。

<img width="600" alt="miniature_sample_markerpath" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_markerpath.png">

2. インポートした画像をARマーカーとして登録します。
    - "/Assets" の中にある "ReferencedImageLibrary" を選択してインスペクターを表示し、画像を入れ替えます。
    - TODO: 大きさの設定
    - 登録すると指定したマーカーをスキャンしたときに対象オブジェクトが表示されるようになります。 TODO: ARマーカーの指定が必要
<img width="600" alt="miniature_sample_reflib_before" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_reflibpath.png">

<img width="600" alt="miniature_sample_reflib_before" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_reflib_before.png">

# 4. サンプルプロジェクトで使用しているミニチュア3D都市モデルの構成
ここでは、サンプルプロジェクトで用意している3D都市モデルについて紹介します。

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

<img width="400" alt="miniature_sample_plateausdk_export_options" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_plateausdk_export_options.png">
<br>

##### Unity公式FBXエクスポーターの利用
Unity公式のFBXエクスポーターを使用すると、Unityで選択したオブジェクトや、Unityで行った変更を含めたモデルの出力が可能になります。この方法では、頂点カラーのペイントやメッシュのマージなど、Unityで加工されたデータをそのまま出力できます。ただし、シーンに埋め込まれたテクスチャはこの方法では出力されないため、建物のテクスチャを出力する場合はSDKのエクスポート機能を使用する必要があります。

<img width="600" alt="miniature_sample_fbxexporter_selection" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_fbxexporter_selection.png">

<img width="600" alt="miniature_sample_fbxexporter_settings" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_fbxexporter_settingss.png">
<br>

## 4-2. モバイルデバイスをターゲットにしたミニチュア3D都市モデルの作成
 **アートスタイルの選定**: 今回のサンプル作成においては、シンプルかつスタイリッシュな都市模型風のアートスタイルを採用しました。
 
<img width="600" alt="miniature_sample_artstyle" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_artstyle.png">
<br>
 
**頂点カラーの活用**: 頂点カラーを応用したグラフィック表現はモバイルデバイス上でのパフォーマンスを維持しつつ、リッチなビジュアル表現を加えるための確立された手法です。各頂点にカラーデータを割り当て、シェーダーを介することで多様な表現を行うことが可能です。

<img width="600" alt="miniature_sample_vertexcolor_result" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_vertexcolor_result.png">
<br>

 **ポリゴン数と最適化**: ポリゴン数の管理は、モバイルアプリケーションのパフォーマンスに直接関係します。建物のモデルにおいては、幅広いモバイル端末での動作を考慮し、約15万トライアングルを目安にしました。

<img width="600" alt="miniature_sample_triangle_count" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_triangle_count.png">
<br>

 **頂点カラーのペイント**: 今回のサンプルでは、RenderingToolkitの窓の頂点カラーマスク調整機能を使用し、ビルに頂点カラーを一括で割り当てました。
 
<img width="600" alt="miniature_sample_vertexcolor_painting" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_vertexcolor_painting.png">
<br>

 **頂点カラーGチャンネル**: グリーンチャンネルは、地物のバウンディングボックスの底から頂上に向かって、白から黒へのグラデーションが塗られています。

<img width="600" alt="miniature_sample_green_channel" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_green_channel.png">
<br>

**頂点カラーAチャンネル**: アルファチャンネルは、地物ごとにランダムに割り当てられます。ランダムな値を設定することで、多様な表現を行うことができます。例えば、カラーグラデーションをシェーダーグラフを介して頂点アルファにマッピングすることで、カラフルな街が簡単に作成できます。

<img width="600" alt="miniature_sample_alpha_random" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_alpha_random.png">

<img width="600" alt="miniature_sample_shadergraph_mapping" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_shadergraph_mapping.png">

<img width="600" alt="miniature_sample_gradation_mapping" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_gradation_mapping.png">
<br>

## 4-3. モデルの加工と出力
**地物の高さの調整とメッシュのマージ**: モデルの加工には地物の高さを揃える工程とメッシュのマージが含まれます。これらの工程は、MiniatureViewerメニュー内にある専用のツールを介して行われます。これにより、モデルは一貫性のある外観と最適化されたメッシュ構造を獲得します。

<img width="600" alt="miniature_sample_merge_mesh" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_merge_mesh.png">
<br>

 **FBXエクスポーターでの出力**: 加工が完了したモデルはFBXエクスポーターを使用してFBXフォーマットで出力します。ヒエラルキーでエクスポートするゲームオブジェクト選択後、左クリック > Export To FBX。
 
<img width="400" alt="miniature_sample_rightclick_export_fbx" src="https://github.com/unity-takeuchi/PLATEAU-SDK-AR-Extensions-for-Unity-drafts/blob/main/SampleSceneReadmeImages/AR%20City%20Miniature/miniature_sample_rightclick_export_fbx.png">
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


