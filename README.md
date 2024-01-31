# PLATEAU-Toolkits-Sample-ARCityMiniature
## PLATEAU SDK-Toolkits for Unityを使ったサンプルアプリケーション ##
<img width="1080" alt="ar_city_miniature_kv" src="/Documentation~/Images/ar_city_miniature_kv.png">


## 更新履歴

|  2024/01/30  |  AR City Miniature 初回リリース|
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
<img width="600" alt="miniature_sample_05_projectview" src="/Documentation~/Images/miniature_sample_05_projectview.png">

2. プラットフォームがAndroidかiOS以外になっている場合は、アプリケーションを動作させる端末に合わせてプラットフォームを選択し、画面下部にある「Switch Platform」ボタンからプラットフォームを切り替えます。<br>

3. Build Settings ウィンドウの画面下部にある「Build」ボタンを押下し、ビルドの出力先を選択してビルドを開始します。iOSの場合は Xcode プロジェクト、Androidの場合は .apk ファイルもしくはAndroid Gradleプロジェクトを生成します。<br />
ビルドが完了したら、各プラットフォームに合わせて端末へアプリケーションをインストールしてください。

<img width="600" alt="miniature_sample_07_switchplatform" src="/Documentation~/Images/miniature_sample_07_switchplatform.png">

## 2-3. ビルドしたアプリケーションの操作方法
1. ビルドしたアプリケーションを端末で開くと、オープニング画面が表示されます。<br>
「始めましょう」のボタンをタップすると、ARマーカー読み取り画面に遷移します。<br>

<img width="600" alt="miniature_sample_01_title" src="/Documentation~/Images/miniature_sample_01_title.png">

2. ARマーカー読み取り画面で対象のARマーカーをカメラで読み取る（ARマーカーをカメラで写す）と、ARマーカー上にPLATEAU 3D都市モデルのミニチュアオブジェクトが表示されます。<br>

<img width="600" alt="miniature_sample_02_markerscan" src="/Documentation~/Images/miniature_sample_arscan.jpg">

<img width="600" alt="miniature_sample_miniature_app" src="/Documentation~/Images/miniature_sample_miniature_app.png">

ARマーカー画像は以下のものがデフォルトで使用されています。印刷してお使いください。
<img width="400" alt="miniature_sample_armarker" src="/Documentation~/Images/miniature_sample_armarker.png">

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

3. 保存した3D都市モデルをヒエラルキーの MiniatureCityPivot の中に配置します。
<img width="600" alt="miniature_place_fbx" src="/Documentation~/Images/miniature_place_fbx.png">
4. シーンビューでマーカーの位置にマーカー画像が表示されるので、表示させたいデフォルトの大きさや位置・回転を調整します。
5. 大きさや位置・回転の調整が終わったらゲームオブジェクトを非アクティブにします。
<img width="600" alt="miniature_disable_object" src="/Documentation~/Images/miniature_disable_object.png">
6. MiniatureCityModels にアタッチされている `Plateau AR Marker City Model` をインスペクターで表示します。
7. `都市モデルオブジェクト` に追加した3D都市モデルを指定します。
<img width="600" alt="miniature_specify_citymodel" src="/Documentation~/Images/miniature_specify_citymodel.png">

## 3-2. ARマーカーに使用する画像を変更したい場合

1. 用意したARマーカーの画像ファイルをプロジェクトに追加します。
    - UnityではOSのファイルシステム（Windows エクスプローラー / macOS Finder）からUnityエディタのプロジェクト内の任意のフォルダに画像ファイルをドラッグアンドドロップすることでアセットをインポートできます。
    - サンプルでは "/Assets/Images" の中に "ARMarkerImage.png" が格納されています。

<img width="600" alt="miniature_sample_markerpath" src="/Documentation~/Images/miniature_sample_markerpath.png">


