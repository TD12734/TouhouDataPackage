// MIT License
// 
// Copyright (c) 2025 T.D
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using UnityEngine;

namespace TouhouData
{
	public class Character
	{
		/// <summary>
		/// <para>The variable name of this Character. A unique string. ToString also returns this value.</para>
		/// <para>このCharacterの変数名です。ユニークな文字列です。ToStringもこの値を返します。</para>
		/// </summary>
		public readonly string String;
		/// <summary>
		/// <para>A unique ID, equivalent to the index when sorting the String lexicographically.</para>
		/// <para>ユニークなIDです。Stringを辞書順に並べた時のindexに相当します。</para>
		/// </summary>
		public readonly int ID;

		public class Locale
		{
			/// <summary>
			/// <para>The name of the Touhou character. Does not include family name etc.</para>
			/// <para>東方キャラの名前です。苗字などは含みません。</para>
			/// </summary>
			public readonly string Name;
			/// <summary>
			/// <para>The full name of the Touhou character.</para>
			/// <para>東方キャラのフルネームです。</para>
			/// </summary>
			public readonly string FullName;

			public Locale (string name, string fullName)
			{
				Name = name;
				FullName = fullName;
			}
		}

		public class LocaleJa : Locale
		{
			/// <summary>
			/// <para>The Touhou characters' names in hiragana. Does not include surnames etc.</para>
			/// <para>東方キャラの平仮名の名前です。苗字などは含みません。</para>
			/// </summary>
			public readonly string NameKana;
			/// <summary>
			/// <para>These are the full names of Touhou characters in hiragana.</para>
			/// <para>東方キャラの平仮名のフルネームです。</para>
			/// </summary>
			public readonly string FullNameKana;

			protected internal LocaleJa (string name, string fullName, string nameKana, string fullNameKana) : base (name, fullName)
			{
				NameKana = nameKana;
				FullNameKana = fullNameKana;
			}
		}

		public class CharacterLocales
		{
			/// <summary>
			/// <para>Japanese</para>
			/// <para>日本語</para>
			/// </summary>
			public readonly LocaleJa Ja;
			/// <summary>
			/// <para>English</para>
			/// <para>英語</para>
			/// </summary>
			public readonly Locale En;
			/// <summary>
			/// <para>Chinese</para>
			/// <para>中国語</para>
			/// <para>中文</para>
			/// </summary>
			public readonly Locale Zh;

			public CharacterLocales (LocaleJa ja, Locale en, Locale zh)
			{
				Ja = ja;
				En = en;
				Zh = zh;
			}
		}

		/// <summary>
		/// <para>This is a list of translations.</para>
		/// <para>翻訳一覧です。</para>
		/// </summary>
		public readonly CharacterLocales Locales;

		/// <summary>
		/// <para>The language used by this package. The value will be one of three things and the returned values ​​of Name and FullName change depending on the value of this variable.</para>
		/// <para>このパッケージで使用する言語です。値は以下の3つのどれかになり、この変数の値に応じてNameとFullNameの返り値が変化します。</para>
		/// <para>SystemLanguage.English(English)</para>
		/// <para>SystemLanguage.Japanese(日本語)</para>
		/// <para>SystemLanguage.Chinese(中文)</para>
		/// </summary>
		public static SystemLanguage SelectedLanguage
		{
			private set;
			get;
		}

		/// <summary>
		/// <para>The name of the Touhou character. Does not include family name etc. The returned string will vary depending on the SelectedLanguage.</para>
		/// <para>東方キャラの名前です。苗字などは含みません。SelectedLanguageに応じて返される文字列が変化します。</para>
		/// </summary>
		public string Name => GetLocaleFromSelectedLanguage ().Name;

		/// <summary>
		/// <para>The full name of the Touhou character. The returned string varies depending on the SelectedLanguage.</para>
		/// <para>東方キャラのフルネームです。SelectedLanguageに応じて返される文字列が変化します。</para>
		/// </summary>
		public string FullName => GetLocaleFromSelectedLanguage ().FullName;

		/// <summary>
		/// <para>List of IDs.</para>
		/// <para>IDの一覧です。</para>
		/// </summary>
		public class IDs
		{
			public const int Akyuu = 0;
			public const int Alice = 1;
			public const int Ariya = 2;
			public const int Aunn = 3;
			public const int Aya = 4;
			public const int Benben = 5;
			public const int Biten = 6;
			public const int Byakuren = 7;
			public const int Chen = 8;
			public const int Chimata = 9;
			public const int Chimi = 10;
			public const int Chiyari = 11;
			public const int Chiyuri = 12;
			public const int Cirno = 13;
			public const int Clownpiece = 14;
			public const int Daiyousei = 15;
			public const int Doremy = 16;
			public const int Eika = 17;
			public const int Eiki = 18;
			public const int Eirin = 19;
			public const int Ekisya = 20;
			public const int Elis = 21;
			public const int Ellen = 22;
			public const int Elly = 23;
			public const int Enoko = 24;
			public const int Eternitylarva = 25;
			public const int Flandre = 26;
			public const int Futo = 27;
			public const int Gengetu = 28;
			public const int Genjii = 29;
			public const int Hatate = 30;
			public const int Hecatia = 31;
			public const int Hina = 32;
			public const int Hisami = 33;
			public const int Ichirin = 34;
			public const int Iku = 35;
			public const int Junko = 36;
			public const int Jyoon = 37;
			public const int Kagerou = 38;
			public const int Kaguya = 39;
			public const int Kana = 40;
			public const int Kanako = 41;
			public const int Kasen = 42;
			public const int Keiki = 43;
			public const int Keine = 44;
			public const int Kikuri = 45;
			public const int Kisume = 46;
			public const int Koakuma = 47;
			public const int Kogasa = 48;
			public const int Koishi = 49;
			public const int Kokoro = 50;
			public const int Komachi = 51;
			public const int Konngara = 52;
			public const int Kosuzu = 53;
			public const int Kotohime = 54;
			public const int Kurumi = 55;
			public const int Kutaka = 56;
			public const int Kyouko = 57;
			public const int Letty = 58;
			public const int Lilywhite = 59;
			public const int Luize = 60;
			public const int Lunarchild = 61;
			public const int Lunasa = 62;
			public const int Lyrica = 63;
			public const int Mai = 64;
			public const int Mamizou = 65;
			public const int Maribel = 66;
			public const int Marisa = 67;
			public const int Mayumi = 68;
			public const int Medicine = 69;
			public const int Megumu = 70;
			public const int Meira = 71;
			public const int Meirin = 72;
			public const int Merlin = 73;
			public const int Mike = 74;
			public const int Miko = 75;
			public const int Mima = 76;
			public const int Minamitsu = 77;
			public const int Minoriko = 78;
			public const int Misumaru = 79;
			public const int Miyoi = 80;
			public const int Mizuchi = 81;
			public const int Mokou = 82;
			public const int Momizi = 83;
			public const int Momoyo = 84;
			public const int Mugetu = 85;
			public const int Mystia = 86;
			public const int Nareko = 87;
			public const int Narumi = 88;
			public const int Nazrin = 89;
			public const int Nemuno = 90;
			public const int Nina = 91;
			public const int Nitori = 92;
			public const int Nue = 93;
			public const int Okina = 94;
			public const int Orange = 95;
			public const int Parsee = 96;
			public const int Patchouli = 97;
			public const int Raiko = 98;
			public const int Ran = 99;
			public const int Reimu = 100;
			public const int Reisen = 101;
			public const int ReisenSecond = 102;
			public const int Remilia = 103;
			public const int Renko = 104;
			public const int Rika = 105;
			public const int Rikako = 106;
			public const int Rin = 107;
			public const int Ringo = 108;
			public const int Rinnosuke = 109;
			public const int Rumia = 110;
			public const int Ruukoto = 111;
			public const int Sagume = 112;
			public const int Saki = 113;
			public const int Sakuya = 114;
			public const int Sanae = 115;
			public const int Sannyo = 116;
			public const int Sara = 117;
			public const int Sariel = 118;
			public const int Satono = 119;
			public const int Satori = 120;
			public const int Seiga = 121;
			public const int Seija = 122;
			public const int Seiran = 123;
			public const int Sekibanki = 124;
			public const int Shinki = 125;
			public const int Shinmyoumaru = 126;
			public const int Shion = 127;
			public const int Shizuha = 128;
			public const int Singyoku = 129;
			public const int Starsapphire = 130;
			public const int Suika = 131;
			public const int Sumireko = 132;
			public const int Sunnymilk = 133;
			public const int Suwako = 134;
			public const int Syou = 135;
			public const int Takane = 136;
			public const int Teireida = 137;
			public const int Tenshi = 138;
			public const int Tewi = 139;
			public const int Tojiko = 140;
			public const int Tokiko = 141;
			public const int Toyohime = 142;
			public const int Tsukasa = 143;
			public const int Ubame = 144;
			public const int Urumi = 145;
			public const int Utsuho = 146;
			public const int Wakasagihime = 147;
			public const int Wriggle = 148;
			public const int Yachie = 149;
			public const int Yamame = 150;
			public const int Yatsuhashi = 151;
			public const int Yorihime = 152;
			public const int Yoshika = 153;
			public const int Youmu = 154;
			public const int Yuiman = 155;
			public const int Yukari = 156;
			public const int Yuki = 157;
			public const int Yumeko = 158;
			public const int Yumemi = 159;
			public const int Yuugenmagan = 160;
			public const int Yuugi = 161;
			public const int Yuuka = 162;
			public const int Yuuma = 163;
			public const int Yuyuko = 164;
			public const int Zanmu = 165;
		}

		public const int length = 166;

		/// <summary>
		/// <para>List of Strings.</para>
		/// <para>Stringの一覧です。</para>
		/// </summary>
		public class Strings
		{
			public const string Akyuu = "Akyuu";
			public const string Alice = "Alice";
			public const string Ariya = "Ariya";
			public const string Aunn = "Aunn";
			public const string Aya = "Aya";
			public const string Benben = "Benben";
			public const string Biten = "Biten";
			public const string Byakuren = "Byakuren";
			public const string Chen = "Chen";
			public const string Chimata = "Chimata";
			public const string Chimi = "Chimi";
			public const string Chiyari = "Chiyari";
			public const string Chiyuri = "Chiyuri";
			public const string Cirno = "Cirno";
			public const string Clownpiece = "Clownpiece";
			public const string Daiyousei = "Daiyousei";
			public const string Doremy = "Doremy";
			public const string Eika = "Eika";
			public const string Eiki = "Eiki";
			public const string Eirin = "Eirin";
			public const string Ekisya = "Ekisya";
			public const string Elis = "Elis";
			public const string Ellen = "Ellen";
			public const string Elly = "Elly";
			public const string Enoko = "Enoko";
			public const string Eternitylarva = "Eternitylarva";
			public const string Flandre = "Flandre";
			public const string Futo = "Futo";
			public const string Gengetu = "Gengetu";
			public const string Genjii = "Genjii";
			public const string Hatate = "Hatate";
			public const string Hecatia = "Hecatia";
			public const string Hina = "Hina";
			public const string Hisami = "Hisami";
			public const string Ichirin = "Ichirin";
			public const string Iku = "Iku";
			public const string Junko = "Junko";
			public const string Jyoon = "Jyoon";
			public const string Kagerou = "Kagerou";
			public const string Kaguya = "Kaguya";
			public const string Kana = "Kana";
			public const string Kanako = "Kanako";
			public const string Kasen = "Kasen";
			public const string Keiki = "Keiki";
			public const string Keine = "Keine";
			public const string Kikuri = "Kikuri";
			public const string Kisume = "Kisume";
			public const string Koakuma = "Koakuma";
			public const string Kogasa = "Kogasa";
			public const string Koishi = "Koishi";
			public const string Kokoro = "Kokoro";
			public const string Komachi = "Komachi";
			public const string Konngara = "Konngara";
			public const string Kosuzu = "Kosuzu";
			public const string Kotohime = "Kotohime";
			public const string Kurumi = "Kurumi";
			public const string Kutaka = "Kutaka";
			public const string Kyouko = "Kyouko";
			public const string Letty = "Letty";
			public const string Lilywhite = "Lilywhite";
			public const string Luize = "Luize";
			public const string Lunarchild = "Lunarchild";
			public const string Lunasa = "Lunasa";
			public const string Lyrica = "Lyrica";
			public const string Mai = "Mai";
			public const string Mamizou = "Mamizou";
			public const string Maribel = "Maribel";
			public const string Marisa = "Marisa";
			public const string Mayumi = "Mayumi";
			public const string Medicine = "Medicine";
			public const string Megumu = "Megumu";
			public const string Meira = "Meira";
			public const string Meirin = "Meirin";
			public const string Merlin = "Merlin";
			public const string Mike = "Mike";
			public const string Miko = "Miko";
			public const string Mima = "Mima";
			public const string Minamitsu = "Minamitsu";
			public const string Minoriko = "Minoriko";
			public const string Misumaru = "Misumaru";
			public const string Miyoi = "Miyoi";
			public const string Mizuchi = "Mizuchi";
			public const string Mokou = "Mokou";
			public const string Momizi = "Momizi";
			public const string Momoyo = "Momoyo";
			public const string Mugetu = "Mugetu";
			public const string Mystia = "Mystia";
			public const string Nareko = "Nareko";
			public const string Narumi = "Narumi";
			public const string Nazrin = "Nazrin";
			public const string Nemuno = "Nemuno";
			public const string Nina = "Nina";
			public const string Nitori = "Nitori";
			public const string Nue = "Nue";
			public const string Okina = "Okina";
			public const string Orange = "Orange";
			public const string Parsee = "Parsee";
			public const string Patchouli = "Patchouli";
			public const string Raiko = "Raiko";
			public const string Ran = "Ran";
			public const string Reimu = "Reimu";
			public const string Reisen = "Reisen";
			public const string ReisenSecond = "ReisenSecond";
			public const string Remilia = "Remilia";
			public const string Renko = "Renko";
			public const string Rika = "Rika";
			public const string Rikako = "Rikako";
			public const string Rin = "Rin";
			public const string Ringo = "Ringo";
			public const string Rinnosuke = "Rinnosuke";
			public const string Rumia = "Rumia";
			public const string Ruukoto = "Ruukoto";
			public const string Sagume = "Sagume";
			public const string Saki = "Saki";
			public const string Sakuya = "Sakuya";
			public const string Sanae = "Sanae";
			public const string Sannyo = "Sannyo";
			public const string Sara = "Sara";
			public const string Sariel = "Sariel";
			public const string Satono = "Satono";
			public const string Satori = "Satori";
			public const string Seiga = "Seiga";
			public const string Seija = "Seija";
			public const string Seiran = "Seiran";
			public const string Sekibanki = "Sekibanki";
			public const string Shinki = "Shinki";
			public const string Shinmyoumaru = "Shinmyoumaru";
			public const string Shion = "Shion";
			public const string Shizuha = "Shizuha";
			public const string Singyoku = "Singyoku";
			public const string Starsapphire = "Starsapphire";
			public const string Suika = "Suika";
			public const string Sumireko = "Sumireko";
			public const string Sunnymilk = "Sunnymilk";
			public const string Suwako = "Suwako";
			public const string Syou = "Syou";
			public const string Takane = "Takane";
			public const string Teireida = "Teireida";
			public const string Tenshi = "Tenshi";
			public const string Tewi = "Tewi";
			public const string Tojiko = "Tojiko";
			public const string Tokiko = "Tokiko";
			public const string Toyohime = "Toyohime";
			public const string Tsukasa = "Tsukasa";
			public const string Ubame = "Ubame";
			public const string Urumi = "Urumi";
			public const string Utsuho = "Utsuho";
			public const string Wakasagihime = "Wakasagihime";
			public const string Wriggle = "Wriggle";
			public const string Yachie = "Yachie";
			public const string Yamame = "Yamame";
			public const string Yatsuhashi = "Yatsuhashi";
			public const string Yorihime = "Yorihime";
			public const string Yoshika = "Yoshika";
			public const string Youmu = "Youmu";
			public const string Yuiman = "Yuiman";
			public const string Yukari = "Yukari";
			public const string Yuki = "Yuki";
			public const string Yumeko = "Yumeko";
			public const string Yumemi = "Yumemi";
			public const string Yuugenmagan = "Yuugenmagan";
			public const string Yuugi = "Yuugi";
			public const string Yuuka = "Yuuka";
			public const string Yuuma = "Yuuma";
			public const string Yuyuko = "Yuyuko";
			public const string Zanmu = "Zanmu";
		}

