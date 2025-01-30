# 東方資料包裹
<img src="./Cover.png">

**English：README-en.pdf**

**日本語：README-ja.pdf**

**中文：README-zh.pdf**

## 概要
東方資料包裹(とうほうしりょうほうか)は東方Projectのキャラクターの情報を取得可能なデータパッケージです。

最新作(獣王園)、旧作、書籍のキャラクターまで網羅しています。

霊夢などの各キャラクターについて、以下の情報をソースコード上で簡単に取得可能です。

- 名前
- フルネーム
- キャラクターごとに設定されたユニークな数値と文字列
   - PlayerPrefsやswitch文での分岐などで使えます。

また、名前とフルネームは以下の言語に翻訳されています。

- 日本語
   - 読み仮名、フルネームの読み仮名も取得可能です。
- 英語
- 中国語

## インストール方法
`TouhouDataPackage.unitypackage` をインポートしてください。

## 要件
Unity2020.2以上

本パッケージはswitch式を使用していますので、C#8.0以上が使用可能なUnityバージョンが必要です。

## リファレンス
本パッケージは全て `TouhouData` 名前空間に存在します。

なので、本パッケージを使用するときは以下のusingディレクティブを追加してください。

```cs
using TouhouData;
```

### Character
東方Projectのキャラクターのクラスです。

基本的にstatic変数と定数しか存在しませんが、クラス自体はstaticではないので継承可能です。

**Static 変数**