2. インポートした画像をARマーカーとして登録します。
    - "/Assets" の中にある "ReferencedImageLibrary" を選択してインスペクターを表示し、 "Add Image" を押下してARマーカー画像データを追加します。
    - プロジェクトにインポートした画像アセットをARマーカーのテクスチャに設定します。
    - ARマーカー名はファイル名から自動で設定されますが、任意の名前を設定することが可能です。
    - ARマーカー画像は現実空間に配置する大きさをメートル単位で指定する必要があります。印刷するARマーカー画像の大きさなどに合わせて大きさを設定してください。
    - "Assets/Prefabs/MiniatureCityModels" のインスペクタから、追加したARマーカーに紐付ける `City Models` の `ARMarkerName` に設定したARマーカー名を指定してください。
<img width="600" alt="miniature_sample_reflibpath" src="/Documentation~/Images/miniature_sample_reflibpath.png">
<img width="600" alt="miniature_sample_reflib_before" src="/Documentation~/Images/miniature_sample_reflib_before.png">
3. `ReferencedImageLibrary` に登録したARマーカーを位置合わせ用のARマーカーとして登録します。
    - ヒエラルキーで `MiniatureCityModels` を選択します。
    - インスペクタから `PlateauARMarkerCityModel(Script)` の「ARマーカー設定」のドロップダウンメニューを開きます。
    - 新たに追加したARマーカーを選択してください。
<img width="600" alt="miniature_marker_select" src="/Documentation~/Images/miniature_marker_select.png">

4. Unity プロジェクトをビルドし、用意したARマーカーを読み取ると、紐づけられた3D都市モデルオブジェクトが表示されます。

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

<img width="400" alt="miniature_sample_plateausdk_export_options" src="/Documentation~/Images/miniature_sample_plateausdk_export_options.png">

#### Unity公式FBXエクスポーターの利用
Unity公式のFBXエクスポーターを使用すると、Unityで選択したオブジェクトや、Unityで行った変更を含めたモデルの出力が可能になります。この方法では、頂点カラーのペイントやメッシュのマージなど、Unityで加工されたデータをそのまま出力できます。ただし、シーンに埋め込まれたテクスチャはこの方法では出力されないため、建物のテクスチャを出力する場合はPLATEAU SDKのエクスポート機能を使用する必要があります。

<img width="600" alt="miniature_sample_fbxexporter_selection" src="/Documentation~/Images/miniature_sample_fbxexporter_selection.png">

<img width="600" alt="miniature_sample_fbxexporter_settings" src="/Documentation~/Images/miniature_sample_fbxexporter_settings.png">


## 4-2. モバイル端末を対象にした3D都市モデルの作成
### アートスタイルの選定
今回のサンプル作成では、シンプルかつスタイリッシュな都市模型風のアートスタイルを採用しました。
 
<img width="600" alt="miniature_sample_artstyle" src="/Documentation~/Images/miniature_sample_artstyle.png">
 
### 頂点カラーの活用
頂点カラーを応用したグラフィック表現はモバイル端末上でのパフォーマンスを維持しつつ、リッチなビジュアル表現を加えるための確立された手法です。各頂点にカラーデータを割り当て、シェーダーを介して多様な表現を行うことが可能です。

<img width="600" alt="miniature_sample_vertexcolor_result" src="/Documentation~/Images/miniature_sample_vertexcolor_result.png">

### ポリゴン数と最適化
ポリゴン数の管理はモバイルアプリケーションのパフォーマンスに直接関係します。<br>
幅広いモバイル端末での動作を考慮し、約15万トライアングルに収まるように表示する3D都市モデルを選定します。<br>
エリアに含まれる建物の密度や形状にもよりますが、3km²の範囲に収まるLOD2の3D都市モデルを選択すると、最適化後およそ15万トライアングル以下になります。<br>

<img width="600" alt="miniature_sample_triangle_count" src="/Documentation~/Images/miniature_sample_triangle_count.png">

### 頂点カラーのペイント
今回のサンプルでは、RenderingToolkitの窓の頂点カラーマスク調整機能を使用し、ビルに頂点カラーを一括で割り当てました。
 