		/// <summary>
		/// <para>Hieda no Akyuu</para>
		/// <para>稗田 阿求</para>
		/// </summary>
		public static readonly Character Akyuu = new Character (
			IDs.Akyuu,
			Strings.Akyuu,
			new LocaleJa ("阿求", "稗田 阿求", "あきゅう", "ひえだ の あきゅう"),
			new Locale ("Akyuu", "Hieda no Akyuu"),
			new Locale ("阿求", "稗田 阿求")
		);
		/// <summary>
		/// <para>Alice Margatroid</para>
		/// <para>アリス・マーガトロイド</para>
		/// </summary>
		public static readonly Character Alice = new Character (
			IDs.Alice,
			Strings.Alice,
			new LocaleJa ("アリス", "アリス・マーガトロイド", "ありす", "ありす・まーがとろいど"),
			new Locale ("Alice", "Alice Margatroid"),
			new Locale ("爱丽丝", "爱丽丝·玛格特洛依德")
		);
		/// <summary>
		/// <para>Ariya Iwanaga</para>
		/// <para>磐永 阿梨夜</para>
		/// </summary>
		public static readonly Character Ariya = new Character (
			IDs.Ariya,
			Strings.Ariya,
			new LocaleJa ("阿梨夜", "磐永 阿梨夜", "ありや", "いわなが ありや"),
			new Locale ("Ariya", "Ariya Iwanaga"),
			new Locale ("阿梨夜", "磐永 阿梨夜")
		);
		/// <summary>
		/// <para>Aunn Komano</para>
		/// <para>高麗野 あうん</para>
		/// </summary>
		public static readonly Character Aunn = new Character (
			IDs.Aunn,
			Strings.Aunn,
			new LocaleJa ("あうん", "高麗野 あうん", "あうん", "こまの あうん"),
			new Locale ("Aunn", "Aunn Komano"),
			new Locale ("阿吽", "高丽野 阿吽")
		);
		/// <summary>
		/// <para>Aya Syameimaru</para>
		/// <para>射命丸 文</para>
		/// </summary>
		public static readonly Character Aya = new Character (
			IDs.Aya,
			Strings.Aya,
			new LocaleJa ("文", "射命丸 文", "あや", "しゃめいまる あや"),
			new Locale ("Aya", "Aya Syameimaru"),
			new Locale ("文", "射命丸 文")
		);
		/// <summary>
		/// <para>Benben Tsukumo</para>
		/// <para>九十九 弁々</para>
		/// </summary>
		public static readonly Character Benben = new Character (
			IDs.Benben,
			Strings.Benben,
			new LocaleJa ("弁々", "九十九 弁々", "べんべん", "つくも べんべん"),
			new Locale ("Benben", "Benben Tsukumo"),
			new Locale ("弁弁", "九十九 弁弁")
		);
		/// <summary>
		/// <para>Son Biten</para>
		/// <para>孫 美天</para>
		/// </summary>
		public static readonly Character Biten = new Character (
			IDs.Biten,
			Strings.Biten,
			new LocaleJa ("美天", "孫 美天", "びてん", "そん びてん"),
			new Locale ("Biten", "Son Biten"),
			new Locale ("美天", "孙 美天")
		);
		/// <summary>
		/// <para>Byakuren Hiziri</para>
		/// <para>聖 白蓮</para>
		/// </summary>
		public static readonly Character Byakuren = new Character (
			IDs.Byakuren,
			Strings.Byakuren,
			new LocaleJa ("白蓮", "聖 白蓮", "びゃくれん", "ひじり びゃくれん"),
			new Locale ("Byakuren", "Byakuren Hiziri"),
			new Locale ("白莲", "圣 白莲")
		);
		/// <summary>
		/// <para>Chen</para>
		/// <para>橙</para>
		/// </summary>
		public static readonly Character Chen = new Character (
			IDs.Chen,
			Strings.Chen,
			new LocaleJa ("橙", "橙", "ちぇん", "ちぇん"),
			new Locale ("Chen", "Chen"),
			new Locale ("橙", "橙")
		);
		/// <summary>
		/// <para>Chimata Tenkyuu</para>
		/// <para>天弓 千亦</para>
		/// <para>In the original work, her English name is written as Tenkyu, but with the "u" added to pronounce it like the Japanese "う".</para>
		/// <para>英名は原作ではTenkyu表記ですが、日本語の「う」を発音させるためにuを追加しています。</para>
		/// </summary>
		public static readonly Character Chimata = new Character (
			IDs.Chimata,
			Strings.Chimata,
			new LocaleJa ("千亦", "天弓 千亦", "ちまた", "てんきゅう ちまた"),
			new Locale ("Chimata", "Chimata Tenkyuu"),
			new Locale ("千亦", "天弓 千亦")
		);
		/// <summary>
		/// <para>Chimi Houjuu</para>
		/// <para>封獣 チミ</para>
		/// </summary>
		public static readonly Character Chimi = new Character (
			IDs.Chimi,
			Strings.Chimi,
			new LocaleJa ("チミ", "封獣 チミ", "ちみ", "ほうじゅう ちみ"),
			new Locale ("Chimi", "Chimi Houjuu"),
			new Locale ("魑魅", "封兽 魑魅")
		);
		/// <summary>
		/// <para>Chiyari Tenkajin</para>
		/// <para>天火人 ちやり</para>
		/// </summary>
		public static readonly Character Chiyari = new Character (
			IDs.Chiyari,
			Strings.Chiyari,
			new LocaleJa ("ちやり", "天火人 ちやり", "ちやり", "てんかじん ちやり"),
			new Locale ("Chiyari", "Chiyari Tenkajin"),
			new Locale ("血枪", "天火人 血枪")
		);
		/// <summary>
		/// <para>Chiyuri Kitashirakawa</para>
		/// <para>北白河 ちゆり</para>
		/// <para>The English name has been spelled differently from the original, Tiyuri Kitashirakawa.</para>
		/// <para>英名は原作のTiyuri Kitashirakawaからスペルが変わっています。</para>
		/// </summary>
		public static readonly Character Chiyuri = new Character (
			IDs.Chiyuri,
			Strings.Chiyuri,
			new LocaleJa ("ちゆり", "北白河 ちゆり", "ちゆり", "きたしらかわ ちゆり"),
			new Locale ("Chiyuri", "Chiyuri Kitashirakawa"),
			new Locale ("千百合", "北白河 千百合")
		);
		/// <summary>
		/// <para>Cirno</para>
		/// <para>チルノ</para>
		/// </summary>
		public static readonly Character Cirno = new Character (
			IDs.Cirno,
			Strings.Cirno,
			new LocaleJa ("チルノ", "チルノ", "ちるの", "ちるの"),
			new Locale ("Cirno", "Cirno"),
			new Locale ("琪露诺", "琪露诺")
		);
		/// <summary>
		/// <para>Clownpiece</para>
		/// <para>クラウンピース</para>
		/// </summary>
		public static readonly Character Clownpiece = new Character (
			IDs.Clownpiece,
			Strings.Clownpiece,
			new LocaleJa ("クラウンピース", "クラウンピース", "くらうんぴーす", "くらうんぴーす"),
			new Locale ("Clownpiece", "Clownpiece"),
			new Locale ("克劳恩皮丝", "克劳恩皮丝")
		);
		/// <summary>
		/// <para>Daiyousei</para>
		/// <para>大妖精</para>
		/// </summary>
		public static readonly Character Daiyousei = new Character (
			IDs.Daiyousei,
			Strings.Daiyousei,
			new LocaleJa ("大妖精", "大妖精", "だいようせい", "だいようせい"),
			new Locale ("Daiyousei", "Daiyousei"),
			new Locale ("大妖精", "大妖精")
		);
		/// <summary>
		/// <para>Doremy Sweet</para>
		/// <para>ドレミー・スイート</para>
		/// </summary>
		public static readonly Character Doremy = new Character (
			IDs.Doremy,
			Strings.Doremy,
			new LocaleJa ("ドレミー", "ドレミー・スイート", "どれみー", "どれみー・すいーと"),
			new Locale ("Doremy", "Doremy Sweet"),
			new Locale ("哆来咪", "哆来咪·苏伊特")
		);
		/// <summary>
		/// <para>Eika Ebisu</para>
		/// <para>戎 瓔花</para>
		/// </summary>
		public static readonly Character Eika = new Character (
			IDs.Eika,
			Strings.Eika,
			new LocaleJa ("瓔花", "戎 瓔花", "えいか", "えびす えいか"),
			new Locale ("Eika", "Eika Ebisu"),
			new Locale ("璎花", "戎 璎花")
		);
		/// <summary>
		/// <para>Siki Eiki Yamaxanadu</para>
		/// <para>四季 映姫・ヤマザナドゥ</para>
		/// </summary>
		public static readonly Character Eiki = new Character (
			IDs.Eiki,
			Strings.Eiki,
			new LocaleJa ("映姫", "四季 映姫・ヤマザナドゥ", "えいき", "しき えいき・やまざなどぅ"),
			new Locale ("Eiki", "Siki Eiki Yamaxanadu"),
			new Locale ("映姬", "四季 映姬·夜摩仙那度")
		);
		/// <summary>
		/// <para>Eirin Yagokoro</para>
		/// <para>八意 永琳</para>
		/// </summary>
		public static readonly Character Eirin = new Character (
			IDs.Eirin,
			Strings.Eirin,
			new LocaleJa ("永琳", "八意 永琳", "えいりん", "やごころ えいりん"),
			new Locale ("Eirin", "Eirin Yagokoro"),
			new Locale ("永琳", "八意 永琳")
		);
		/// <summary>
		/// <para>Ekisya</para>
		/// <para>易者</para>
		/// </summary>
		public static readonly Character Ekisya = new Character (
			IDs.Ekisya,
			Strings.Ekisya,
			new LocaleJa ("易者", "易者", "えきしゃ", "えきしゃ"),
			new Locale ("Ekisya", "Ekisya"),
			new Locale ("易者", "易者")
		);
		/// <summary>
		/// <para>Elis</para>
		/// <para>エリス</para>
		/// </summary>
		public static readonly Character Elis = new Character (
			IDs.Elis,
			Strings.Elis,
			new LocaleJa ("エリス", "エリス", "えりす", "えりす"),
			new Locale ("Elis", "Elis"),
			new Locale ("依莉斯", "依莉斯")
		);
		/// <summary>
		/// <para>Ellen</para>
		/// <para>エレン</para>
		/// </summary>
		public static readonly Character Ellen = new Character (
			IDs.Ellen,
			Strings.Ellen,
			new LocaleJa ("エレン", "エレン", "えれん", "えれん"),
			new Locale ("Ellen", "Ellen"),
			new Locale ("爱莲", "爱莲")
		);
		/// <summary>
		/// <para>Elly</para>
		/// <para>エリー</para>
		/// <para>The English name has been spelled differently from the original, Elliy.</para>
		/// <para>英名は原作のElliyからスペルが変わっています。</para>
		/// </summary>
		public static readonly Character Elly = new Character (
			IDs.Elly,
			Strings.Elly,
			new LocaleJa ("エリー", "エリー", "えりー", "えりー"),
			new Locale ("Elly", "Elly"),
			new Locale ("艾丽", "艾丽")
		);
		/// <summary>
		/// <para>Enoko Mitsugashira</para>
		/// <para>三頭 慧ノ子</para>
		/// </summary>
		public static readonly Character Enoko = new Character (
			IDs.Enoko,
			Strings.Enoko,
			new LocaleJa ("慧ノ子", "三頭 慧ノ子", "えのこ", "みつがしら えのこ"),
			new Locale ("Enoko", "Enoko Mitsugashira"),
			new Locale ("慧之子", "三头 慧之子")
		);
		/// <summary>
		/// <para>Eternitylarva</para>
		/// <para>エタニティラルバ</para>
		/// </summary>
		public static readonly Character Eternitylarva = new Character (
			IDs.Eternitylarva,
			Strings.Eternitylarva,
			new LocaleJa ("エタニティラルバ", "エタニティラルバ", "えたにてぃらるば", "えたにてぃらるば"),
			new Locale ("Eternitylarva", "Eternitylarva"),
			new Locale ("爱塔妮缇拉尔瓦", "爱塔妮缇拉尔瓦")
		);
		/// <summary>
		/// <para>Flandre Scarlet</para>
		/// <para>フランドール・スカーレット</para>
		/// </summary>
		public static readonly Character Flandre = new Character (
			IDs.Flandre,
			Strings.Flandre,
			new LocaleJa ("フランドール", "フランドール・スカーレット", "ふらんどーる", "ふらんどーる・すかーれっと"),
			new Locale ("Flandre", "Flandre Scarlet"),
			new Locale ("芙兰朵露", "芙兰朵露·斯卡蕾特")
		);
		/// <summary>
		/// <para>Mononobe no Futo</para>
		/// <para>物部 布都</para>
		/// </summary>
		public static readonly Character Futo = new Character (
			IDs.Futo,
			Strings.Futo,
			new LocaleJa ("布都", "物部 布都", "ふと", "もののべ の ふと"),
			new Locale ("Futo", "Mononobe no Futo"),
			new Locale ("布都", "物部 布都")
		);
		/// <summary>
		/// <para>Gengetu</para>
		/// <para>幻月</para>
		/// </summary>
		public static readonly Character Gengetu = new Character (
			IDs.Gengetu,
			Strings.Gengetu,
			new LocaleJa ("幻月", "幻月", "げんげつ", "げんげつ"),
			new Locale ("Gengetu", "Gengetu"),
			new Locale ("幻月", "幻月")
		);
		/// <summary>
		/// <para>Genjii</para>
		/// <para>玄爺</para>
		/// </summary>
		public static readonly Character Genjii = new Character (
			IDs.Genjii,
			Strings.Genjii,
			new LocaleJa ("玄爺", "玄爺", "げんじい", "げんじい"),
			new Locale ("Genjii", "Genjii"),
			new Locale ("玄爷", "玄爷")
		);
		/// <summary>
		/// <para>Hatate Himekaidou</para>
		/// <para>姫海棠 はたて</para>
		/// </summary>
		public static readonly Character Hatate = new Character (
			IDs.Hatate,
			Strings.Hatate,
			new LocaleJa ("はたて", "姫海棠 はたて", "はたて", "ひめかいどう はたて"),
			new Locale ("Hatate", "Hatate Himekaidou"),
			new Locale ("果", "姬海棠 果")
		);
		/// <summary>
		/// <para>Hecatia Lapislazuli</para>
		/// <para>ヘカーティア・ラピスラズリ</para>
		/// </summary>
		public static readonly Character Hecatia = new Character (
			IDs.Hecatia,
			Strings.Hecatia,
			new LocaleJa ("ヘカーティア", "ヘカーティア・ラピスラズリ", "へかーてぃあ", "へかーてぃあ・らぴすらずり"),
			new Locale ("Hecatia", "Hecatia Lapislazuli"),
			new Locale ("赫卡提亚", "赫卡提亚·拉碧斯拉祖利")
		);
		/// <summary>
		/// <para>Hina Kagiyama</para>
		/// <para>鍵山 雛</para>
		/// </summary>
		public static readonly Character Hina = new Character (
			IDs.Hina,
			Strings.Hina,
			new LocaleJa ("雛", "鍵山 雛", "ひな", "かぎやま ひな"),
			new Locale ("Hina", "Hina Kagiyama"),
			new Locale ("雏", "键山 雏")
		);
		/// <summary>
		/// <para>Hisami Yomotsu</para>
		/// <para>豫母都 日狭美</para>
		/// </summary>
		public static readonly Character Hisami = new Character (
			IDs.Hisami,
			Strings.Hisami,
			new LocaleJa ("日狭美", "豫母都 日狭美", "ひさみ", "よもつ ひさみ"),
			new Locale ("Hisami", "Hisami Yomotsu"),
			new Locale ("日狭美", "豫母都 日狭美")
		);
		/// <summary>
		/// <para>Ichirin Kumoi</para>
		/// <para>雲居 一輪</para>
		/// </summary>
		public static readonly Character Ichirin = new Character (
			IDs.Ichirin,
			Strings.Ichirin,
			new LocaleJa ("一輪", "雲居 一輪", "いちりん", "くもい いちりん"),
			new Locale ("Ichirin", "Ichirin Kumoi"),
			new Locale ("一轮", "云居 一轮")
		);
		/// <summary>
		/// <para>Iku Nagae</para>
		/// <para>永江 衣玖</para>
		/// </summary>
		public static readonly Character Iku = new Character (
			IDs.Iku,
			Strings.Iku,
			new LocaleJa ("衣玖", "永江 衣玖", "いく", "ながえ いく"),
			new Locale ("Iku", "Iku Nagae"),
			new Locale ("衣玖", "永江 衣玖")
		);
		/// <summary>
		/// <para>Junko</para>
		/// <para>純狐</para>
		/// </summary>
		public static readonly Character Junko = new Character (
			IDs.Junko,
			Strings.Junko,
			new LocaleJa ("純狐", "純狐", "じゅんこ", "じゅんこ"),
			new Locale ("Junko", "Junko"),
			new Locale ("纯狐", "纯狐")
		);
		/// <summary>
		/// <para>Jyoon Yorigami</para>
		/// <para>依神 女苑</para>
		/// <para>In the Touhou Wiki, the English name is listed as Joon, but in Sunken Fossil World it's Jyoon, so that's the one we've used in this package.</para>
		/// <para>Touhou Wikiでは英名はJoonになっていますが、東方剛欲異聞ではJyoonなので本パッケージではこちらを採用しています。</para>
		/// </summary>
		public static readonly Character Jyoon = new Character (
			IDs.Jyoon,
			Strings.Jyoon,
			new LocaleJa ("女苑", "依神 女苑", "じょおん", "よりがみ じょおん"),
			new Locale ("Jyoon", "Jyoon Yorigami"),
			new Locale ("女苑", "依神 女苑")
		);
		/// <summary>
		/// <para>Kagerou Imaizumi</para>
		/// <para>今泉 影狼</para>
		/// </summary>
		public static readonly Character Kagerou = new Character (
			IDs.Kagerou,
			Strings.Kagerou,
			new LocaleJa ("影狼", "今泉 影狼", "かげろう", "いまいずみ かげろう"),
			new Locale ("Kagerou", "Kagerou Imaizumi"),
			new Locale ("影狼", "今泉 影狼")
		);
		/// <summary>
		/// <para>Kaguya Houraisan</para>
		/// <para>蓬莱山 輝夜</para>
		/// </summary>
		public static readonly Character Kaguya = new Character (
			IDs.Kaguya,
			Strings.Kaguya,
			new LocaleJa ("輝夜", "蓬莱山 輝夜", "かぐや", "ほうらいさん かぐや"),
			new Locale ("Kaguya", "Kaguya Houraisan"),
			new Locale ("辉夜", "蓬莱山 辉夜")
		);
		/// <summary>
		/// <para>Kana Anaberal</para>
		/// <para>カナ・アナベラル</para>
		/// </summary>
		public static readonly Character Kana = new Character (
			IDs.Kana,
			Strings.Kana,
			new LocaleJa ("カナ", "カナ・アナベラル", "かな", "かな・あなべらる"),
			new Locale ("Kana", "Kana Anaberal"),
			new Locale ("卡娜", "卡娜·安娜贝拉尔")
		);
		/// <summary>
		/// <para>Kanako Yasaka</para>
		/// <para>八坂 神奈子</para>
		/// </summary>
		public static readonly Character Kanako = new Character (
			IDs.Kanako,
			Strings.Kanako,
			new LocaleJa ("神奈子", "八坂 神奈子", "かなこ", "やさか かなこ"),
			new Locale ("Kanako", "Kanako Yasaka"),
			new Locale ("神奈子", "八坂 神奈子")
		);
		/// <summary>
		/// <para>Kasen Ibaraki</para>
		/// <para>茨木 華扇</para>
		/// </summary>
		public static readonly Character Kasen = new Character (
			IDs.Kasen,
			Strings.Kasen,
			new LocaleJa ("華扇", "茨木 華扇", "かせん", "いばらき かせん"),
			new Locale ("Kasen", "Kasen Ibaraki"),
			new Locale ("华扇", "茨木 华扇")
		);
		/// <summary>
		/// <para>Keiki Haniyasushin</para>
		/// <para>埴安神 袿姫</para>
		/// </summary>
		public static readonly Character Keiki = new Character (
			IDs.Keiki,
			Strings.Keiki,
			new LocaleJa ("袿姫", "埴安神 袿姫", "けいき", "はにやすしん けいき"),
			new Locale ("Keiki", "Keiki Haniyasushin"),
			new Locale ("袿姬", "埴安神 袿姬")
		);
		/// <summary>
		/// <para>Keine Kamishirasawa</para>
		/// <para>上白沢 慧音</para>
		/// </summary>
		public static readonly Character Keine = new Character (
			IDs.Keine,
			Strings.Keine,
			new LocaleJa ("慧音", "上白沢 慧音", "けいね", "かみしらさわ けいね"),
			new Locale ("Keine", "Keine Kamishirasawa"),
			new Locale ("慧音", "上白泽 慧音")
		);
		/// <summary>
		/// <para>Kikuri</para>
		/// <para>キクリ</para>
		/// </summary>
		public static readonly Character Kikuri = new Character (
			IDs.Kikuri,
			Strings.Kikuri,
			new LocaleJa ("キクリ", "キクリ", "きくり", "きくり"),
			new Locale ("Kikuri", "Kikuri"),
			new Locale ("菊理", "菊理")
		);
		/// <summary>
		/// <para>Kisume</para>
		/// <para>キスメ</para>
		/// </summary>
		public static readonly Character Kisume = new Character (
			IDs.Kisume,
			Strings.Kisume,
			new LocaleJa ("キスメ", "キスメ", "きすめ", "きすめ"),
			new Locale ("Kisume", "Kisume"),
			new Locale ("琪斯美", "琪斯美")
		);
		/// <summary>
		/// <para>Koakuma</para>
		/// <para>小悪魔</para>
		/// </summary>
		public static readonly Character Koakuma = new Character (
			IDs.Koakuma,
			Strings.Koakuma,
			new LocaleJa ("小悪魔", "小悪魔", "こあくま", "こあくま"),
			new Locale ("Koakuma", "Koakuma"),
			new Locale ("小恶魔", "小恶魔")
		);
		/// <summary>
		/// <para>Kogasa Tatara</para>
		/// <para>多々良 小傘</para>
		/// </summary>
		public static readonly Character Kogasa = new Character (
			IDs.Kogasa,
			Strings.Kogasa,
			new LocaleJa ("小傘", "多々良 小傘", "こがさ", "たたら こがさ"),
			new Locale ("Kogasa", "Kogasa Tatara"),
			new Locale ("小伞", "多多良 小伞")
		);
		/// <summary>
		/// <para>Koishi Komeiji</para>
		/// <para>古明地 こいし</para>
		/// </summary>
		public static readonly Character Koishi = new Character (
			IDs.Koishi,
			Strings.Koishi,
			new LocaleJa ("こいし", "古明地 こいし", "こいし", "こめいじ こいし"),
			new Locale ("Koishi", "Koishi Komeiji"),
			new Locale ("恋", "古明地 恋")
		);
		/// <summary>
		/// <para>Hata no Kokoro</para>
		/// <para>秦 こころ</para>
		/// </summary>
		public static readonly Character Kokoro = new Character (
			IDs.Kokoro,
			Strings.Kokoro,
			new LocaleJa ("こころ", "秦 こころ", "こころ", "はた の こころ"),
			new Locale ("Kokoro", "Hata no Kokoro"),
			new Locale ("心", "秦 心")
		);
		/// <summary>
		/// <para>Komachi Onoduka</para>
		/// <para>小野塚 小町</para>
		/// </summary>
		public static readonly Character Komachi = new Character (
			IDs.Komachi,
			Strings.Komachi,
			new LocaleJa ("小町", "小野塚 小町", "こまち", "おのづか こまち"),
			new Locale ("Komachi", "Komachi Onoduka"),
			new Locale ("小町", "小野塚 小町")
		);
		/// <summary>
		/// <para>Konngara</para>
		/// <para>コンガラ</para>
		/// </summary>
		public static readonly Character Konngara = new Character (
			IDs.Konngara,
			Strings.Konngara,
			new LocaleJa ("コンガラ", "コンガラ", "こんがら", "こんがら"),
			new Locale ("Konngara", "Konngara"),
			new Locale ("矜羯罗", "矜羯罗")
		);
		/// <summary>
		/// <para>Kosuzu Motoori</para>
		/// <para>本居 小鈴</para>
		/// </summary>
		public static readonly Character Kosuzu = new Character (
			IDs.Kosuzu,
			Strings.Kosuzu,
			new LocaleJa ("小鈴", "本居 小鈴", "こすず", "もとおり こすず"),
			new Locale ("Kosuzu", "Kosuzu Motoori"),
			new Locale ("小铃", "本居 小铃")
		);
		/// <summary>
		/// <para>Kotohime</para>
		/// <para>小兎姫</para>
		/// </summary>
		public static readonly Character Kotohime = new Character (
			IDs.Kotohime,
			Strings.Kotohime,
			new LocaleJa ("小兎姫", "小兎姫", "ことひめ", "ことひめ"),
			new Locale ("Kotohime", "Kotohime"),
			new Locale ("小兔姬", "小兔姬")
		);
		/// <summary>
		/// <para>Kurumi</para>
		/// <para>くるみ</para>
		/// </summary>
		public static readonly Character Kurumi = new Character (
			IDs.Kurumi,
			Strings.Kurumi,
			new LocaleJa ("くるみ", "くるみ", "くるみ", "くるみ"),
			new Locale ("Kurumi", "Kurumi"),
			new Locale ("胡桃", "胡桃")
		);
		/// <summary>
		/// <para>Kutaka Niwatari</para>
		/// <para>庭渡 久侘歌</para>
		/// </summary>
		public static readonly Character Kutaka = new Character (
			IDs.Kutaka,
			Strings.Kutaka,
			new LocaleJa ("久侘歌", "庭渡 久侘歌", "くたか", "にわたり くたか"),
			new Locale ("Kutaka", "Kutaka Niwatari"),
			new Locale ("久侘歌", "庭渡 久侘歌")
		);
		/// <summary>
		/// <para>Kyouko Kasodani</para>
		/// <para>幽谷 響子</para>
		/// </summary>
		public static readonly Character Kyouko = new Character (
			IDs.Kyouko,
			Strings.Kyouko,
			new LocaleJa ("響子", "幽谷 響子", "きょうこ", "かそだに きょうこ"),
			new Locale ("Kyouko", "Kyouko Kasodani"),
			new Locale ("响子", "幽谷 响子")
		);
		/// <summary>
		/// <para>Letty Whiterock</para>
		/// <para>レティ・ホワイトロック</para>
		/// </summary>
		public static readonly Character Letty = new Character (
			IDs.Letty,
			Strings.Letty,
			new LocaleJa ("レティ", "レティ・ホワイトロック", "れてぃ", "れてぃ・ほわいとろっく"),
			new Locale ("Letty", "Letty Whiterock"),
			new Locale ("蕾蒂", "蕾蒂·霍瓦特洛克")
		);
		/// <summary>
		/// <para>Lilywhite</para>
		/// <para>リリーホワイト</para>
		/// </summary>
		public static readonly Character Lilywhite = new Character (
			IDs.Lilywhite,
			Strings.Lilywhite,
			new LocaleJa ("リリーホワイト", "リリーホワイト", "りりーほわいと", "りりーほわいと"),
			new Locale ("Lilywhite", "Lilywhite"),
			new Locale ("莉莉霍瓦特", "莉莉霍瓦特")
		);
		/// <summary>
		/// <para>Luize</para>
		/// <para>ルイズ</para>
		/// </summary>
		public static readonly Character Luize = new Character (
			IDs.Luize,
			Strings.Luize,
			new LocaleJa ("ルイズ", "ルイズ", "るいず", "るいず"),
			new Locale ("Luize", "Luize"),
			new Locale ("露易兹", "露易兹")
		);
		/// <summary>
		/// <para>Lunarchild</para>
		/// <para>ルナチャイルド</para>
		/// </summary>
		public static readonly Character Lunarchild = new Character (
			IDs.Lunarchild,
			Strings.Lunarchild,
			new LocaleJa ("ルナチャイルド", "ルナチャイルド", "るなちゃいるど", "るなちゃいるど"),
			new Locale ("Lunarchild", "Lunarchild"),
			new Locale ("露娜切露德", "露娜切露德")
		);
		/// <summary>
		/// <para>Lunasa Prismriver</para>
		/// <para>ルナサ・プリズムリバー</para>
		/// </summary>
		public static readonly Character Lunasa = new Character (
			IDs.Lunasa,
			Strings.Lunasa,
			new LocaleJa ("ルナサ", "ルナサ・プリズムリバー", "るなさ", "るなさ・ぷりずむりばー"),
			new Locale ("Lunasa", "Lunasa Prismriver"),
			new Locale ("露娜萨", "露娜萨·普莉兹姆利巴")
		);
		/// <summary>
		/// <para>Lyrica Prismriver</para>
		/// <para>リリカ・プリズムリバー</para>
		/// </summary>
		public static readonly Character Lyrica = new Character (
			IDs.Lyrica,
			Strings.Lyrica,
			new LocaleJa ("リリカ", "リリカ・プリズムリバー", "りりか", "りりか・ぷりずむりばー"),
			new Locale ("Lyrica", "Lyrica Prismriver"),
			new Locale ("莉莉卡", "莉莉卡·普莉兹姆利巴")
		);
		/// <summary>
		/// <para>Mai</para>
		/// <para>マイ</para>
		/// <para>This character is Mai from Mystic Square. For Mai Teireida in Hidden Star in Four Seasons, please refer to Character.Teireida.</para>
		/// <para>このキャラクターは東方怪綺談のマイです。東方天空璋の丁礼田 舞はCharacter.Teireidaを参照してください。</para>
		/// </summary>
		public static readonly Character Mai = new Character (
			IDs.Mai,
			Strings.Mai,
			new LocaleJa ("マイ", "マイ", "まい", "まい"),
			new Locale ("Mai", "Mai"),
			new Locale ("舞", "舞")
		);
		/// <summary>
		/// <para>Mamizou Hutatsuiwa</para>
		/// <para>二ッ岩 マミゾウ</para>
		/// </summary>
		public static readonly Character Mamizou = new Character (
			IDs.Mamizou,
			Strings.Mamizou,
			new LocaleJa ("マミゾウ", "二ッ岩 マミゾウ", "まみぞう", "ふたついわ まみぞう"),
			new Locale ("Mamizou", "Mamizou Hutatsuiwa"),
			new Locale ("猯藏", "二岩 猯藏")
		);
		/// <summary>
		/// <para>Maribel Hearn</para>
		/// <para>マエリベリー・ハーン</para>
		/// <para>This character is more commonly referred to as Merry. The exact spelling of her English name is unknown, and Maribel Hearn is not the official spelling.</para>
		/// <para>このキャラクターはメリーで呼ばれる事の方が多いです。英名の正確な綴りは不明であり、Maribel Hearnは公式の綴りではありません。</para>
		/// </summary>
		public static readonly Character Maribel = new Character (
			IDs.Maribel,
			Strings.Maribel,
			new LocaleJa ("マエリベリー", "マエリベリー・ハーン", "まえりべりー", "まえりべりー・はーん"),
			new Locale ("Maribel", "Maribel Hearn"),
			new Locale ("玛艾露贝莉", "玛艾露贝莉·赫恩")
		);
		/// <summary>
		/// <para>Marisa Kirisame</para>
		/// <para>霧雨 魔理沙</para>
		/// </summary>
		public static readonly Character Marisa = new Character (
			IDs.Marisa,
			Strings.Marisa,
			new LocaleJa ("魔理沙", "霧雨 魔理沙", "まりさ", "きりさめ まりさ"),
			new Locale ("Marisa", "Marisa Kirisame"),
			new Locale ("魔理沙", "雾雨 魔理沙")
		);
		/// <summary>
		/// <para>Mayumi Joutouguu</para>
		/// <para>杖刀偶 磨弓</para>
		/// <para>In the original work, her English name is written as Joutougu, but with the "u" added to pronounce it like the Japanese "う".</para>
		/// <para>英名は原作ではJoutougu表記ですが、日本語の「う」を発音させるためにuを追加しています。</para>
		/// </summary>
		public static readonly Character Mayumi = new Character (
			IDs.Mayumi,
			Strings.Mayumi,
			new LocaleJa ("磨弓", "杖刀偶 磨弓", "まゆみ", "じょうとうぐう まゆみ"),
			new Locale ("Mayumi", "Mayumi Joutouguu"),
			new Locale ("磨弓", "杖刀偶 磨弓")
		);
		/// <summary>
		/// <para>Medicine Melancholy</para>
		/// <para>メディスン・メランコリー</para>
		/// </summary>
		public static readonly Character Medicine = new Character (
			IDs.Medicine,
			Strings.Medicine,
			new LocaleJa ("メディスン", "メディスン・メランコリー", "めでぃすん", "めでぃすん・めらんこりー"),
			new Locale ("Medicine", "Medicine Melancholy"),
			new Locale ("梅蒂欣", "梅蒂欣·梅兰可莉")
		);
		/// <summary>
		/// <para>Megumu Iizunamaru</para>
		/// <para>飯綱丸 龍</para>
		/// </summary>
		public static readonly Character Megumu = new Character (
			IDs.Megumu,
			Strings.Megumu,
			new LocaleJa ("龍", "飯綱丸 龍", "めぐむ", "いいずなまる めぐむ"),
			new Locale ("Megumu", "Megumu Iizunamaru"),
			new Locale ("龙", "饭纲丸 龙")
		);
		/// <summary>
		/// <para>Meira</para>
		/// <para>明羅</para>
		/// </summary>
		public static readonly Character Meira = new Character (
			IDs.Meira,
			Strings.Meira,
			new LocaleJa ("明羅", "明羅", "めいら", "めいら"),
			new Locale ("Meira", "Meira"),
			new Locale ("明罗", "明罗")
		);
		/// <summary>
		/// <para>Hong Meirin</para>
		/// <para>紅 美鈴</para>
		/// <para>It seems that the English name is generally written as Meiling in pinyin, but this package uses Meirin, which is the name used in the original work.</para>
		/// <para>英名はピンインではMeilingと表記するのが一般的のようですが、本パッケージでは原作で使用されているMeirinを採用しています。</para>
		/// </summary>
		public static readonly Character Meirin = new Character (
			IDs.Meirin,
			Strings.Meirin,
			new LocaleJa ("美鈴", "紅 美鈴", "めいりん", "ほん めいりん"),
			new Locale ("Meirin", "Hong Meirin"),
			new Locale ("美铃", "红 美铃")
		);
		/// <summary>
		/// <para>Merlin Prismriver</para>
		/// <para>メルラン・プリズムリバー</para>
		/// </summary>
		public static readonly Character Merlin = new Character (
			IDs.Merlin,
			Strings.Merlin,
			new LocaleJa ("メルラン", "メルラン・プリズムリバー", "めるらん", "めるらん・ぷりずむりばー"),
			new Locale ("Merlin", "Merlin Prismriver"),
			new Locale ("梅露兰", "梅露兰·普莉兹姆利巴")
		);
		/// <summary>
		/// <para>Mike Goutokuzi</para>
		/// <para>豪徳寺 ミケ</para>
		/// </summary>
		public static readonly Character Mike = new Character (
			IDs.Mike,
			Strings.Mike,
			new LocaleJa ("ミケ", "豪徳寺 ミケ", "みけ", "ごうとくじ みけ"),
			new Locale ("Mike", "Mike Goutokuzi"),
			new Locale ("三花", "豪德寺 三花")
		);
		/// <summary>
		/// <para>Toyosatomimi no Miko</para>
		/// <para>豊聡耳 神子</para>
		/// </summary>
		public static readonly Character Miko = new Character (
			IDs.Miko,
			Strings.Miko,
			new LocaleJa ("神子", "豊聡耳 神子", "みこ", "とよさとみみ の みこ"),
			new Locale ("Miko", "Toyosatomimi no Miko"),
			new Locale ("神子", "丰聪耳 神子")
		);
		/// <summary>
		/// <para>Mima</para>
		/// <para>魅魔</para>
		/// </summary>
		public static readonly Character Mima = new Character (
			IDs.Mima,
			Strings.Mima,
			new LocaleJa ("魅魔", "魅魔", "みま", "みま"),
			new Locale ("Mima", "Mima"),
			new Locale ("魅魔", "魅魔")
		);
		/// <summary>
		/// <para>Minamitsu Murasa</para>
		/// <para>村紗 水蜜</para>
		/// </summary>
		public static readonly Character Minamitsu = new Character (
			IDs.Minamitsu,
			Strings.Minamitsu,
			new LocaleJa ("水蜜", "村紗 水蜜", "みなみつ", "むらさ みなみつ"),
			new Locale ("Minamitsu", "Minamitsu Murasa"),
			new Locale ("水蜜", "村纱 水蜜")
		);
		/// <summary>
		/// <para>Minoriko Aki</para>
		/// <para>秋 穣子</para>
		/// </summary>
		public static readonly Character Minoriko = new Character (
			IDs.Minoriko,
			Strings.Minoriko,
			new LocaleJa ("穣子", "秋 穣子", "みのりこ", "あき みのりこ"),
			new Locale ("Minoriko", "Minoriko Aki"),
			new Locale ("穰子", "秋 穰子")
		);
		/// <summary>
		/// <para>Misumaru Tamatsukuri</para>
		/// <para>玉造 魅須丸</para>
		/// </summary>
		public static readonly Character Misumaru = new Character (
			IDs.Misumaru,
			Strings.Misumaru,
			new LocaleJa ("魅須丸", "玉造 魅須丸", "みすまる", "たまつくり みすまる"),
			new Locale ("Misumaru", "Misumaru Tamatsukuri"),
			new Locale ("魅须丸", "玉造 魅须丸")
		);
		/// <summary>
		/// <para>Miyoi Okunoda</para>
		/// <para>奥野田 美宵</para>
		/// </summary>
		public static readonly Character Miyoi = new Character (
			IDs.Miyoi,
			Strings.Miyoi,
			new LocaleJa ("美宵", "奥野田 美宵", "みよい", "おくのだ みよい"),
			new Locale ("Miyoi", "Miyoi Okunoda"),
			new Locale ("美宵", "奥野田 美宵")
		);
		/// <summary>
		/// <para>Mizuchi Miyadeguchi</para>
		/// <para>宮出口 瑞霊</para>
		/// </summary>
		public static readonly Character Mizuchi = new Character (
			IDs.Mizuchi,
			Strings.Mizuchi,
			new LocaleJa ("瑞霊", "宮出口 瑞霊", "みずち", "みやでぐち みずち"),
			new Locale ("Mizuchi", "Mizuchi Miyadeguchi"),
			new Locale ("瑞灵", "宫出口 瑞灵")
		);
		/// <summary>
		/// <para>Fujiwara no Mokou</para>
		/// <para>藤原 妹紅</para>
		/// </summary>
		public static readonly Character Mokou = new Character (
			IDs.Mokou,
			Strings.Mokou,
			new LocaleJa ("妹紅", "藤原 妹紅", "もこう", "ふじわら の もこう"),
			new Locale ("Mokou", "Fujiwara no Mokou"),
			new Locale ("妹红", "藤原 妹红")
		);
		/// <summary>
		/// <para>Momizi Inubashiri</para>
		/// <para>犬走 椛</para>
		/// </summary>
		public static readonly Character Momizi = new Character (
			IDs.Momizi,
			Strings.Momizi,
			new LocaleJa ("椛", "犬走 椛", "もみじ", "いぬばしり もみじ"),
			new Locale ("Momizi", "Momizi Inubashiri"),
			new Locale ("椛", "犬走 椛")
		);
		/// <summary>
		/// <para>Momoyo Himemushi</para>
		/// <para>姫虫 百々世</para>
		/// </summary>
		public static readonly Character Momoyo = new Character (
			IDs.Momoyo,
			Strings.Momoyo,
			new LocaleJa ("百々世", "姫虫 百々世", "ももよ", "ひめむし ももよ"),
			new Locale ("Momoyo", "Momoyo Himemushi"),
			new Locale ("百百世", "姬虫 百百世")
		);
		/// <summary>
		/// <para>Mugetu</para>
		/// <para>夢月</para>
		/// </summary>
		public static readonly Character Mugetu = new Character (
			IDs.Mugetu,
			Strings.Mugetu,
			new LocaleJa ("夢月", "夢月", "むげつ", "むげつ"),
			new Locale ("Mugetu", "Mugetu"),
			new Locale ("梦月", "梦月")
		);
		/// <summary>
		/// <para>Mystia Lorelei</para>
		/// <para>ミスティア・ローレライ</para>
		/// </summary>
		public static readonly Character Mystia = new Character (
			IDs.Mystia,
			Strings.Mystia,
			new LocaleJa ("ミスティア", "ミスティア・ローレライ", "みすてぃあ", "みすてぃあ・ろーれらい"),
			new Locale ("Mystia", "Mystia Lorelei"),
			new Locale ("米斯蒂娅", "米斯蒂娅·萝蕾拉")
		);
		/// <summary>
		/// <para>Nareko Michigami</para>
		/// <para>道神 馴子</para>
		/// </summary>
		public static readonly Character Nareko = new Character (
			IDs.Nareko,
			Strings.Nareko,
			new LocaleJa ("馴子", "道神 馴子", "なれこ", "みちがみ なれこ"),
			new Locale ("Nareko", "Nareko Michigami"),
			new Locale ("驯子", "道神 驯子")
		);
		/// <summary>
		/// <para>Narumi Yatadera</para>
		/// <para>矢田寺 成美</para>
		/// </summary>
		public static readonly Character Narumi = new Character (
			IDs.Narumi,
			Strings.Narumi,
			new LocaleJa ("成美", "矢田寺 成美", "なるみ", "やたでら なるみ"),
			new Locale ("Narumi", "Narumi Yatadera"),
			new Locale ("成美", "矢田寺 成美")
		);
		/// <summary>
		/// <para>Nazrin</para>
		/// <para>ナズーリン</para>
		/// </summary>
		public static readonly Character Nazrin = new Character (
			IDs.Nazrin,
			Strings.Nazrin,
			new LocaleJa ("ナズーリン", "ナズーリン", "なずーりん", "なずーりん"),
			new Locale ("Nazrin", "Nazrin"),
			new Locale ("娜兹玲", "娜兹玲")
		);
		/// <summary>
		/// <para>Nemuno Sakata</para>
		/// <para>坂田 ネムノ</para>
		/// </summary>
		public static readonly Character Nemuno = new Character (
			IDs.Nemuno,
			Strings.Nemuno,
			new LocaleJa ("ネムノ", "坂田 ネムノ", "ねむの", "さかた ねむの"),
			new Locale ("Nemuno", "Nemuno Sakata"),
			new Locale ("合欢", "坂田 合欢")
		);
		/// <summary>
		/// <para>Nina Watari</para>
		/// <para>渡里 ニナ</para>
		/// </summary>
		public static readonly Character Nina = new Character (
			IDs.Nina,
			Strings.Nina,
			new LocaleJa ("ニナ", "渡里 ニナ", "にな", "わたり にな"),
			new Locale ("Nina", "Nina Watari"),
			new Locale ("贝子", "渡里 贝子")
		);
		/// <summary>
		/// <para>Nitori Kawashiro</para>
		/// <para>河城 にとり</para>
		/// </summary>
		public static readonly Character Nitori = new Character (
			IDs.Nitori,
			Strings.Nitori,
			new LocaleJa ("にとり", "河城 にとり", "にとり", "かわしろ にとり"),
			new Locale ("Nitori", "Nitori Kawashiro"),
			new Locale ("荷取", "河城 荷取")
		);
		/// <summary>
		/// <para>Nue Houjuu</para>
		/// <para>封獣 ぬえ</para>
		/// </summary>
		public static readonly Character Nue = new Character (
			IDs.Nue,
			Strings.Nue,
			new LocaleJa ("ぬえ", "封獣 ぬえ", "ぬえ", "ほうじゅう ぬえ"),
			new Locale ("Nue", "Nue Houjuu"),
			new Locale ("鵺", "封兽 鵺")
		);
		/// <summary>
		/// <para>Okina Matara</para>
		/// <para>摩多羅 隠岐奈</para>
		/// </summary>
		public static readonly Character Okina = new Character (
			IDs.Okina,
			Strings.Okina,
			new LocaleJa ("隠岐奈", "摩多羅 隠岐奈", "おきな", "またら おきな"),
			new Locale ("Okina", "Okina Matara"),
			new Locale ("隐岐奈", "摩多罗 隐岐奈")
		);
		/// <summary>
		/// <para>Orange</para>
		/// <para>オレンジ</para>
		/// </summary>
		public static readonly Character Orange = new Character (
			IDs.Orange,
			Strings.Orange,
			new LocaleJa ("オレンジ", "オレンジ", "おれんじ", "おれんじ"),
			new Locale ("Orange", "Orange"),
			new Locale ("奥莲姬", "奥莲姬")
		);
		/// <summary>
		/// <para>Parsee Mizuhashi</para>
		/// <para>水橋 パルスィ</para>
		/// </summary>
		public static readonly Character Parsee = new Character (
			IDs.Parsee,
			Strings.Parsee,
			new LocaleJa ("パルスィ", "水橋 パルスィ", "ぱるすぃ", "みずはし ぱるすぃ"),
			new Locale ("Parsee", "Parsee Mizuhashi"),
			new Locale ("帕露西", "水桥 帕露西")
		);
		/// <summary>
		/// <para>Patchouli Knowledge</para>
		/// <para>パチュリー・ノーレッジ</para>
		/// </summary>
		public static readonly Character Patchouli = new Character (
			IDs.Patchouli,
			Strings.Patchouli,
			new LocaleJa ("パチュリー", "パチュリー・ノーレッジ", "ぱちゅりー", "ぱちゅりー・のーれっじ"),
			new Locale ("Patchouli", "Patchouli Knowledge"),
			new Locale ("帕秋莉", "帕秋莉·诺蕾姬")
		);
		/// <summary>
		/// <para>Raiko Horikawa</para>
		/// <para>堀川 雷鼓</para>
		/// </summary>
		public static readonly Character Raiko = new Character (
			IDs.Raiko,
			Strings.Raiko,
			new LocaleJa ("雷鼓", "堀川 雷鼓", "らいこ", "ほりかわ らいこ"),
			new Locale ("Raiko", "Raiko Horikawa"),
			new Locale ("雷鼓", "堀川 雷鼓")
		);
		/// <summary>
		/// <para>Ran Yakumo</para>
		/// <para>八雲 藍</para>
		/// </summary>
		public static readonly Character Ran = new Character (
			IDs.Ran,
			Strings.Ran,
			new LocaleJa ("藍", "八雲 藍", "らん", "やくも らん"),
			new Locale ("Ran", "Ran Yakumo"),
			new Locale ("蓝", "八云 蓝")
		);
		/// <summary>
		/// <para>Reimu Hakurei</para>
		/// <para>博麗 霊夢</para>
		/// </summary>
		public static readonly Character Reimu = new Character (
			IDs.Reimu,
			Strings.Reimu,
			new LocaleJa ("霊夢", "博麗 霊夢", "れいむ", "はくれい れいむ"),
			new Locale ("Reimu", "Reimu Hakurei"),
			new Locale ("灵梦", "博丽 灵梦")
		);
		/// <summary>
		/// <para>Reisen Udongein Inaba</para>
		/// <para>鈴仙・優曇華院・イナバ</para>
		/// <para>This character is Reisen Udongein Inaba from Imperishable Night. For Reisen in Bougetsushou, please refer to Character.ReisenSecond.</para>
		/// <para>このキャラクターは東方永夜抄の鈴仙・優曇華院・イナバです。東方儚月抄のレイセンはCharacter.ReisenSecondを参照してください。</para>
		/// </summary>
		public static readonly Character Reisen = new Character (
			IDs.Reisen,
			Strings.Reisen,
			new LocaleJa ("鈴仙", "鈴仙・優曇華院・イナバ", "れいせん", "れいせん・うどんげいん・いなば"),
			new Locale ("Reisen", "Reisen Udongein Inaba"),
			new Locale ("铃仙", "铃仙·优昙华院·因幡")
		);
		/// <summary>
		/// <para>Reisen</para>
		/// <para>レイセン</para>
		/// <para>This character is Reisen from Bougetsushou. For Reisen Udongein Inaba in Imperishable Night, please refer to Character.Reisen.</para>
		/// <para>このキャラクターは東方儚月抄のレイセンです。東方永夜抄の鈴仙・優曇華院・イナバはCharacter.Reisenを参照してください。</para>
		/// </summary>
		public static readonly Character ReisenSecond = new Character (
			IDs.ReisenSecond,
			Strings.ReisenSecond,
			new LocaleJa ("レイセン", "レイセン", "れいせん", "れいせん"),
			new Locale ("Reisen", "Reisen"),
			new Locale ("泠仙", "泠仙")
		);
		/// <summary>
		/// <para>Remilia Scarlet</para>
		/// <para>レミリア・スカーレット</para>
		/// </summary>
		public static readonly Character Remilia = new Character (
			IDs.Remilia,
			Strings.Remilia,
			new LocaleJa ("レミリア", "レミリア・スカーレット", "れみりあ", "れみりあ・すかーれっと"),
			new Locale ("Remilia", "Remilia Scarlet"),
			new Locale ("蕾米莉亚", "蕾米莉亚·斯卡蕾特")
		);
		/// <summary>
		/// <para>Renko Usami</para>
		/// <para>宇佐見 蓮子</para>
		/// </summary>
		public static readonly Character Renko = new Character (
			IDs.Renko,
			Strings.Renko,
			new LocaleJa ("蓮子", "宇佐見 蓮子", "れんこ", "うさみ れんこ"),
			new Locale ("Renko", "Renko Usami"),
			new Locale ("莲子", "宇佐见 莲子")
		);
		/// <summary>
		/// <para>Rika</para>
		/// <para>里香</para>
		/// </summary>
		public static readonly Character Rika = new Character (
			IDs.Rika,
			Strings.Rika,
			new LocaleJa ("里香", "里香", "りか", "りか"),
			new Locale ("Rika", "Rika"),
			new Locale ("里香", "里香")
		);
		/// <summary>
		/// <para>Rikako Asakura</para>
		/// <para>朝倉 理香子</para>
		/// </summary>
		public static readonly Character Rikako = new Character (
			IDs.Rikako,
			Strings.Rikako,
			new LocaleJa ("理香子", "朝倉 理香子", "りかこ", "あさくら りかこ"),
			new Locale ("Rikako", "Rikako Asakura"),
			new Locale ("理香子", "朝仓 理香子")
		);
		/// <summary>
		/// <para>Rin Kaenbyou</para>
		/// <para>火焔猫 燐</para>
		/// </summary>
		public static readonly Character Rin = new Character (
			IDs.Rin,
			Strings.Rin,
			new LocaleJa ("燐", "火焔猫 燐", "りん", "かえんびょう りん"),
			new Locale ("Rin", "Rin Kaenbyou"),
			new Locale ("燐", "火焰猫 燐")
		);
		/// <summary>
		/// <para>Ringo</para>
		/// <para>鈴瑚</para>
		/// </summary>
		public static readonly Character Ringo = new Character (
			IDs.Ringo,
			Strings.Ringo,
			new LocaleJa ("鈴瑚", "鈴瑚", "りんご", "りんご"),
			new Locale ("Ringo", "Ringo"),
			new Locale ("铃瑚", "铃瑚")
		);
		/// <summary>
		/// <para>Rinnosuke Morichika</para>
		/// <para>森近 霖之助</para>
		/// </summary>
		public static readonly Character Rinnosuke = new Character (
			IDs.Rinnosuke,
			Strings.Rinnosuke,
			new LocaleJa ("霖之助", "森近 霖之助", "りんのすけ", "もりちか りんのすけ"),
			new Locale ("Rinnosuke", "Rinnosuke Morichika"),
			new Locale ("霖之助", "森近 霖之助")
		);
		/// <summary>
		/// <para>Rumia</para>
		/// <para>ルーミア</para>
		/// </summary>
		public static readonly Character Rumia = new Character (
			IDs.Rumia,
			Strings.Rumia,
			new LocaleJa ("ルーミア", "ルーミア", "るーみあ", "るーみあ"),
			new Locale ("Rumia", "Rumia"),
			new Locale ("露米娅", "露米娅")
		);
		/// <summary>
		/// <para>Ruukoto</para>
		/// <para>る～こと</para>
		/// </summary>
		public static readonly Character Ruukoto = new Character (
			IDs.Ruukoto,
			Strings.Ruukoto,
			new LocaleJa ("る～こと", "る～こと", "る～こと", "る～こと"),
			new Locale ("Ruukoto", "Ruukoto"),
			new Locale ("留琴", "留琴")
		);
		/// <summary>
		/// <para>Sagume Kishin</para>
		/// <para>稀神 サグメ</para>
		/// </summary>
		public static readonly Character Sagume = new Character (
			IDs.Sagume,
			Strings.Sagume,
			new LocaleJa ("サグメ", "稀神 サグメ", "さぐめ", "きしん さぐめ"),
			new Locale ("Sagume", "Sagume Kishin"),
			new Locale ("探女", "稀神 探女")
		);
		/// <summary>
		/// <para>Saki Kurokoma</para>
		/// <para>驪駒 早鬼</para>
		/// </summary>
		public static readonly Character Saki = new Character (
			IDs.Saki,
			Strings.Saki,
			new LocaleJa ("早鬼", "驪駒 早鬼", "さき", "くろこま さき"),
			new Locale ("Saki", "Saki Kurokoma"),
			new Locale ("早鬼", "骊驹 早鬼")
		);
		/// <summary>
		/// <para>Sakuya Izayoi</para>
		/// <para>十六夜 咲夜</para>
		/// </summary>
		public static readonly Character Sakuya = new Character (
			IDs.Sakuya,
			Strings.Sakuya,
			new LocaleJa ("咲夜", "十六夜 咲夜", "さくや", "いざよい さくや"),
			new Locale ("Sakuya", "Sakuya Izayoi"),
			new Locale ("咲夜", "十六夜 咲夜")
		);
		/// <summary>
		/// <para>Sanae Kochiya</para>
		/// <para>東風谷 早苗</para>
		/// <para>The English name before Ten Desires is Kotiya, but this package uses the English name after Ten Desires, Kochiya.</para>
		/// <para>神霊廟以前の英名はKotiyaですが、本パッケージでは神霊廟以降の英名であるKochiyaを採用しています。</para>
		/// </summary>
		public static readonly Character Sanae = new Character (
			IDs.Sanae,
			Strings.Sanae,
			new LocaleJa ("早苗", "東風谷 早苗", "さなえ", "こちや さなえ"),
			new Locale ("Sanae", "Sanae Kochiya"),
			new Locale ("早苗", "东风谷 早苗")
		);
		/// <summary>
		/// <para>Sannyo Komakusa</para>
		/// <para>駒草 山如</para>
		/// </summary>
		public static readonly Character Sannyo = new Character (
			IDs.Sannyo,
			Strings.Sannyo,
			new LocaleJa ("山如", "駒草 山如", "さんにょ", "こまくさ さんにょ"),
			new Locale ("Sannyo", "Sannyo Komakusa"),
			new Locale ("山如", "驹草 山如")
		);
		/// <summary>
		/// <para>Sara</para>
		/// <para>サラ</para>
		/// </summary>
		public static readonly Character Sara = new Character (
			IDs.Sara,
			Strings.Sara,
			new LocaleJa ("サラ", "サラ", "さら", "さら"),
			new Locale ("Sara", "Sara"),
			new Locale ("萨拉", "萨拉")
		);
		/// <summary>
		/// <para>Sariel</para>
		/// <para>サリエル</para>
		/// </summary>
		public static readonly Character Sariel = new Character (
			IDs.Sariel,
			Strings.Sariel,
			new LocaleJa ("サリエル", "サリエル", "さりえる", "さりえる"),
			new Locale ("Sariel", "Sariel"),
			new Locale ("萨丽爱尔", "萨丽爱尔")
		);
		/// <summary>
		/// <para>Satono Nishida</para>
		/// <para>爾子田 里乃</para>
		/// </summary>
		public static readonly Character Satono = new Character (
			IDs.Satono,
			Strings.Satono,
			new LocaleJa ("里乃", "爾子田 里乃", "さとの", "にしだ さとの"),
			new Locale ("Satono", "Satono Nishida"),
			new Locale ("里乃", "尔子田 里乃")
		);
		/// <summary>
		/// <para>Satori Komeiji</para>
		/// <para>古明地 さとり</para>
		/// </summary>
		public static readonly Character Satori = new Character (
			IDs.Satori,
			Strings.Satori,
			new LocaleJa ("さとり", "古明地 さとり", "さとり", "こめいじ さとり"),
			new Locale ("Satori", "Satori Komeiji"),
			new Locale ("觉", "古明地 觉")
		);
		/// <summary>
		/// <para>Seiga Kaku</para>
		/// <para>霍 青娥</para>
		/// </summary>
		public static readonly Character Seiga = new Character (
			IDs.Seiga,
			Strings.Seiga,
			new LocaleJa ("青娥", "霍 青娥", "せいが", "かく せいが"),
			new Locale ("Seiga", "Seiga Kaku"),
			new Locale ("青娥", "霍 青娥")
		);
		/// <summary>
		/// <para>Seija Kijin</para>
		/// <para>鬼人 正邪</para>
		/// </summary>
		public static readonly Character Seija = new Character (
			IDs.Seija,
			Strings.Seija,
			new LocaleJa ("正邪", "鬼人 正邪", "せいじゃ", "きじん せいじゃ"),
			new Locale ("Seija", "Seija Kijin"),
			new Locale ("正邪", "鬼人 正邪")
		);
		/// <summary>
		/// <para>Seiran</para>
		/// <para>清蘭</para>
		/// </summary>
		public static readonly Character Seiran = new Character (
			IDs.Seiran,
			Strings.Seiran,
			new LocaleJa ("清蘭", "清蘭", "せいらん", "せいらん"),
			new Locale ("Seiran", "Seiran"),
			new Locale ("清兰", "清兰")
		);
		/// <summary>
		/// <para>Sekibanki</para>
		/// <para>赤蛮奇</para>
		/// </summary>
		public static readonly Character Sekibanki = new Character (
			IDs.Sekibanki,
			Strings.Sekibanki,
			new LocaleJa ("赤蛮奇", "赤蛮奇", "せきばんき", "せきばんき"),
			new Locale ("Sekibanki", "Sekibanki"),
			new Locale ("赤蛮奇", "赤蛮奇")
		);
		/// <summary>
		/// <para>Shinki</para>
		/// <para>神綺</para>
		/// </summary>
		public static readonly Character Shinki = new Character (
			IDs.Shinki,
			Strings.Shinki,
			new LocaleJa ("神綺", "神綺", "しんき", "しんき"),
			new Locale ("Shinki", "Shinki"),
			new Locale ("神绮", "神绮")
		);
		/// <summary>
		/// <para>Shinmyoumaru Sukuna</para>
		/// <para>少名 針妙丸</para>
		/// </summary>
		public static readonly Character Shinmyoumaru = new Character (
			IDs.Shinmyoumaru,
			Strings.Shinmyoumaru,
			new LocaleJa ("針妙丸", "少名 針妙丸", "しんみょうまる", "すくな しんみょうまる"),
			new Locale ("Shinmyoumaru", "Shinmyoumaru Sukuna"),
			new Locale ("针妙丸", "少名 针妙丸")
		);
		/// <summary>
		/// <para>Shion Yorigami</para>
		/// <para>依神 紫苑</para>
		/// </summary>
		public static readonly Character Shion = new Character (
			IDs.Shion,
			Strings.Shion,
			new LocaleJa ("紫苑", "依神 紫苑", "しおん", "よりがみ しおん"),
			new Locale ("Shion", "Shion Yorigami"),
			new Locale ("紫苑", "依神 紫苑")
		);
		/// <summary>
		/// <para>Shizuha Aki</para>
		/// <para>秋 静葉</para>
		/// </summary>
		public static readonly Character Shizuha = new Character (
			IDs.Shizuha,
			Strings.Shizuha,
			new LocaleJa ("静葉", "秋 静葉", "しずは", "あき しずは"),
			new Locale ("Shizuha", "Shizuha Aki"),
			new Locale ("静叶", "秋 静叶")
		);
		/// <summary>
		/// <para>SinGyoku</para>
		/// <para>シンギョク</para>
		/// </summary>
		public static readonly Character Singyoku = new Character (
			IDs.Singyoku,
			Strings.Singyoku,
			new LocaleJa ("シンギョク", "シンギョク", "しんぎょく", "しんぎょく"),
			new Locale ("SinGyoku", "SinGyoku"),
			new Locale ("神玉", "神玉")
		);
		/// <summary>
		/// <para>Starsapphire</para>
		/// <para>スターサファイア</para>
		/// <para>The English name is written as Starsaphire in Perfect Memento in Strict Sense, but we believe that saphire is clearly a typo, so we have used Starsapphire on this package.</para>
		/// <para>英名は東方求聞史紀ではStarsaphire表記ですが、saphireは明らかに誤字だと考えていますので本パッケージではStarsapphireを採用しています。</para>
		/// </summary>
		public static readonly Character Starsapphire = new Character (
			IDs.Starsapphire,
			Strings.Starsapphire,
			new LocaleJa ("スターサファイア", "スターサファイア", "すたーさふぁいあ", "すたーさふぁいあ"),
			new Locale ("Starsapphire", "Starsapphire"),
			new Locale ("斯塔萨菲雅", "斯塔萨菲雅")
		);
		/// <summary>
		/// <para>Suika Ibuki</para>
		/// <para>伊吹 萃香</para>
		/// </summary>
		public static readonly Character Suika = new Character (
			IDs.Suika,
			Strings.Suika,
			new LocaleJa ("萃香", "伊吹 萃香", "すいか", "いぶき すいか"),
			new Locale ("Suika", "Suika Ibuki"),
			new Locale ("萃香", "伊吹 萃香")
		);
		/// <summary>
		/// <para>Sumireko Usami</para>
		/// <para>宇佐見 菫子</para>
		/// </summary>
		public static readonly Character Sumireko = new Character (
			IDs.Sumireko,
			Strings.Sumireko,
			new LocaleJa ("菫子", "宇佐見 菫子", "すみれこ", "うさみ すみれこ"),
			new Locale ("Sumireko", "Sumireko Usami"),
			new Locale ("堇子", "宇佐见 堇子")
		);
		/// <summary>
		/// <para>Sunnymilk</para>
		/// <para>サニーミルク</para>
		/// </summary>
		public static readonly Character Sunnymilk = new Character (
			IDs.Sunnymilk,
			Strings.Sunnymilk,
			new LocaleJa ("サニーミルク", "サニーミルク", "さにーみるく", "さにーみるく"),
			new Locale ("Sunnymilk", "Sunnymilk"),
			new Locale ("桑尼米尔克", "桑尼米尔克")
		);
		/// <summary>
		/// <para>Suwako Moriya</para>
		/// <para>洩矢 諏訪子</para>
		/// </summary>
		public static readonly Character Suwako = new Character (
			IDs.Suwako,
			Strings.Suwako,
			new LocaleJa ("諏訪子", "洩矢 諏訪子", "すわこ", "もりや すわこ"),
			new Locale ("Suwako", "Suwako Moriya"),
			new Locale ("诹访子", "洩矢 诹访子")
		);
		/// <summary>
		/// <para>Syou Toramaru</para>
		/// <para>寅丸 星</para>
		/// </summary>
		public static readonly Character Syou = new Character (
			IDs.Syou,
			Strings.Syou,
			new LocaleJa ("星", "寅丸 星", "しょう", "とらまる しょう"),
			new Locale ("Syou", "Syou Toramaru"),
			new Locale ("星", "寅丸 星")
		);
		/// <summary>
		/// <para>Takane Yamashiro</para>
		/// <para>山城 たかね</para>
		/// </summary>
		public static readonly Character Takane = new Character (
			IDs.Takane,
			Strings.Takane,
			new LocaleJa ("たかね", "山城 たかね", "たかね", "やましろ たかね"),
			new Locale ("Takane", "Takane Yamashiro"),
			new Locale ("高岭", "山城 高岭")
		);
		/// <summary>
		/// <para>Mai Teireida</para>
		/// <para>丁礼田 舞</para>
		/// <para>This character is Mai Teireida from Hidden Star in Four Seasons. Please note that Character.Mai is Mai from Mystic Square.</para>
		/// <para>このキャラクターは東方天空璋の丁礼田 舞です。Character.Maiは東方怪綺談のマイなので注意してください。</para>
		/// </summary>
		public static readonly Character Teireida = new Character (
			IDs.Teireida,
			Strings.Teireida,
			new LocaleJa ("舞", "丁礼田 舞", "まい", "ていれいだ まい"),
			new Locale ("Mai", "Mai Teireida"),
			new Locale ("舞", "丁礼田 舞")
		);
		/// <summary>
		/// <para>Tenshi Hinanawi</para>
		/// <para>比那名居 天子</para>
		/// </summary>
		public static readonly Character Tenshi = new Character (
			IDs.Tenshi,
			Strings.Tenshi,
			new LocaleJa ("天子", "比那名居 天子", "てんし", "ひななゐ てんし"),
			new Locale ("Tenshi", "Tenshi Hinanawi"),
			new Locale ("天子", "比那名居 天子")
		);
		/// <summary>
		/// <para>Tewi Inaba</para>
		/// <para>因幡 てゐ</para>
		/// </summary>
		public static readonly Character Tewi = new Character (
			IDs.Tewi,
			Strings.Tewi,
			new LocaleJa ("てゐ", "因幡 てゐ", "てゐ", "いなば てゐ"),
			new Locale ("Tewi", "Tewi Inaba"),
			new Locale ("天为", "因幡 天为")
		);
		/// <summary>
		/// <para>Soga no Tojiko</para>
		/// <para>蘇我 屠自古</para>
		/// </summary>
		public static readonly Character Tojiko = new Character (
			IDs.Tojiko,
			Strings.Tojiko,
			new LocaleJa ("屠自古", "蘇我 屠自古", "とじこ", "そが の とじこ"),
			new Locale ("Tojiko", "Soga no Tojiko"),
			new Locale ("屠自古", "苏我 屠自古")
		);
		/// <summary>
		/// <para>Tokiko</para>
		/// <para>朱鷺子</para>
		/// <para>This character is Unnamed Book-Reading Youkai who appeared in Curiosities of Lotus Asia. Tokiko is not an official name.</para>
		/// <para>このキャラクターは東方香霖堂に登場した名無しの本読み妖怪です。朱鷺子は公式名称ではありません。</para>
		/// </summary>
		public static readonly Character Tokiko = new Character (
			IDs.Tokiko,
			Strings.Tokiko,
			new LocaleJa ("朱鷺子", "朱鷺子", "ときこ", "ときこ"),
			new Locale ("Tokiko", "Tokiko"),
			new Locale ("朱鹭子", "朱鹭子")
		);
		/// <summary>
		/// <para>Watatsuki no Toyohime</para>
		/// <para>綿月 豊姫</para>
		/// </summary>
		public static readonly Character Toyohime = new Character (
			IDs.Toyohime,
			Strings.Toyohime,
			new LocaleJa ("豊姫", "綿月 豊姫", "とよひめ", "わたつき の とよひめ"),
			new Locale ("Toyohime", "Watatsuki no Toyohime"),
			new Locale ("丰姬", "绵月 丰姬")
		);
		/// <summary>
		/// <para>Tsukasa Kudamaki</para>
		/// <para>菅牧 典</para>
		/// </summary>
		public static readonly Character Tsukasa = new Character (
			IDs.Tsukasa,
			Strings.Tsukasa,
			new LocaleJa ("典", "菅牧 典", "つかさ", "くだまき つかさ"),
			new Locale ("Tsukasa", "Tsukasa Kudamaki"),
			new Locale ("典", "菅牧 典")
		);
		/// <summary>
		/// <para>Ubame Chirizuka</para>
		/// <para>塵塚 ウバメ</para>
		/// </summary>
		public static readonly Character Ubame = new Character (
			IDs.Ubame,
			Strings.Ubame,
			new LocaleJa ("ウバメ", "塵塚 ウバメ", "うばめ", "ちりづか うばめ"),
			new Locale ("Ubame", "Ubame Chirizuka"),
			new Locale ("姥芽", "尘塚 姥芽")
		);
		/// <summary>
		/// <para>Urumi Ushizaki</para>
		/// <para>牛崎 潤美</para>
		/// </summary>
		public static readonly Character Urumi = new Character (
			IDs.Urumi,
			Strings.Urumi,
			new LocaleJa ("潤美", "牛崎 潤美", "うるみ", "うしざき うるみ"),
			new Locale ("Urumi", "Urumi Ushizaki"),
			new Locale ("润美", "牛崎 润美")
		);
		/// <summary>
		/// <para>Utsuho Reiuzi</para>
		/// <para>霊烏路 空</para>
		/// </summary>
		public static readonly Character Utsuho = new Character (
			IDs.Utsuho,
			Strings.Utsuho,
			new LocaleJa ("空", "霊烏路 空", "うつほ", "れいうじ うつほ"),
			new Locale ("Utsuho", "Utsuho Reiuzi"),
			new Locale ("空", "灵乌路 空")
		);
		/// <summary>
		/// <para>Wakasagihime</para>
		/// <para>わかさぎ姫</para>
		/// </summary>
		public static readonly Character Wakasagihime = new Character (
			IDs.Wakasagihime,
			Strings.Wakasagihime,
			new LocaleJa ("わかさぎ姫", "わかさぎ姫", "わかさぎひめ", "わかさぎひめ"),
			new Locale ("Wakasagihime", "Wakasagihime"),
			new Locale ("若鹭姬", "若鹭姬")
		);
		/// <summary>
		/// <para>Wriggle Nightbug</para>
		/// <para>リグル・ナイトバグ</para>
		/// </summary>
		public static readonly Character Wriggle = new Character (
			IDs.Wriggle,
			Strings.Wriggle,
			new LocaleJa ("リグル", "リグル・ナイトバグ", "りぐる", "りぐる・ないとばぐ"),
			new Locale ("Wriggle", "Wriggle Nightbug"),
			new Locale ("莉格露", "莉格露·奈特巴格")
		);
		/// <summary>
		/// <para>Yachie Kicchou</para>
		/// <para>吉弔 八千慧</para>
		/// <para>In the original work, it is written as Kitcho, but a c is added to pronounce the Japanese "っ" and a u is added to pronounce the "う" sound.</para>
		/// <para>英名は原作ではKitcho表記ですが、日本語の「っ」を発音させるためにcを、「う」を発音させるためにuを追加しています。</para>
		/// </summary>
		public static readonly Character Yachie = new Character (
			IDs.Yachie,
			Strings.Yachie,
			new LocaleJa ("八千慧", "吉弔 八千慧", "やちえ", "きっちょう やちえ"),
			new Locale ("Yachie", "Yachie Kicchou"),
			new Locale ("八千慧", "吉吊 八千慧")
		);
		/// <summary>
		/// <para>Yamame Kurodani</para>
		/// <para>黒谷 ヤマメ</para>
		/// </summary>
		public static readonly Character Yamame = new Character (
			IDs.Yamame,
			Strings.Yamame,
			new LocaleJa ("ヤマメ", "黒谷 ヤマメ", "やまめ", "くろだに やまめ"),
			new Locale ("Yamame", "Yamame Kurodani"),
			new Locale ("山女", "黑谷 山女")
		);
		/// <summary>
		/// <para>Yatsuhashi Tsukumo</para>
		/// <para>九十九 八橋</para>
		/// </summary>
		public static readonly Character Yatsuhashi = new Character (
			IDs.Yatsuhashi,
			Strings.Yatsuhashi,
			new LocaleJa ("八橋", "九十九 八橋", "やつはし", "つくも やつはし"),
			new Locale ("Yatsuhashi", "Yatsuhashi Tsukumo"),
			new Locale ("八桥", "九十九 八桥")
		);
		/// <summary>
		/// <para>Watatsuki no Yorihime</para>
		/// <para>綿月 依姫</para>
		/// </summary>
		public static readonly Character Yorihime = new Character (
			IDs.Yorihime,
			Strings.Yorihime,
			new LocaleJa ("依姫", "綿月 依姫", "よりひめ", "わたつき の よりひめ"),
			new Locale ("Yorihime", "Watatsuki no Yorihime"),
			new Locale ("依姬", "绵月 依姬")
		);
		/// <summary>
		/// <para>Yoshika Miyako</para>
		/// <para>宮古 芳香</para>
		/// </summary>
		public static readonly Character Yoshika = new Character (
			IDs.Yoshika,
			Strings.Yoshika,
			new LocaleJa ("芳香", "宮古 芳香", "よしか", "みやこ よしか"),
			new Locale ("Yoshika", "Yoshika Miyako"),
			new Locale ("芳香", "宫古 芳香")
		);
		/// <summary>
		/// <para>Youmu Konpaku</para>
		/// <para>魂魄 妖夢</para>
		/// </summary>
		public static readonly Character Youmu = new Character (
			IDs.Youmu,
			Strings.Youmu,
			new LocaleJa ("妖夢", "魂魄 妖夢", "ようむ", "こんぱく ようむ"),
			new Locale ("Youmu", "Youmu Konpaku"),
			new Locale ("妖梦", "魂魄 妖梦")
		);
		/// <summary>
		/// <para>Yuiman Asama</para>
		/// <para>ユイマン・浅間</para>
		/// </summary>
		public static readonly Character Yuiman = new Character (
			IDs.Yuiman,
			Strings.Yuiman,
			new LocaleJa ("ユイマン", "ユイマン・浅間", "ゆいまん", "ゆいまん・あさま"),
			new Locale ("Yuiman", "Yuiman Asama"),
			new Locale ("维缦", "维缦·浅间")
		);
		/// <summary>
		/// <para>Yukari Yakumo</para>
		/// <para>八雲 紫</para>
		/// </summary>
		public static readonly Character Yukari = new Character (
			IDs.Yukari,
			Strings.Yukari,
			new LocaleJa ("紫", "八雲 紫", "ゆかり", "やくも ゆかり"),
			new Locale ("Yukari", "Yukari Yakumo"),
			new Locale ("紫", "八云 紫")
		);
		/// <summary>
		/// <para>Yuki</para>
		/// <para>ユキ</para>
		/// </summary>
		public static readonly Character Yuki = new Character (
			IDs.Yuki,
			Strings.Yuki,
			new LocaleJa ("ユキ", "ユキ", "ゆき", "ゆき"),
			new Locale ("Yuki", "Yuki"),
			new Locale ("雪", "雪")
		);
		/// <summary>
		/// <para>Yumeko</para>
		/// <para>夢子</para>
		/// </summary>
		public static readonly Character Yumeko = new Character (
			IDs.Yumeko,
			Strings.Yumeko,
			new LocaleJa ("夢子", "夢子", "ゆめこ", "ゆめこ"),
			new Locale ("Yumeko", "Yumeko"),
			new Locale ("梦子", "梦子")
		);
		/// <summary>
		/// <para>Yumemi Okazaki</para>
		/// <para>岡崎 夢美</para>
		/// </summary>
		public static readonly Character Yumemi = new Character (
			IDs.Yumemi,
			Strings.Yumemi,
			new LocaleJa ("夢美", "岡崎 夢美", "ゆめみ", "おかざき ゆめみ"),
			new Locale ("Yumemi", "Yumemi Okazaki"),
			new Locale ("梦美", "冈崎 梦美")
		);
		/// <summary>
		/// <para>YuugenMagan</para>
		/// <para>ユウゲンマガン</para>
		/// </summary>
		public static readonly Character Yuugenmagan = new Character (
			IDs.Yuugenmagan,
			Strings.Yuugenmagan,
			new LocaleJa ("ユウゲンマガン", "ユウゲンマガン", "ゆうげんまがん", "ゆうげんまがん"),
			new Locale ("YuugenMagan", "YuugenMagan"),
			new Locale ("幽幻魔眼", "幽幻魔眼")
		);
		/// <summary>
		/// <para>Yuugi Hoshiguma</para>
		/// <para>星熊 勇儀</para>
		/// <para>In the original work, her English name is written as Yugi, but with the "u" added to pronounce it like the Japanese "う".</para>
		/// <para>英名は原作ではYugi表記ですが、日本語の「う」を発音させるためにuを追加しています。</para>
		/// </summary>
		public static readonly Character Yuugi = new Character (
			IDs.Yuugi,
			Strings.Yuugi,
			new LocaleJa ("勇儀", "星熊 勇儀", "ゆうぎ", "ほしぐま ゆうぎ"),
			new Locale ("Yuugi", "Yuugi Hoshiguma"),
			new Locale ("勇仪", "星熊 勇仪")
		);
		/// <summary>
		/// <para>Kazami Yuuka</para>
		/// <para>風見 幽香</para>
		/// <para>Her English name is written as Yuka in Perfect Memento in Strict Sense, but with the "u" added to pronounce it like the Japanese "う".</para>
		/// <para>英名は東方求聞史紀ではYuka表記ですが、日本語の「う」を発音させるためにuを追加しています。</para>
		/// </summary>
		public static readonly Character Yuuka = new Character (
			IDs.Yuuka,
			Strings.Yuuka,
			new LocaleJa ("幽香", "風見 幽香", "ゆうか", "かざみ ゆうか"),
			new Locale ("Yuuka", "Kazami Yuuka"),
			new Locale ("幽香", "风见 幽香")
		);
		/// <summary>
		/// <para>Yuuma Toutetsu</para>
		/// <para>饕餮 尤魔</para>
		/// <para>Her English name is written as Yuma Totetsu in Sunken Fossil World, but with the "u" added to pronounce it like the Japanese "う".</para>
		/// <para>英名は東方求聞史紀ではYuka表記ですが、日本語の「う」を発音させるためにuを追加しています。</para>
		/// </summary>
		public static readonly Character Yuuma = new Character (
			IDs.Yuuma,
			Strings.Yuuma,
			new LocaleJa ("尤魔", "饕餮 尤魔", "ゆうま", "とうてつ ゆうま"),
			new Locale ("Yuuma", "Yuuma Toutetsu"),
			new Locale ("尤魔", "饕餮 尤魔")
		);
		/// <summary>
		/// <para>Yuyuko Saigyouji</para>
		/// <para>西行寺 幽々子</para>
		/// </summary>
		public static readonly Character Yuyuko = new Character (
			IDs.Yuyuko,
			Strings.Yuyuko,
			new LocaleJa ("幽々子", "西行寺 幽々子", "ゆゆこ", "さいぎょうじ ゆゆこ"),
			new Locale ("Yuyuko", "Yuyuko Saigyouji"),
			new Locale ("幽幽子", "西行寺 幽幽子")
		);
		/// <summary>
		/// <para>Zanmu Nippaku</para>
		/// <para>日白 残無</para>
		/// </summary>
		public static readonly Character Zanmu = new Character (
			IDs.Zanmu,
			Strings.Zanmu,
			new LocaleJa ("残無", "日白 残無", "ざんむ", "にっぱく ざんむ"),
			new Locale ("Zanmu", "Zanmu Nippaku"),
			new Locale ("残无", "日白 残无")
		);