| 名前 | 説明 |
| --- | --- |
| [`(任意のキャラクター)`](#任意のキャラクター) | 東方Projectのキャラクターの情報です(読み取り専用)。<br>`Character.Reimu`のようにEnumに近い使い勝手で参照可能です。<br>参照できるキャラクターについては下記の備考欄を参照してください。 |

**変数**

| 名前 | 説明 |
| --- | --- |
| [`Name`](#name) | 東方キャラの名前です(読み取り専用)。苗字などは含みません。<br>ChangeLanguageで設定した言語に応じて返される文字列が変化します。 |
| [`FullName`](#fullname) | 東方キャラのフルネームです(読み取り専用)。<br>ChangeLanguageで設定した言語に応じて返される文字列が変化します。 |
| [`Locales.(任意のロケール).Name`](#locales任意のロケールname) | 東方キャラの名前です(読み取り専用)。苗字などは含みません。 |
| [`Locales.(任意のロケール).FullName`](#locales任意のロケールfullname) | 東方キャラのフルネームです(読み取り専用)。 |
| [`Locales.Ja.NameKana`](#localesjanamekana) | 東方キャラの平仮名の名前です(読み取り専用)。苗字などは含みません。<br>Locales.Jaにのみこの変数は存在します。 |
| [`Locales.Ja.FullNameKana`](#localesjafullnamekana) | 東方キャラの平仮名のフルネームです。Locales.Jaにのみこの変数は存在します。 |
| [`String`](#string) | 東方キャラに割り振られたユニークなstring値です(読み取り専用)。 |
| [`ID`](#id) | 東方キャラに割り振られたユニークなint値です(読み取り専用)。 |

**Static 関数**

| 名前 | 説明 |
| --- | --- |
| [`ChangeLanguage`](#changelanguage) | NameとFullNameの言語を設定します。 |
| [`Get`](#get) | 特定のCharacterを返す関数です。引数にはint値とstring値を指定可能です。 |

**関数**

| 名前 | 説明 |
| --- | --- |
| [`ToString`](#tostring) | `String` を返します。 |

**定数**

| 名前 | 説明 |
| --- | --- |
| [`length`](#length) | 本パッケージに含まれるキャラクターの人数です(160)。 |
| [`Strings.(任意のキャラクター)`](#strings任意のキャラクター) | 任意の東方キャラのStringです。 |
| [`IDs.(任意のキャラクター)`](#ids任意のキャラクター) | 任意の東方キャラのIDです。 |

**クラス**

| 名前 | 説明 |
| --- | --- |
| [`Strings`](#strings) | 任意の東方キャラのStringをメンバーに持つクラスです。 |
| [`IDs`](#ids) | 任意の東方キャラのIDをメンバーに持つクラスです。 |
| [`Locale`](#locale) | `Name` と `FullName` メンバーを持つクラスです。 |
| [`LocaleJa`](#localeja) | `Locale` を継承し、 `NameKana` と `FullNameKana` メンバーを追加で持つクラスです。 |
| [`CharacterLocales`](#characterlocales) | `LocaleJa` の `Ja` 、 `Locale` の `En` と `Zh` のメンバーを持つクラスです。 |

#### (任意のキャラクター)
東方Projectのキャラクターの情報です(読み取り専用)。

staticでreadonlyな変数であり、Character.ReimuのようにEnumに近い使い勝手で参照可能です。

参照できるキャラクターについては下記の備考欄を参照してください。

```cs
Character character1 = Character.Reimu;
Character character2 = Character.Marisa;
```

#### SelectedLanguage
NameとFullNameの言語のSystemLanguageです(読み取り専用)。

値は以下の3つのどれかになります。

- SystemLanguage.Japanese
- SystemLanguage.English
- SystemLanguage.Chinese

#### Name
東方キャラの名前です(読み取り専用)。苗字などは含みません。

ChangeLanguageで設定した言語に応じて返される文字列が変化します。

```cs
Character character = Character.Reimu;
Character.ChangeLanguage ("ja");
Debug.Log (character.Name); // 霊夢
Character.ChangeLanguage ("en");
Debug.Log (character.Name); // Reimu
Character.ChangeLanguage ("zh");
Debug.Log (character.Name); // 灵梦
```

#### FullName
東方キャラのフルネームです(読み取り専用)。

ChangeLanguageで設定した言語に応じて返される文字列が変化します。

```cs
Character character = Character.Reisen;
Character.ChangeLanguage (SystemLanguage.Japanese);
Debug.Log (character.FullName); // 鈴仙・優曇華院・イナバ
Character.ChangeLanguage (SystemLanguage.English);
Debug.Log (character.FullName); // Reisen Udongein Inaba
Character.ChangeLanguage (SystemLanguage.Chinese);
Debug.Log (character.FullName); // 铃仙·优昙华院·因幡
```

#### Locales
翻訳された情報はこの変数の中に入っています。

言語とロケールの対応は以下のようになっています。

- Locales.Ja：日本語
- Locales.En：英語
- Locales.Zh：中国語

##### Locales.(任意のロケール).Name
東方キャラの名前です(読み取り専用)。苗字などは含みません。

```cs
Character character = Character.Remilia;
Debug.Log (character.Locales.Ja.Name); // レミリア
Debug.Log (character.Locales.En.Name); // Remilia
Debug.Log (character.Locales.Zh.Name); // 蕾米莉亚
```

##### Locales.(任意のロケール).FullName
東方キャラのフルネームです(読み取り専用)。

```cs
Character character = Character.Marisa;
Debug.Log (character.Locales.Ja.FullName); // 霧雨 魔理沙
Debug.Log (character.Locales.En.FullName); // Marisa Kirisame
Debug.Log (character.Locales.Zh.FullName); // 雾雨 魔理沙
```

##### Locales.Ja.NameKana
東方キャラの平仮名の名前です(読み取り専用)。苗字などは含みません。Locales.Jaにのみこの変数は存在します。

```cs
Debug.Log (Character.Sakuya.Locales.Ja.NameKana); // さくや
Debug.Log (Character.Nitori.Locales.Ja.NameKana); // にとり
Debug.Log (Character.Alice.Locales.Ja.NameKana); // ありす
```

##### Locales.Ja.FullNameKana
東方キャラの平仮名のフルネームです。Locales.Jaにのみこの変数は存在します。

```cs
Debug.Log (Character.Komachi.Locales.Ja.FullNameKana); // おのづか こまち
Debug.Log (Character.Tewi.Locales.Ja.FullNameKana); // いなば てゐ
Debug.Log (Character.Eiki.Locales.Ja.FullNameKana); // しき えいき・やまざなどぅ
```

#### String
東方キャラに割り振られたユニークなstring値です(読み取り専用)。

この値は東方キャラのstatic変数名と全く同じです。

また、 `ToString` はこの値を返します。

この値は将来のバージョンアップで変化しません。

なので安心してこの値をPlayerPrefsのキーに使用できます。

```cs
Debug.Log (Character.Reisen.String); // Reisen
Debug.Log (Character.ReisenSecond.String); // ReisenSecond
PlayerPrefs.SetString(Character.Reisen.String + "_Nickname", "うどんげ");
PlayerPrefs.SetInt(Character.ReisenSecond.String + "_Power", 20);
```

#### ID
東方キャラに割り振られたユニークなint値です(読み取り専用)。

この値は `String` を英語の辞書順で並び替えた時のindexと同じです。

この値は将来のバージョンアップで変化します。

なので、PlayerPrefsのキーに使うのは非推奨です。

```cs
Debug.Log (Character.Akyuu.ID); // 0
Debug.Log (Character.Alice.ID); // 1
Debug.Log (Character.Zanmu.ID); // 159
```

#### ChangeLanguage
NameとFullNameの言語を設定します。

引数にはSystemLanguageとstringを渡せます。

stringは大文字と小文字を区別しません。

本パッケージに対応していない言語の引数を渡した場合、言語は英語を使用します。

貴方のゲームで最初に実行されるスクリプト、または言語を設定するスクリプトでこの関数を実行してください。

この関数を実行しない場合、 `Application.systemLanguage` に応じて自動的に言語が設定されます。

**引数の値と設定言語**

- 引数：設定言語
- SystemLanguage.Japanese：日本語
- SystemLanguage.English：英語
- SystemLanguage.Chinese, SystemLanguage.ChineseSimplified, SystemLanguage.ChineseTraditional：中国語
- "ja"：日本語
- "en"：英語
- "zh"：中国語
- その他：英語

```cs
Character.ChangeLanguage (SystemLanguage.Japanese); // 日本語
Character.ChangeLanguage ("en"); // 英語
Character.ChangeLanguage ("Zh"); // 中国語
Character.ChangeLanguage ("aaaaa"); // 英語
```

#### Get
特定のCharacterを返す関数です。引数にはint値とstring値を指定可能です。

int値を指定した場合、int値と `ID` が一致するキャラクターを返します。

string値を指定した場合、string値と `String` が一致するキャラクターを返します。

どちらの場合も該当するCharacterが存在しない場合はnullを返します。

```cs
Character character1 = Character.Get (0);
Character character2 = Character.Get ("Reimu");
Character character3 = Character.Get (-999);
Character character4 = Character.Get ("aaaaaaaaaaaaaaaa");

if (character1 != null)
{
    Debug.Log (character1.FullName); // 稗田 阿求
}
Debug.Log (character2?.FullName); // 博麗 霊夢
Debug.Log (character3?.FullName); // null
Debug.Log (character4); // null
```

#### ToString
`String` を返します。

```cs
Debug.Log (Character.Reisen.ToString ()); // Reisen
Debug.Log (Character.ReisenSecond.ToString ()); // ReisenSecond
PlayerPrefs.SetString(Character.Reisen.ToString () + "_Nickname", "うどんげ");
PlayerPrefs.SetInt(Character.ReisenSecond.ToString () + "_Power", 20);
```

#### length
本パッケージに含まれるキャラクターの人数です(160)。

ランダムなキャラクターを取得したい時や、forループを回す時などに便利です。

```cs
Character randomCharacter = Character.Get (Random.Range (0, Character.length)); // ランダムなキャラクター

for (int i = 0; i < Character.length; i++)
{
   Character character = Character.Get (i);
   if (character != null)
   {
      Debug.Log (character.String); // Akyuu, Alice, Aunn, ... , Yuuma, Yuyuko, Zanmu
   }
}
```

#### Strings.(任意のキャラクター)
任意の東方キャラのStringです(定数)。

定数なのでswitch文やPlayerPrefsのキーに使えます。

```cs
Character character = Character.Get (Random.Range (0, Character.length));

switch (character.String)
{
case Character.Strings.Ekisya:
case Character.Strings.Genjii:
case Character.Strings.Rinnosuke:
   Debug.Log (character.FullName + "は男です。");
   break;
case Character.Strings.Singyoku:
   Debug.Log (character.FullName + "は男だったり女だったりします。");
   break;
default:
   Debug.Log (character.FullName + "は女です。");
   break;
}
```

#### IDs.(任意のキャラクター)
任意の東方キャラのIDです(定数)。

定数なのでswitch文に使えます。

```cs
Character character = Character.Get (Random.Range (0, Character.length));

switch (character.ID)
{
case Character.IDs.Ekisya:
case Character.IDs.Genjii:
case Character.IDs.Rinnosuke:
   Debug.Log (character.FullName + "は男です。");
   break;
case Character.IDs.Singyoku:
   Debug.Log (character.FullName + "は男だったり女だったりします。");
   break;
default:
   Debug.Log (character.FullName + "は女です。");
   break;
}
```

#### Strings
任意の東方キャラのStringをメンバーに持つクラスです。

メンバーは全て定数ですがstaticクラスではないので継承可能です。

#### IDs
任意の東方キャラのIDをメンバーに持つクラスです。

メンバーは全て定数ですがstaticクラスではないので継承可能です。

#### Locale
`Name` と `FullName` メンバーを持つクラスです。

#### LocaleJa
`Locale` を継承し、 `NameKana` と `FullNameKana` メンバーを追加で持つクラスです。

#### CharacterLocales
`LocaleJa` の `Ja` 、 `Locale` の `En` と `Zh` のメンバーを持つクラスです。

(任意のキャラクター).Localesでこのクラスを使用しています。

## サンプル
Samplesディレクトリに本パッケージの使用サンプルや、使用時に便利なテンプレートが入っています。

- `TouhouDataPackageSample.unity` ： Characterを利用して東方キャラの大百科を作ったサンプルです。
   - `Scripts/TouhouDataPackageSample.cs` ： このシーンで使用しているスクリプトです。Characterクラスの機能を一通り使っています。
- `TouhouDataPackageExtendedSample.unity` ： Characterを拡張して東方キャラの大百科を作ったサンプルです。
   - `Scripts/TouhouDataPackageExtendedSample.cs` ： このシーンで使用しているスクリプトです。Characterクラスの機能を一通り継承したクラスを使っています。
- `TouhouDataPackageTemplate.txt` ： 全てのキャラクターのswitch文のテンプレートが記述されています。

Assets/Resources/Pictures/CharacterディレクトリにCharacter.Stringと同じ名前の画像(Reimu.pngなど)を用意すれば、サンプルシーンでキャラクターの画像が表示されます。

## 備考
### パッケージに含まれるキャラクター
本パッケージでは以下のキャラクターを網羅しています。(カッコ内はstatic変数名)

- 阿求(Akyuu)
- アリス(Alice)
- あうん(Aunn)
- 文(Aya)
- 弁々(Benben)
- 美天(Biten)
- 白蓮(Byakuren)
- 橙(Chen)
- 千亦(Chimata)
- ちやり(Chiyari)
- ちゆり(Chiyuri)
- チルノ(Cirno)
- クラウンピース(Clownpiece)
- 大妖精(Daiyousei)
- ドレミー(Doremy)
- 瓔花(Eika)
- 映姫(Eiki)
- 永琳(Eirin)
- 易者(Ekisya)
- エリス(Elis)
- エレン(Ellen)
- エリー(Elly)
- 慧ノ子(Enoko)
- エタニティラルバ(Eternitylarva)
- フランドール(Flandre)
- 布都(Futo)
- 幻月(Gengetu)
- 玄爺(Genjii)
- はたて(Hatate)
- ヘカーティア(Hecatia)
- 雛(Hina)
- 日狭美(Hisami)
- 一輪(Ichirin)
- 衣玖(Iku)
- 純狐(Junko)
- 女苑(Jyoon)
- 影狼(Kagerou)
- 輝夜(Kaguya)
- カナ(Kana)
- 神奈子(Kanako)
- 華扇(Kasen)
- 袿姫(Keiki)
- 慧音(Keine)
- キクリ(Kikuri)
- キスメ(Kisume)
- 小悪魔(Koakuma)
- 小傘(Kogasa)
- こいし(Koishi)
- こころ(Kokoro)
- 小町(Komachi)
- コンガラ(Konngara)
- 小鈴(Kosuzu)
- 小兎姫(Kotohime)
- くるみ(Kurumi)
- 久侘歌(Kutaka)
- 響子(Kyouko)
- レティ(Letty)
- リリーホワイト(Lilywhite)
- ルイズ(Luize)
- ルナチャイルド(Lunarchild)
- ルナサ(Lunasa)
- リリカ(Lyrica)
- マイ(Mai)
- マミゾウ(Mamizou)
- マエリベリー(Maribel)
- 魔理沙(Marisa)
- 磨弓(Mayumi)
- メディスン(Medicine)
- 龍(Megumu)
- 明羅(Meira)
- 美鈴(Meirin)
- メルラン(Merlin)
- ミケ(Mike)
- 神子(Miko)
- 魅魔(Mima)
- 水蜜(Minamitsu)
- 穣子(Minoriko)
- 魅須丸(Misumaru)
- 美宵(Miyoi)
- 瑞霊(Mizuchi)
- 妹紅(Mokou)
- 椛(Momizi)
- 百々世(Momoyo)
- 夢月(Mugetu)
- ミスティア(Mystia)
- 成美(Narumi)
- ナズーリン(Nazrin)
- ネムノ(Nemuno)
- にとり(Nitori)
- ぬえ(Nue)
- 隠岐奈(Okina)
- オレンジ(Orange)
- パルスィ(Parsee)
- パチュリー(Patchouli)
- 雷鼓(Raiko)
- 藍(Ran)
- 霊夢(Reimu)
- 鈴仙(Reisen)
- レイセン(ReisenSecond)
- レミリア(Remilia)
- 蓮子(Renko)
- 里香(Rika)
- 理香子(Rikako)
- 燐(Rin)
- 鈴瑚(Ringo)
- 霖之助(Rinnosuke)
- ルーミア(Rumia)
- る～こと(Ruukoto)
- サグメ(Sagume)
- 早鬼(Saki)
- 咲夜(Sakuya)
- 早苗(Sanae)
- 山如(Sannyo)
- サラ(Sara)
- サリエル(Sariel)
- 里乃(Satono)
- さとり(Satori)
- 青娥(Seiga)
- 正邪(Seija)
- 清蘭(Seiran)
- 赤蛮奇(Sekibanki)
- 神綺(Shinki)
- 針妙丸(Shinmyoumaru)
- 紫苑(Shion)
- 静葉(Shizuha)
- シンギョク(Singyoku)
- スターサファイア(Starsapphire)
- 萃香(Suika)
- 菫子(Sumireko)
- サニーミルク(Sunnymilk)
- 諏訪子(Suwako)
- 星(Syou)
- たかね(Takane)
- 舞(Teireida)
- 天子(Tenshi)
- てゐ(Tewi)
- 屠自古(Tojiko)
- 朱鷺子(Tokiko)
- 豊姫(Toyohime)
- 典(Tsukasa)
- 潤美(Urumi)
- 空(Utsuho)
- わかさぎ姫(Wakasagihime)
- リグル(Wriggle)
- 八千慧(Yachie)
- ヤマメ(Yamame)
- 八橋(Yatsuhashi)
- 依姫(Yorihime)
- 芳香(Yoshika)
- 妖夢(Youmu)
- 紫(Yukari)
- ユキ(Yuki)
- 夢子(Yumeko)
- 夢美(Yumemi)
- ユウゲンマガン(Yuugenmagan)
- 勇儀(Yuugi)
- 幽香(Yuuka)
- 尤魔(Yuuma)
- 幽々子(Yuyuko)
- 残無(Zanmu)

上記に存在しないキャラクターはパッケージに含まれません。

特に以下の条件に該当するキャラクターは本パッケージから除外されています。

- 設定のみのキャラクター
   - 冴月麟、岩笠、命蓮など
- マイナー過ぎるキャラクター
   - 万歳楽、ホフゴブリンなど
   - る～こと、朱鷺子、易者はパッケージに含まれます
- 二次創作キャラクター
   - 瀬笈 葉、左城宮 則紗など
- 非生物
   - ミミちゃん、地霊殿一面道中の岩など
- 非東方キャラ
   - 西方キャラ、蓬莱少女繪幻想のキャラなど

本パッケージに含まれないキャラクターを登場させたい場合は `Samples/Scripts/TouhouDataPackageExtendedSample.cs` を参考に `TouhouData.Character` クラスを拡張したクラスを作成してください。

今後のキャラクター追加などを考慮して、 `TouhouData.Character` クラスそのものを変更するのは非推奨です。

### 名前について
#### 妖精の名前の扱い
スターサファイアなど、妖精たちの名前は2つの単語から構成される事が多いです。

この場合、どちらの単語も名前として扱い、苗字は無い物とみなします。

また、英名の場合は2つの単語の間に空白を入れたり、2つ目の単語の頭文字を大文字にすることもしていません。

#### キャラの英名について
原作での表記を優先します。

例えば美鈴の英名の `Meirin` はピンインでは `Meiling` と表記するのが一般的のようですが、本パッケージでは原作で使用されている `Meirin` を採用しています。

日本語の「じ」が `ji` と `zi` だったり、「し」が `si` と `shi` だったりしてヘボン式表記が混在していますが、原作表記を優先として混在を許容しています。

例外として、以下の条件を満たすキャラはTouhou Wikiにある表記を用いています。

- 原作での表記が明らかに誤字
   - スターサファイア
- 原作での表記だと正しく発音できない
   - 幽香
   - 勇儀
   - 八千慧
   - 磨弓
   - 千亦
   - 尤魔

#### キャラの中国語名について
全て[THBWiki](https://thwiki.cc/%E9%A6%96%E9%A1%B5)の表記に従っています。

### Stringについて
基本的に `Locales.En.Name` と同じですが、 `Locales.En.Name` が重複するキャラクターが存在する場合は別の値になります。

### summaryについて
summaryを見やすくするために原則、日本語と英語のsummaryのみ実装しています。

## 参考文献
- [東方元ネタwiki 2nd](https://seesaawiki.jp/toho-motoneta_2nd/d/%a5%c8%a5%c3%a5%d7%a5%da%a1%bc%a5%b8)
- [Touhou Wiki](https://en.touhouwiki.net/wiki/Touhou_Wiki)
   - [代替スペル](https://en.touhouwiki.net/wiki/Characters/Alternative_spellings)
- [THBWiki](https://thwiki.cc/%E9%A6%96%E9%A1%B5)

## サポート
本パッケージに何か問題や意見がある場合はこちらに連絡してください。

- メール：teracyans1223⑨gmail.com
   - 天才妖精を@にしてください。
- GitHub：https://github.com/TD12734/TouhouDataPackage/issues