<img width="600" alt="miniature_sample_vertexcolor_painting" src="/Documentation~/Images/miniature_sample_vertexcolor_painting.png">

## **頂点カラーとは**

3Dモデルにおいて、各頂点が色情報を持つことができ、これを「頂点カラー」と呼びます。モデルの各頂点に色を割り当てることで、テクスチャマッピングとは異なる手法で3Dモデルの着色を可能にします。テクスチャ画像は多くのメモリを必要としますが、頂点カラーは画像と比較して軽量です。メモリの容量が限られている環境、例えばモバイルデバイスで潤沢にテクスチャを使用できない場合等で、とても有効です。また、マテリアルの数を減らすことも繋がり、それによって描画処理の負荷を減らすこともでき、パフォーマンスでのメリットも多いです。シェーダーとの組み合わせで応用範囲も広く、多様な視覚表現も実現できます。頂点カラーは、昔から現代のゲーム開発において広く使われている技術です。

<img width="600" alt="miniature_vtxcolor_explain_00.png" src="/Documentation~/Images/miniature_vtxcolor_explain_00.png">

### 描画負荷の削減の例

**テクスチャを使用しないことによるメモリ負荷軽減**

テクスチャを使わずにモデルに模様等を着色することができます。メッシュの頂点が色の頂点をもつので、頂点カラーで着色できる模様の解像度は頂点の細かさに依存します。

<img width="600" alt="miniature_vtxcolor_explain_02.gif" src="/Documentation~/Images/miniature_vtxcolor_explain_02.gif">

**マテリアル数の削減による描画負荷の軽減**

極端な例ですが、例えば地物ごとに、マテリアルのカラーを使用して、地物ごとに違う色を割り当てた場合、基本的には色の数だけ違うマテリアルが必要になります。100色あれば、100個マテリアルが必要です。
<img width="600" alt="miniature_vtxcolor_explain_01.png" src="/Documentation~/Images/miniature_vtxcolor_explain_01.png">

一方で、地物一つ一つに個別の頂点カラーを割り当てる場合、頂点カラーを表示するマテリアル1つのみで同じ表現が可能になります。一般的にはマテリアルが増える程、描画負荷が高くなる為、頂点カラーを上手く活用することで描画負荷の改善をおこなうことができます。

<img width="600" alt="miniature_vtxcolor_explain_00.png" src="/Documentation~/Images/miniature_vtxcolor_explain_00.png">

### 広い応用範囲

また、ゲーム等で良く使われる使用例として頂点カラーでマスクを作成して、シェーダーと組み合わせることで、複数のテクスチャをブレンディングしたりすることができます。（例: 苔の生えた岩等)

<img width="600" alt="miniature_vtxcolor_explain_03.gif" src="/Documentation~/Images/miniature_vtxcolor_explain_03.gif">