		static Character ()
		{
			// Initializes the language
			// 言語を初期化します
			ChangeLanguage (Application.systemLanguage);
		}

		protected Character (int id, string str, LocaleJa ja, Locale en, Locale zh)
		{
			ID = id;
			String = str;

			Locales = new CharacterLocales (ja, en, zh);
		}

		private Locale GetLocaleFromSelectedLanguage () => SelectedLanguage switch
		{
			SystemLanguage.Japanese => Locales.Ja,
			SystemLanguage.Chinese or SystemLanguage.ChineseSimplified or SystemLanguage.ChineseTraditional => Locales.Zh,
			_ => Locales.En
		};

		/// <summary>
		/// <para>Returns the Character with the specified ID, or null if the Character does not exist.</para>
		/// <para>引数のIDを持つCharacterを返します。該当のCharacterが存在しない場合はnullを返します。</para>
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public static Character Get (int id) => id switch
		{
			IDs.Akyuu => Akyuu,
			IDs.Alice => Alice,
			IDs.Ariya => Ariya,
			IDs.Aunn => Aunn,
			IDs.Aya => Aya,
			IDs.Benben => Benben,
			IDs.Biten => Biten,
			IDs.Byakuren => Byakuren,
			IDs.Chen => Chen,
			IDs.Chimata => Chimata,
			IDs.Chimi => Chimi,
			IDs.Chiyari => Chiyari,
			IDs.Chiyuri => Chiyuri,
			IDs.Cirno => Cirno,
			IDs.Clownpiece => Clownpiece,
			IDs.Daiyousei => Daiyousei,
			IDs.Doremy => Doremy,
			IDs.Eika => Eika,
			IDs.Eiki => Eiki,
			IDs.Eirin => Eirin,
			IDs.Ekisya => Ekisya,
			IDs.Elis => Elis,
			IDs.Ellen => Ellen,
			IDs.Elly => Elly,
			IDs.Enoko => Enoko,
			IDs.Eternitylarva => Eternitylarva,
			IDs.Flandre => Flandre,
			IDs.Futo => Futo,
			IDs.Gengetu => Gengetu,
			IDs.Genjii => Genjii,
			IDs.Hatate => Hatate,
			IDs.Hecatia => Hecatia,
			IDs.Hina => Hina,
			IDs.Hisami => Hisami,
			IDs.Ichirin => Ichirin,
			IDs.Iku => Iku,
			IDs.Junko => Junko,
			IDs.Jyoon => Jyoon,
			IDs.Kagerou => Kagerou,
			IDs.Kaguya => Kaguya,
			IDs.Kana => Kana,
			IDs.Kanako => Kanako,
			IDs.Kasen => Kasen,
			IDs.Keiki => Keiki,
			IDs.Keine => Keine,
			IDs.Kikuri => Kikuri,
			IDs.Kisume => Kisume,
			IDs.Koakuma => Koakuma,
			IDs.Kogasa => Kogasa,
			IDs.Koishi => Koishi,
			IDs.Kokoro => Kokoro,
			IDs.Komachi => Komachi,
			IDs.Konngara => Konngara,
			IDs.Kosuzu => Kosuzu,
			IDs.Kotohime => Kotohime,
			IDs.Kurumi => Kurumi,
			IDs.Kutaka => Kutaka,
			IDs.Kyouko => Kyouko,
			IDs.Letty => Letty,
			IDs.Lilywhite => Lilywhite,
			IDs.Luize => Luize,
			IDs.Lunarchild => Lunarchild,
			IDs.Lunasa => Lunasa,
			IDs.Lyrica => Lyrica,
			IDs.Mai => Mai,
			IDs.Mamizou => Mamizou,
			IDs.Maribel => Maribel,
			IDs.Marisa => Marisa,
			IDs.Mayumi => Mayumi,
			IDs.Medicine => Medicine,
			IDs.Megumu => Megumu,
			IDs.Meira => Meira,
			IDs.Meirin => Meirin,
			IDs.Merlin => Merlin,
			IDs.Mike => Mike,
			IDs.Miko => Miko,
			IDs.Mima => Mima,
			IDs.Minamitsu => Minamitsu,
			IDs.Minoriko => Minoriko,
			IDs.Misumaru => Misumaru,
			IDs.Miyoi => Miyoi,
			IDs.Mizuchi => Mizuchi,
			IDs.Mokou => Mokou,
			IDs.Momizi => Momizi,
			IDs.Momoyo => Momoyo,
			IDs.Mugetu => Mugetu,
			IDs.Mystia => Mystia,
			IDs.Nareko => Nareko,
			IDs.Narumi => Narumi,
			IDs.Nazrin => Nazrin,
			IDs.Nemuno => Nemuno,
			IDs.Nina => Nina,
			IDs.Nitori => Nitori,
			IDs.Nue => Nue,
			IDs.Okina => Okina,
			IDs.Orange => Orange,
			IDs.Parsee => Parsee,
			IDs.Patchouli => Patchouli,
			IDs.Raiko => Raiko,
			IDs.Ran => Ran,
			IDs.Reimu => Reimu,
			IDs.Reisen => Reisen,
			IDs.ReisenSecond => ReisenSecond,
			IDs.Remilia => Remilia,
			IDs.Renko => Renko,
			IDs.Rika => Rika,
			IDs.Rikako => Rikako,
			IDs.Rin => Rin,
			IDs.Ringo => Ringo,
			IDs.Rinnosuke => Rinnosuke,
			IDs.Rumia => Rumia,
			IDs.Ruukoto => Ruukoto,
			IDs.Sagume => Sagume,
			IDs.Saki => Saki,
			IDs.Sakuya => Sakuya,
			IDs.Sanae => Sanae,
			IDs.Sannyo => Sannyo,
			IDs.Sara => Sara,
			IDs.Sariel => Sariel,
			IDs.Satono => Satono,
			IDs.Satori => Satori,
			IDs.Seiga => Seiga,
			IDs.Seija => Seija,
			IDs.Seiran => Seiran,
			IDs.Sekibanki => Sekibanki,
			IDs.Shinki => Shinki,
			IDs.Shinmyoumaru => Shinmyoumaru,
			IDs.Shion => Shion,
			IDs.Shizuha => Shizuha,
			IDs.Singyoku => Singyoku,
			IDs.Starsapphire => Starsapphire,
			IDs.Suika => Suika,
			IDs.Sumireko => Sumireko,
			IDs.Sunnymilk => Sunnymilk,
			IDs.Suwako => Suwako,
			IDs.Syou => Syou,
			IDs.Takane => Takane,
			IDs.Teireida => Teireida,
			IDs.Tenshi => Tenshi,
			IDs.Tewi => Tewi,
			IDs.Tojiko => Tojiko,
			IDs.Tokiko => Tokiko,
			IDs.Toyohime => Toyohime,
			IDs.Tsukasa => Tsukasa,
			IDs.Ubame => Ubame,
			IDs.Urumi => Urumi,
			IDs.Utsuho => Utsuho,
			IDs.Wakasagihime => Wakasagihime,
			IDs.Wriggle => Wriggle,
			IDs.Yachie => Yachie,
			IDs.Yamame => Yamame,
			IDs.Yatsuhashi => Yatsuhashi,
			IDs.Yorihime => Yorihime,
			IDs.Yoshika => Yoshika,
			IDs.Youmu => Youmu,
			IDs.Yuiman => Yuiman,
			IDs.Yukari => Yukari,
			IDs.Yuki => Yuki,
			IDs.Yumeko => Yumeko,
			IDs.Yumemi => Yumemi,
			IDs.Yuugenmagan => Yuugenmagan,
			IDs.Yuugi => Yuugi,
			IDs.Yuuka => Yuuka,
			IDs.Yuuma => Yuuma,
			IDs.Yuyuko => Yuyuko,
			IDs.Zanmu => Zanmu,
			_ => null
		};

		/// <summary>
		/// <para>Returns the Character that has the argument String, or null if the corresponding Character does not exist.</para>
		/// <para>引数のStringを持つCharacterを返します。該当のCharacterが存在しない場合はnullを返します。</para>
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static Character Get (string str) => str switch
		{
			Strings.Akyuu => Akyuu,
			Strings.Alice => Alice,
			Strings.Ariya => Ariya,
			Strings.Aunn => Aunn,
			Strings.Aya => Aya,
			Strings.Benben => Benben,
			Strings.Biten => Biten,
			Strings.Byakuren => Byakuren,
			Strings.Chen => Chen,
			Strings.Chimata => Chimata,
			Strings.Chimi => Chimi,
			Strings.Chiyari => Chiyari,
			Strings.Chiyuri => Chiyuri,
			Strings.Cirno => Cirno,
			Strings.Clownpiece => Clownpiece,
			Strings.Daiyousei => Daiyousei,
			Strings.Doremy => Doremy,
			Strings.Eika => Eika,
			Strings.Eiki => Eiki,
			Strings.Eirin => Eirin,
			Strings.Ekisya => Ekisya,
			Strings.Elis => Elis,
			Strings.Ellen => Ellen,
			Strings.Elly => Elly,
			Strings.Enoko => Enoko,
			Strings.Eternitylarva => Eternitylarva,
			Strings.Flandre => Flandre,
			Strings.Futo => Futo,
			Strings.Gengetu => Gengetu,
			Strings.Genjii => Genjii,
			Strings.Hatate => Hatate,
			Strings.Hecatia => Hecatia,
			Strings.Hina => Hina,
			Strings.Hisami => Hisami,
			Strings.Ichirin => Ichirin,
			Strings.Iku => Iku,
			Strings.Junko => Junko,
			Strings.Jyoon => Jyoon,
			Strings.Kagerou => Kagerou,
			Strings.Kaguya => Kaguya,
			Strings.Kana => Kana,
			Strings.Kanako => Kanako,
			Strings.Kasen => Kasen,
			Strings.Keiki => Keiki,
			Strings.Keine => Keine,
			Strings.Kikuri => Kikuri,
			Strings.Kisume => Kisume,
			Strings.Koakuma => Koakuma,
			Strings.Kogasa => Kogasa,
			Strings.Koishi => Koishi,
			Strings.Kokoro => Kokoro,
			Strings.Komachi => Komachi,
			Strings.Konngara => Konngara,
			Strings.Kosuzu => Kosuzu,
			Strings.Kotohime => Kotohime,
			Strings.Kurumi => Kurumi,
			Strings.Kutaka => Kutaka,
			Strings.Kyouko => Kyouko,
			Strings.Letty => Letty,
			Strings.Lilywhite => Lilywhite,
			Strings.Luize => Luize,
			Strings.Lunarchild => Lunarchild,
			Strings.Lunasa => Lunasa,
			Strings.Lyrica => Lyrica,
			Strings.Mai => Mai,
			Strings.Mamizou => Mamizou,
			Strings.Maribel => Maribel,
			Strings.Marisa => Marisa,
			Strings.Mayumi => Mayumi,
			Strings.Medicine => Medicine,
			Strings.Megumu => Megumu,
			Strings.Meira => Meira,
			Strings.Meirin => Meirin,
			Strings.Merlin => Merlin,
			Strings.Mike => Mike,
			Strings.Miko => Miko,
			Strings.Mima => Mima,
			Strings.Minamitsu => Minamitsu,
			Strings.Minoriko => Minoriko,
			Strings.Misumaru => Misumaru,
			Strings.Miyoi => Miyoi,
			Strings.Mizuchi => Mizuchi,
			Strings.Mokou => Mokou,
			Strings.Momizi => Momizi,
			Strings.Momoyo => Momoyo,
			Strings.Mugetu => Mugetu,
			Strings.Mystia => Mystia,
			Strings.Nareko => Nareko,
			Strings.Narumi => Narumi,
			Strings.Nazrin => Nazrin,
			Strings.Nemuno => Nemuno,
			Strings.Nina => Nina,
			Strings.Nitori => Nitori,
			Strings.Nue => Nue,
			Strings.Okina => Okina,
			Strings.Orange => Orange,
			Strings.Parsee => Parsee,
			Strings.Patchouli => Patchouli,
			Strings.Raiko => Raiko,
			Strings.Ran => Ran,
			Strings.Reimu => Reimu,
			Strings.Reisen => Reisen,
			Strings.ReisenSecond => ReisenSecond,
			Strings.Remilia => Remilia,
			Strings.Renko => Renko,
			Strings.Rika => Rika,
			Strings.Rikako => Rikako,
			Strings.Rin => Rin,
			Strings.Ringo => Ringo,
			Strings.Rinnosuke => Rinnosuke,
			Strings.Rumia => Rumia,
			Strings.Ruukoto => Ruukoto,
			Strings.Sagume => Sagume,
			Strings.Saki => Saki,
			Strings.Sakuya => Sakuya,
			Strings.Sanae => Sanae,
			Strings.Sannyo => Sannyo,
			Strings.Sara => Sara,
			Strings.Sariel => Sariel,
			Strings.Satono => Satono,
			Strings.Satori => Satori,
			Strings.Seiga => Seiga,
			Strings.Seija => Seija,
			Strings.Seiran => Seiran,
			Strings.Sekibanki => Sekibanki,
			Strings.Shinki => Shinki,
			Strings.Shinmyoumaru => Shinmyoumaru,
			Strings.Shion => Shion,
			Strings.Shizuha => Shizuha,
			Strings.Singyoku => Singyoku,
			Strings.Starsapphire => Starsapphire,
			Strings.Suika => Suika,
			Strings.Sumireko => Sumireko,
			Strings.Sunnymilk => Sunnymilk,
			Strings.Suwako => Suwako,
			Strings.Syou => Syou,
			Strings.Takane => Takane,
			Strings.Teireida => Teireida,
			Strings.Tenshi => Tenshi,
			Strings.Tewi => Tewi,
			Strings.Tojiko => Tojiko,
			Strings.Tokiko => Tokiko,
			Strings.Toyohime => Toyohime,
			Strings.Tsukasa => Tsukasa,
			Strings.Ubame => Ubame,
			Strings.Urumi => Urumi,
			Strings.Utsuho => Utsuho,
			Strings.Wakasagihime => Wakasagihime,
			Strings.Wriggle => Wriggle,
			Strings.Yachie => Yachie,
			Strings.Yamame => Yamame,
			Strings.Yatsuhashi => Yatsuhashi,
			Strings.Yorihime => Yorihime,
			Strings.Yoshika => Yoshika,
			Strings.Youmu => Youmu,
			Strings.Yuiman => Yuiman,
			Strings.Yukari => Yukari,
			Strings.Yuki => Yuki,
			Strings.Yumeko => Yumeko,
			Strings.Yumemi => Yumemi,
			Strings.Yuugenmagan => Yuugenmagan,
			Strings.Yuugi => Yuugi,
			Strings.Yuuka => Yuuka,
			Strings.Yuuma => Yuuma,
			Strings.Yuyuko => Yuyuko,
			Strings.Zanmu => Zanmu,
			_ => null
		};