Unity上では頂点カラーをペイントするために、[Polybush](https://unity.com/features/polybrush)パッケージが用意されています。

PolyBrushの使い方等は[こちら](https://docs.unity3d.com/ja/Packages/com.unity.polybrush@1.1/manual/index.html)

### 頂点カラーの自動付与によるカラフルな都市モデルの作成

今回のサンプルでは、Rendering Toolkitの窓の頂点カラーマスク調整機能を使用し、ビルに頂点カラーを一括で自動割り当てします。

PLATEAU > PLATEAU Toolkit > Utilities から PLATEAU Utilities を開き、「メッシュレンダラーの選択」を使用して、３D都市モデルのトップノードを選択し、現在表示されているビルを一括選択します。

<img width="600" alt="miniature_colorful_city_00.png" src="/Documentation~/Images/miniature_colorful_city_00.png">
<img width="600" alt="miniature_colorful_city_01.png" src="/Documentation~/Images/miniature_colorful_city_01.png">
PLATEAU > PLATEAU Toolkit > Rendering Toolkit から PLATEAU Rendering Toolkit ウインドウを開いて、自動テクスチャ生成のタブから「頂点カラーの調整」を押下します。

<img width="600" alt="miniature_colorful_city_02.png" src="/Documentation~/Images/miniature_colorful_city_02.png">
この時点では、Unityの標準のLitシェーダーでは頂点カラーの表示に対応していない為、頂点カラーを表示することができません。頂点カラーの表示を確認するには、頂点カラーに対応したシェーダーが必要です。Unityにはシェーダーグラフというツールがあり、ノーコードでノードを繋いでいくことで視覚的にシェーダーを作成することができます。シェーダーグラフを使用してシェーダーを作成していきます。

### **シェーダー**

シェーダーは、3Dグラフィックスの中で物体の見た目を決定するプログラムです。光の反射の仕方、物体の色や質感、影の落とし方などをコントロールし、リアルタイムで視覚的な効果を作り出します。

### **シェーダーグラフ (Shader Graph)**

シェーダーグラフはUnityのツールで、ノーコードでシェーダーを作成できるように設計されています。ノードと呼ばれるビジュアル要素をつなげることで、シェーダーを直感的に設計できます。複雑なコードを書かずに、3Dオブジェクトの見た目をカスタマイズすることが可能です。

新規でマテリアルを作成します。

プロジェクトウインドウ > 右クリックメニュー > Create > Material を押下します。

<img width="600" alt="miniature_colorful_city_03.png" src="/Documentation~/Images/miniature_colorful_city_03.png">
<img width="600" alt="miniature_colorful_city_41.png" src="/Documentation~/Images/miniature_colorful_city_04.png">
新しく作成したマテリアルシーンの地物に割り当てします。PLATEAU Utilities ツールで地物を全部選択します。先程と同じく、PLATEAU > PLATEAU Toolkit > Utilities ツールの「メッシュレンダラーの選択」を使用して、３D都市モデルのトップノードを選択し、現在表示されているビルを一括選択します。

![2024-01-29_13h02_56.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/7f38f07b-eb12-41a8-b644-a03471bc3bae/901677a1-cb29-4f50-b5e0-0008ff3a2f29/2024-01-29_13h02_56.png)

Materials の項目をインスペクターから開いて新しく作成したマテリアルを割り当てます。

<img width="600" alt="miniature_colorful_city_05.png" src="/Documentation~/Images/miniature_colorful_city_05.png">
3D都市モデルの地物には壁と床部分のマテリアルがそれぞれ割り当てられているため、スロットの1番目と2番目の両方新しく作成したマテリアルをアサインします。

<img width="600" alt="miniature_colorful_city_06.png" src="/Documentation~/Images/miniature_colorful_city_06.png">
<img width="600" alt="miniature_colorful_city_07.png" src="/Documentation~/Images/miniature_colorful_city_07.png">
続いてプロジェクトウインドウからシェーダーグラフのアセットを作成します。

プロジェクトウインドウ > 右クリックメニュー > Create > Shader Graph > URP > Lit Shader Graph を押下します。

<img width="600" alt="miniature_colorful_city_08.png" src="/Documentation~/Images/miniature_colorful_city_08.png">
新しいシェーダーグラフアセットが作成されます。

<img width="600" alt="miniature_colorful_city_09.png" src="/Documentation~/Images/miniature_colorful_city_09.png">
新規で作成して3D都市モデルに割り当てた New Material に作成したシェーダーを割り当てます。

マテリアルを選択してインスペクターから「New Shader Graph」を選択します。

<img width="600" alt="miniature_colorful_city_15.png" src="/Documentation~/Images/miniature_colorful_city_15.png">
<img width="600" alt="miniature_colorful_city_16.png" src="/Documentation~/Images/miniature_colorful_city_16.png">
作成したアセットをダブルクリックするとシェーダーグラフの編集ウインドウが表示されます。

<img width="600" alt="miniature_colorful_city_09.png" src="/Documentation~/Images/miniature_colorful_city_09.png">
<img width="600" alt="miniature_colorful_city_10.png" src="/Documentation~/Images/miniature_colorful_city_10.png">
右クリック > Create Node を押下して、Create Nodeのパネルから検索ボックスに「Vertex」と入力し、表示されたVertexColorノードを押下して作成します。を押してVertex Colorノードを作成し、カラーノードと接続します。

<img width="600" alt="miniature_colorful_city_11.png" src="/Documentation~/Images/miniature_colorful_city_11.png">
<img width="600" alt="miniature_colorful_city_12.png" src="/Documentation~/Images/miniature_colorful_city_12.png">
<img width="600" alt="miniature_colorful_city_13.png" src="/Documentation~/Images/miniature_colorful_city_13.png">
「VertexColor」ノードと「Fragment」タブの「BaseColor」を接続します。基本的にはこれだけで頂点カラーを表示するシェーダーができます。

<img width="600" alt="miniature_colorful_city_14.png" src="/Documentation~/Images/miniature_colorful_city_14.png">
ここまでの作業を保存します。シェーダーグラフの編集ウインドウの右上の「Save Asset」を押すと、ここまでの作業がアセットに保存されます。

<img width="600" alt="miniature_colorful_city_21.png" src="/Documentation~/Images/miniature_colorful_city_21.png">
シーンに戻ると3D都市モデルに頂点カラーが表示されます。

<img width="600" alt="miniature_colorful_city_17.png" src="/Documentation~/Images/miniature_colorful_city_17.png">
次にSplitノードと接続します。実際の開発では、頂点カラーはシェーダー内でマスク要素として、各チャンネルを使用するケースが多く、RenderingToolkitで自動付与した頂点カラーも、Gチャンネルと、Aチャンネルに個別の要素を格納しています。これらを確認していきます。

右クリック > Create Node を押下して、Create Node パネルから検索ボックスに「Split」と入力し、表示された「Split」ノードを押下して作成します。

<img width="600" alt="miniature_colorful_city_11.png" src="/Documentation~/Images/miniature_colorful_city_11.png">
<img width="600" alt="miniature_colorful_city_18.png" src="/Documentation~/Images/miniature_colorful_city_18.png">
<img width="600" alt="miniature_colorful_city_22.png" src="/Documentation~/Images/miniature_colorful_city_22.png">

### 頂点カラーGチャンネル

頂点カラーGチャンネルを確認します。
「Vertex Color」ノードの「Out」を「Split」ノードの「In」に接続します。
「Split」ノードの「G」チャンネルを「Fragment」パネルの「BaseColor」に接続します。

<img width="600" alt="miniature_colorful_city_19.png" src="/Documentation~/Images/miniature_colorful_city_19.png">
シェーダーグラフの編集ウインドウの右上の「Save Assetを」押下してここまでの作業を保存します。保存完了後、シーンを確認します。

<img width="600" alt="miniature_colorful_city_23.png" src="/Documentation~/Images/miniature_colorful_city_23.png">
地物のバウンディングボックスの底から頂上に向かって、白から黒へのグラデーションが塗られています。

<img width="800" alt="miniature_vertex_g.png" src="/Documentation~/Images/miniature_vertex_g.png">

### 頂点カラーAチャンネル

頂点カラーAチャンネルを確認します。

「Split」ノードの「A」チャンネルを「Fragment」パネルの「BaseColor」に接続します。

<img width="600" alt="miniature_colorful_city_20.png" src="/Documentation~/Images/miniature_colorful_city_20.png">
シェーダーグラフの編集ウインドウの右上の「Save Asset」を押下してここまでの作業を保存します。保存完了後、シーンを確認します。

<img width="600" alt="miniature_colorful_city_23.png" src="/Documentation~/Images/miniature_colorful_city_23.png">
地物ごとにランダムな値が割り当てられています。ランダムな値を使用することで、シェーダー内で多様な表現を行うことができます。今回はこちらをメインに使用します。

<img width="800" alt="miniature_vertex_a.png" src="/Documentation~/Images/miniature_vertex_a.png">

シェーダーグラフをここから少し編集して、頂点カラーのアルファチャンネルを使用し、カラフルな3D都市モデルを作成していきます。

Gradientのプロパティを作成します。

シェーダーグラフ編集ウインドウの左側のパネルの「＋」マークを押下するとパネルが表示されるので「Gradient」を押下します。

<img width="600" alt="miniature_colorful_city_24.png" src="/Documentation~/Images/miniature_colorful_city_24.png">
Gradientプロパティが作成されます。

Gradientプロパティを押下すると右側のシェーダーグラフのインスペクターの表示が変わるので「Default」のカラーを押下します。

<img width="600" alt="miniature_colorful_city_26.png" src="/Documentation~/Images/miniature_colorful_city_26.png">
<img width="600" alt="miniature_colorful_city_27.png" src="/Documentation~/Images/miniature_colorful_city_27.png">
グラデーションを調整するパネルが表示されるので色を調整します。

今回は虹色に調整しました。

<img width="600" alt="miniature_colorful_city_28.png" src="/Documentation~/Images/miniature_colorful_city_28.png">
グラデーション調整後、Gradientプロパティを他のノードと接続できるようにパネルの右側にドラッグアンドドロップします。こうすることで他のノードと接続できるようになります。

<img width="600" alt="miniature_colorful_city_31.png" src="/Documentation~/Images/miniature_colorful_city_31.png">
「Sample Gradient」ノードを作成します。

右クリック > Create Node を押下して、Create Node パネルから検索ボックスに「sample」と入力し、表示された「Sample Gradient」ノードを押下して作成します。

<img width="600" alt="miniature_colorful_city_11.png" src="/Documentation~/Images/miniature_colorful_city_11.png">
<img width="600" alt="miniature_colorful_city_32.png" src="/Documentation~/Images/miniature_colorful_city_32.png">
<img width="600" alt="miniature_colorful_city_33.png" src="/Documentation~/Images/miniature_colorful_city_33.png">
作成した「Sample Gradient」ノードのTimeにSplitノードのAチャンネルを接続します。

「Gradient」プロパティのノードを「Sample Gradient」ノードのGradientと接続します。

最後に「Sample Gradient」ノードの「Out」を Fragment パネル「Base Color」に接続します。

<img width="600" alt="miniature_colorful_city_34.png" src="/Documentation~/Images/miniature_colorful_city_34.png">
シェーダーグラフの編集ウインドウの右上の「Save Asset」を押下してここまでの作業を保存します。保存完了後、シーンを確認します。
<img width="600" alt="miniature_colorful_city_23.png" src="/Documentation~/Images/miniature_colorful_city_23.png">
シーンにカラフルな3D都市モデルが表示されます。

<img width="600" alt="miniature_colorful_city_35.png" src="/Documentation~/Images/miniature_colorful_city_35.png">
仕組みとしては頂点アルファの値が0～1でランダムで地物ごとに自動で付与されており、SampleGradientノードを使用してこれらの値がカラーグラデーションに再マッピングされます。グラデーションの左が0（黒）で右が1（白）です。

<img width="600" alt="miniature_colorful_city_38.png" src="/Documentation~/Images/miniature_colorful_city_38.png">
グラデーションカラーを調整して好みのカラーで3D都市モデルの見た目を調整することができます。

<img width="600" alt="miniature_colorful_city_36.png" src="/Documentation~/Images/miniature_colorful_city_36.png">
<img width="600" alt="miniature_colorful_city_37.png" src="/Documentation~/Images/miniature_colorful_city_37.png">
ここまでの手順で、ビジュアルの主要部分が完成しました。これまでの工程を通じて作成されたシェーダーグラフのアセットは、プロジェクトの下記の場所にあります。

- シェーダーグラフ：Assets/Shaders/VertexAlphaSample.shadergraph
- マテリアル： Assets/Models/CommonMaterials/VertexAlphaSample.mat

<img width="600" alt="miniature_city_final.png" src="/Documentation~/Images/miniature_city_final.png">
さらに、本サンプルで作成したシェーダーグラフは、追加でGチャンネルのマスクなどを活用して拡張されています。この拡張されたシェーダーグラフのアセットについては、プロジェクトの下記の場所にあります。

- シェーダーグラフ: Assets/Shaders/ColorBuilding.shadergraph
- マテリアル: Assets/Models/CommonMaterials/Buidlings_MAT.mat

合わせて、完成したシーンのサンプルも用意しています。実際のシーンを直接見ていただくことで、本サンプルのさらなる理解に役立ちます。完成シーンのサンプルはプロジェクトの以下のシーンファイルをご確認ください。

- シーン: Assets/Scenes/MiniaturePrefabSetup.unity



## 4-3. モデルの加工と出力
### 地物の高さの調整とメッシュのマージ
モデルの加工には地物の高さを揃える工程とメッシュのマージが含まれます。これらの工程は、サンプルプロジェクトの Unity エディタメニュー上の "MiniatureViewer" にある専用のツールを介して行われます。これにより、モデルは一貫性のある外観と最適化されたメッシュ構造を持つことができます。

<img width="600" alt="miniature_sample_merge_mesh" src="/Documentation~/Images/miniature_sample_merge_mesh.png">

### FBXエクスポーターでの出力
加工が完了したモデルはUnity FBXエクスポーターを使用してFBXフォーマットで出力します。ヒエラルキーからエクスポートするゲームオブジェクトを右クリックし、"Export To FBX" を選択します。
 
<img width="400" alt="miniature_sample_rightclick_export_fbx" src="/Documentation~/Images/miniature_sample_rightclick_export_fbx.png">


## 4-4. ライトマップの適用

### ライトマップとは
ライトマップはゲームやアプリケーションのシーンにおける光の影響を事前に計算し、その結果をテクスチャ（画像）として保存する技術です。これにより、実際の光源からの影や光の拡散をリアルタイムに計算する代わりに、予め計算されたライティング効果をシーンに適用することができます。特にモバイル端末のように処理能力が限られている環境では、ライトマップの使用により、リアルタイムレンダリング時の負荷を大幅に軽減できます。

### モバイル端末でのキャストシャドウと処理負荷
モバイル端末では、リアルタイムのキャストシャドウ（影の投射）は大きな処理負荷を伴います。リアルタイムで影を計算することはレンダリングの処理負荷が高く、特に処理能力が限られているモバイル端末には不向きです。このため、ライトマップを利用することが重要となります。

### ライトマップのベイク方法
#### ライトの設定
シーン内に必要な光源を配置し、任意のライティング設定を行います。ライトマップをベイクするためには、FBXファイルの「ライトマップUV」の項目をチェックし、対象のオブジェクトのStaticフラグを有効にします。この設定はオブジェクトにライトマップのデータが適切にマッピングされる為のUVを作成します。

<img width="600" alt="miniature_sample_lightmap_uv" src="/Documentation~/Images/miniature_sample_lightmap_uv.png">
<img width="600" alt="miniature_sample_lightmap_static" src="/Documentation~/Images/miniature_sample_lightmap_static.png">

### ライトマップベイクの実行
ベイクする準備が完了したらライティング設定からライトマップをベイクします。以下の画像はサンプルプロジェクトで用意しているライトマップの設定です。

<img width="600" alt="miniature_sample_lightmap_settings" src="/Documentation~/Images/miniature_sample_lightmap_settings.png">

### プレハブへのライトマップ適用
Unityのライトマップはシーン上のオブジェクトを対象としているため標準機能ではプレハブにライトマップを適用する機能はありませんが、拡張スクリプトを作成してプレハブにライトマップの情報を保存することが可能です。この手順により、異なるシーンでベイクされたライティング情報をのオブジェクトを一つのシーンで使うことができます。
`PrefabLightmapData` コンポーネントをプレハブのルートに追加し、PLATEAU Utilities ウィンドウ「シーンのライトマップをプレハブに設定」を押下してプレハブのライトマップ生成を実行します。

<img width="600" alt="miniature_prefab_lightmap" src="/Documentation~/Images/miniature_prefab_lightmap.png">

<img width="600" alt="miniature_prefab_lightmap_menu" src="/Documentation~/Images/miniature_prefab_lightmap_menu.png">

## 4-5. ナビメッシュの作成と人の配置
### ナビメッシュ追加パッケージのインストール
ナビメッシュの基本機能ではナビメッシュのデータはシーン内に保存されるため、プレハブ上でナビメッシュを実行するためには追加のパッケージが必要です。サンプルプロジェクトではすでに追加パッケージがインストールされているため、このプロジェクトを元に改変を行う場合はインストールは必要ありません。別のプロジェクトで追加パッケージのインストールが必要な場合はパッケージマネージャーからインストールを行います。

<img width="600" alt="miniature_sample_ainavigation_url" src="/Documentation~/Images/miniature_sample_ainavigation_url.png">

<img width="600" alt="miniature_sample_ainavigation_package" src="/Documentation~/Images/miniature_sample_ainavigation_package.png">

### ナビメッシュのベイク方法
`NavMeshSurface` コンポーネントを空のゲームオブジェクトにアタッチしてベイクします。ナビメッシュは小さすぎるオブジェクトに対応していないので、一時的にミニチュア都市モデルのスケールを拡大してベイクし、その後障害物や侵入させたくないエリアの設定を追加で行います。<br>

<img width="600" alt="miniature_sample_navmesh_surface_component" src="/Documentation~/Images/miniature_sample_navmesh_surface_component.png">

<img width="600" alt="miniature_sample_lightmap_bakeprefab" src="/Documentation~/Images/miniature_sample_lightmap_bakeprefab.png">

### サンプルプロジェクトに合わせたナビメッシュ調整
ARでは3D都市モデル全体のスケーリングや回転等の機能が実装されていますが、通常のナビメッシュはこれらに対応していません。専用のカスタムコンポーネントを追加することで、固定位置のナビメッシュからアプリケーション上の3D都市モデルミニチュアオブジェクト上でスポーンするすべてのアバターにトランスフォームの再マッピングを行います。
  
<img width="600" alt="miniature_sample_navmesh_transform_remapping" src="/Documentation~/Images/miniature_sample_navmesh_transform_remapping.png">

#### 人の配置
ナビメッシュ上に人のモデルを配置し、AR環境内でのリアルタイムインタラクションを提供します。これにより、都市モデルがより現実的で臨場感のあるものになります。

<img width="600" alt="miniature_sample_navmesh_human" src="/Documentation~/Images/miniature_sample_navmesh_human.png">

# ライセンス

- 本リポジトリはMITライセンスで提供されています。
- 本システムの開発はユニティ・テクノロジーズ・ジャパン株式会社が行っています。
- ソースコードおよび関連ドキュメントの著作権は国土交通省に帰属します。

# 注意事項/利用規約

- 本ツールをアンインストールした場合、本ツールの機能で作成されたアセットの動作に不備が発生する可能性があります。
- 本ツールをアップデートした際は、一度 Unity エディターを再起動することを推奨しています。
- パフォーマンスの観点から、3km²の範囲に収まる3D都市モデルをダウンロード・インポートすることを推奨しています。
- インポートする範囲の広さや地物の種類（建物、道路、災害リスクなど）が量に比例して処理負荷が高くなる可能性があります。
- 本リポジトリの内容は予告なく変更・削除される可能性があります。
- 本リポジトリの利用により生じた損失及び損害等について、国土交通省はいかなる責任も負わないものとします。