		/// <summary>
		/// <para>Changes the language.</para>
		/// <para>言語を変更します。</para>
		/// <param name="systemLanguage">
		/// <para>SystemLanguage.English:English</para>
		/// <para>SystemLanguage.Japanese:日本語</para>
		/// <para>SystemLanguage.Chinese, SystemLanguage.ChineseSimplified, SystemLanguage.ChineseTraditional:中文</para>
		/// <para>others:English</para>
		/// </param>
		/// </summary>
		public static void ChangeLanguage (SystemLanguage systemLanguage)
		{
			switch (systemLanguage)
			{
			case SystemLanguage.Japanese:
				SelectedLanguage = SystemLanguage.Japanese;
				break;
			case SystemLanguage.Chinese:
			case SystemLanguage.ChineseSimplified:
			case SystemLanguage.ChineseTraditional:
				SelectedLanguage = SystemLanguage.Chinese;
				break;
			case SystemLanguage.English:
			default:
				SelectedLanguage = SystemLanguage.English;
				break;
			}
		}

		/// <summary>
		/// <para>Changes the language. The argument string is case insensitive.</para>
		/// <para>言語を変更します。引数の文字列は大文字と小文字を区別しません。</para>
		/// <param name="language">
		/// <para>en:English</para>
		/// <para>ja:日本語</para>
		/// <para>zh:中文</para>
		/// <para>others:English</para>
		/// </param>
		/// </summary>
		public static void ChangeLanguage (string language)
		{
			switch (language.ToLower ())
			{
			case "ja":
				SelectedLanguage = SystemLanguage.Japanese;
				break;
			case "zh":
				SelectedLanguage = SystemLanguage.Chinese;
				break;
			case "en":
			default:
				SelectedLanguage = SystemLanguage.English;
				break;
			}
		}

		/// <summary>
		/// <para>Returns a String.</para>
		/// <para>Stringを返します。</para>
		/// </summary>
		public override string ToString () => String;
		/// <summary>
		/// <para>Returns true if the argument Object is a Character or a class that derives from Character and its ID is equal to the comparison target.</para>
		/// <para>引数のObjectがCharacter、またはCharacterを派生したクラスでIDが比較対象と等しいならtrueを返します。</para>
		/// </summary>
		public override bool Equals (object obj) => obj is Character character && character.ID == ID;
		/// <summary>
		/// <para>Returns the ID.</para>
		/// <para>IDを返します。</para>
		/// </summary>
		public override int GetHashCode () => ID;
		public static bool operator == (Character a, Character b) => (a is not null && b is not null && a.ID == b.ID) || (a is null && b is null);
		public static bool operator != (Character a, Character b) => (a is not null && b is not null && a.ID != b.ID) || (a is not null != b is not null);
		public static bool operator > (Character a, Character b) => a is not null && b is not null && a.ID > b.ID;
		public static bool operator >= (Character a, Character b) => a is not null && b is not null && a.ID >= b.ID;
		public static bool operator < (Character a, Character b) => a is not null && b is not null && a.ID < b.ID;
		public static bool operator <= (Character a, Character b) => a is not null && b is not null && a.ID <= b.ID;
	}
}
