using UnityEngine;
using UnityEngine.UI;
using TouhouData;

namespace TouhouData.Sample
{
	public class TouhouDataPackageExtendedSample : MonoBehaviour
	{
		/// <summary>
		/// This is an example of extending the Character class.
		/// Characterクラスの拡張のサンプルです。
		/// </summary>
		public class CharacterExtended : Character
		{
			public class CharacterLocalesExtended : CharacterLocales
			{
				/// <summary>
				/// <para>French(same translation as in English)</para>
				/// <para>フランス語(英語と同じ訳)</para>
				/// <para>Français(même traduction qu'en anglais)</para>
				/// </summary>
				public readonly Locale Fr;

				public CharacterLocalesExtended (LocaleJa ja, Locale en, Locale zh) : base (ja, en, zh)
				{
					Fr = en;
				}
			}

			// Added constants to IDs and Strings to add five more characters.
			// キャラクターを5人追加するため、IDsとStringsに定数を追加。

			public class IDsExtended : IDs
			{
				public const int Hisoutensoku = Character.length;
				public const int Layla = Character.length + 1;
				public const int Myouren = Character.length + 2;
				public const int Satsukirin = Character.length + 3;
				public const int Youki = Character.length + 4;
			}

			public class StringsExtended : Strings
			{
				public const string Hisoutensoku = "Hisoutensoku";
				public const string Layla = "Layla";
				public const string Myouren = "Myouren";
				public const string Satsukirin = "Satsukirin";
				public const string Youki = "Youki";
			}

			// Increase the total number of characters by 5.
			// キャラクターの合計人数を5人増やす。
			public new const int length = Character.length + 5;

			// Redefine class members with new.
			// newを付けてクラスのメンバーを再定義。

			public new string Name => GetLocaleFromSelectedLanguage ().Name;
			public new string FullName => GetLocaleFromSelectedLanguage ().FullName;

			/// <summary>
			/// <para>This is a list of translations. French has been added.</para>
			/// <para>翻訳一覧です。フランス語が追加されています。</para>
			/// </summary>
			public new readonly CharacterLocalesExtended Locales;

			/// <summary>
			/// <para>The language used by this package. The value will be one of four things and the returned values ​​of Name and FullName change depending on the value of this variable.</para>
			/// <para>このパッケージで使用する言語です。値は以下の4つのどれかになり、この変数の値に応じてNameとFullNameの返り値が変化します。</para>
			/// <para>SystemLanguage.English(English)</para>
			/// <para>SystemLanguage.Japanese(日本語)</para>
			/// <para>SystemLanguage.Chinese(中文)</para>
			/// <para>SystemLanguage.French(Français)</para>
			/// </summary>
			public new static SystemLanguage SelectedLanguage
			{
				private set;
				get;
			}

			// Added Power variable.
			// Powerの変数を追加。
			public readonly int Power;

			// Set data for five characters.
			// 5人のキャラクターのデータを設定。

			/// <summary>
			/// <para>Hisoutensoku</para>
			/// <para>非想天則</para>
			/// </summary>
			public static readonly CharacterExtended Hisoutensoku = new CharacterExtended (
				IDsExtended.Hisoutensoku,
				StringsExtended.Hisoutensoku,
				500,
				new LocaleJa ("非想天則", "非想天則", "ひそうてんそく", "ひそうてんそく"),
				new Locale ("Hisoutensoku", "Hisoutensoku"),
				new Locale ("非想天则", "非想天则")
			);
			/// <summary>
			/// <para>Layla Prismriver</para>
			/// <para>レイラ・プリズムリバー</para>
			/// </summary>
			public static readonly CharacterExtended Layla = new CharacterExtended (
				IDsExtended.Layla,
				StringsExtended.Layla,
				100,
				new LocaleJa ("レイラ", "レイラ・プリズムリバー", "れいら", "れいら・ぷりずむりばー"),
				new Locale ("Layla", "Layla Prismriver"),
				new Locale ("蕾拉", "蕾拉·普莉兹姆利巴")
			);
			/// <summary>
			/// <para>Myouren</para>
			/// <para>命蓮</para>
			/// </summary>
			public static readonly CharacterExtended Myouren = new CharacterExtended (
				IDsExtended.Myouren,
				StringsExtended.Myouren,
				600,
				new LocaleJa ("命蓮", "命蓮", "みょうれん", "みょうれん"),
				new Locale ("Myouren", "Myouren"),
				new Locale ("命莲", "命莲")
			);
			/// <summary>
			/// <para>Satsukirin</para>
			/// <para>冴月麟</para>
			/// </summary>
			public static readonly CharacterExtended Satsukirin = new CharacterExtended (
				IDsExtended.Satsukirin,
				StringsExtended.Satsukirin,
				400,
				new LocaleJa ("冴月麟", "冴月麟", "さつきりん", "さつきりん"),
				new Locale ("Satsukirin", "Satsukirin"),
				new Locale ("冴月麟", "冴月麟")
			);
			/// <summary>
			/// <para>Youki Konpaku</para>
			/// <para>魂魄 妖忌</para>
			/// </summary>
			public static readonly CharacterExtended Youki = new CharacterExtended (
				IDsExtended.Youki,
				StringsExtended.Youki,
				1400,
				new LocaleJa ("妖忌", "魂魄 妖忌", "ようき", "こんぱくようき"),
				new Locale ("Youki", "Youki Konpaku"),
				new Locale ("妖忌", "魂魄 妖忌")
			);

			// Reconfigure the data of existing characters. In the sample, only two characters are reconfigured to simplify the code, but all characters should be reconfigured.
			// 元々存在するキャラクターのデータを再設定。サンプルではコードの簡略化のため2人しか再設定していませんが、本来は全員再設定すべきです。

			/// <summary>
			/// <para>Hong Meiling</para>
			/// <para>紅 美鈴</para>
			/// <para>This is the pinyin spelling, not the original spelling.</para>
			/// <para>原作の表記ではなく、ピンインの表記です。</para>
			/// </summary>
			public static new readonly CharacterExtended Meirin = new CharacterExtended (
				IDsExtended.Meirin,
				StringsExtended.Meirin,
				334,
				Character.Meirin.Locales.Ja,
				new Locale ("Meiling", "Hong Meiling"),
				Character.Meirin.Locales.Zh
			);
			/// <summary>
			/// <summary>
			/// <para>Reimu Hakurei</para>
			/// <para>博麗 霊夢</para>
			/// </summary>
			/// </summary>
			public static new readonly CharacterExtended Reimu = new CharacterExtended (
				IDsExtended.Reimu,
				StringsExtended.Reimu,
				8901,
				Character.Reimu.Locales.Ja,
				Character.Reimu.Locales.En,
				Character.Reimu.Locales.Zh
			);

			private CharacterExtended (int id, string str, int power, LocaleJa ja, Locale en, Locale zh)
				: base (id, str, ja, en, zh)
			{
				Locales = new CharacterLocalesExtended (ja, en, zh);
				Power = power;
			}

			private CharacterExtended (Character character)
				: this (character.ID, character.String, (character.ID + 1) * 2, character.Locales.Ja, character.Locales.En, character.Locales.Zh)
			{
			}

			private Locale GetLocaleFromSelectedLanguage () => SelectedLanguage switch
			{
				SystemLanguage.Japanese => Locales.Ja,
				SystemLanguage.Chinese or SystemLanguage.ChineseSimplified or SystemLanguage.ChineseTraditional => Locales.Zh,
				SystemLanguage.French => Locales.Fr,
				_ => Locales.En
			};

			public new static CharacterExtended Get (int id) => id switch
			{
				IDsExtended.Meirin => Meirin,
				IDsExtended.Reimu => Reimu,
				IDsExtended.Hisoutensoku => Hisoutensoku,
				IDsExtended.Layla => Layla,
				IDsExtended.Myouren => Myouren,
				IDsExtended.Satsukirin => Satsukirin,
				IDsExtended.Youki => Youki,
				_ => new CharacterExtended (Character.Get (id))
			};

			public new static CharacterExtended Get (string str) => str switch
			{
				StringsExtended.Meirin => Meirin,
				StringsExtended.Reimu => Reimu,
				StringsExtended.Hisoutensoku => Hisoutensoku,
				StringsExtended.Layla => Layla,
				StringsExtended.Myouren => Myouren,
				StringsExtended.Satsukirin => Satsukirin,
				StringsExtended.Youki => Youki,
				_ => new CharacterExtended (Character.Get (str))
			};

			/// <summary>
			/// <para>Changes the language.</para>
			/// <para>言語を変更します。</para>
			/// <param name="systemLanguage">
			/// <para>SystemLanguage.English:English</para>
			/// <para>SystemLanguage.Japanese:日本語</para>
			/// <para>SystemLanguage.Chinese, SystemLanguage.ChineseSimplified, SystemLanguage.ChineseTraditional:中文</para>
			/// <para>SystemLanguage.French:Français</para>
			/// <para>others:English</para>
			/// </param>
			/// </summary>
			public new static void ChangeLanguage (SystemLanguage systemLanguage)
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
				case SystemLanguage.French:
					SelectedLanguage = SystemLanguage.French;
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
			/// <para>fr:Français</para>
			/// <para>others:English</para>
			/// </param>
			/// </summary>
			public new static void ChangeLanguage (string language)
			{
				switch (language.ToLower ())
				{
				case "ja":
					SelectedLanguage = SystemLanguage.Japanese;
					break;
				case "zh":
					SelectedLanguage = SystemLanguage.Chinese;
					break;
				case "fr":
					SelectedLanguage = SystemLanguage.French;
					break;
				case "en":
				default:
					SelectedLanguage = SystemLanguage.English;
					break;
				}
			}
		}

		[SerializeField] private Text ReimuInfoText;
		[SerializeField] private Text RandomCharacterInfoText;
		[SerializeField] private Text IndexText;
		[SerializeField] private Text NameText;
		[SerializeField] private Text SubNameText;
		[SerializeField] private Text PronounText;
		[SerializeField] private Text PowerText;
		[SerializeField] private Text LevelText;
		[SerializeField] private Image CharacterImage;
		[SerializeField] private GameObject DummyCharacterSprite;

		private CharacterExtended CharacterNow;
		private int CharacterIndex = 0;
		private string Language = "";

		private const string PlayerPrefsKeyPrefix = "TouhouData_Sample_Extended_";

		private void Awake ()
		{
			CharacterIndex = PlayerPrefs.GetInt (PlayerPrefsKeyPrefix + "Index", 0);

			// Set the initial language setting.
			// 言語の初期設定をする。
			Language = PlayerPrefs.GetString (PlayerPrefsKeyPrefix + "Language", "");
			if (!string.IsNullOrEmpty (Language))
			{
				CharacterExtended.ChangeLanguage (Language);
			}

			Refresh ();
		}

		private void Refresh ()
		{
			// Assign Character of Reimu to a variable and display the information.
			// 霊夢のCharacterを変数に代入し、情報を表示。
			CharacterExtended reimu = CharacterExtended.Reimu;
			ReimuInfoText.text = reimu.Name + " " + GetLevelString (reimu);

			// Assign a random character Character to a variable and display the information.
			// ランダムなキャラクターのCharacterを変数に代入し、情報を表示。
			CharacterExtended randomCharacter = CharacterExtended.Get (Random.Range (0, CharacterExtended.length));

			// Character is a reference type but is comparable.
			// Characterは参照型ですが比較可能です。
			if (randomCharacter != reimu)
			{
				RandomCharacterInfoText.text = randomCharacter.Name + " " + GetLevelString (randomCharacter);
			}
			else
			{
				RandomCharacterInfoText.text = "";
			}

			// Displays information about the currently selected character.
			// 現在選択されているキャラクターの情報を表示する。
			CharacterNow = CharacterExtended.Get (CharacterIndex);
			IndexText.text = "No." + CharacterNow.ID;
			NameText.text = CharacterNow.FullName;

			// Display different text depending on the current language.
			// 現在の言語に応じて表示するテキストを変える。
			switch (CharacterExtended.SelectedLanguage)
			{
			case SystemLanguage.Japanese:
				SubNameText.text = CharacterNow.Locales.Ja.FullNameKana;
				break;
			case SystemLanguage.English:
			case SystemLanguage.French:
			default:
				SubNameText.text = "";
				break;
			case SystemLanguage.Chinese:
				SubNameText.text = CharacterNow.Locales.En.FullName;
				break;
			}

			// An example of a switch statement using ID. Change the pronoun depending on the character.
			// IDを使ったswitch文の例。キャラクターに応じて代名詞を変える。
			switch (CharacterNow.ID)
			{
			case CharacterExtended.IDsExtended.Ekisya:
			case CharacterExtended.IDsExtended.Genjii:
			case CharacterExtended.IDsExtended.Rinnosuke:
			case CharacterExtended.IDsExtended.Myouren:
			case CharacterExtended.IDsExtended.Youki:
				PronounText.text = "he/him";
				break;
			case CharacterExtended.IDsExtended.Singyoku:
			case CharacterExtended.IDsExtended.Hisoutensoku:
				PronounText.text = "they/them";
				break;
			default:
				PronounText.text = "she/her";
				break;
			}

			PowerText.text = "Power : " + CharacterNow.Power.ToString ();
			LevelText.text = GetLevelString (CharacterNow);

			// An example of a switch statement using String. Change the text color depending on the character.
			// Stringを使ったswitch文の例。キャラクターに応じて文字色を変える。
			switch (CharacterNow.String)
			{
			case CharacterExtended.StringsExtended.Flandre:
			case CharacterExtended.StringsExtended.Koakuma:
			case CharacterExtended.StringsExtended.Meirin:
			case CharacterExtended.StringsExtended.Patchouli:
			case CharacterExtended.StringsExtended.Remilia:
			case CharacterExtended.StringsExtended.Sakuya:
				LevelText.color = Color.red;
				break;
			case CharacterExtended.StringsExtended.Sumireko:
			case CharacterExtended.StringsExtended.Yukari:
				LevelText.color = Color.magenta;
				break;
			default:
				LevelText.color = Color.black;
				break;
			}

			// Gets the sprite and displays it.
			// Spriteを取得して表示する。
			Sprite sprite = Resources.Load<Sprite> ("Pictures/Character/" + CharacterNow.String);
			if (sprite == null)
			{
				// This sample does not come with a character image, so a dummy image will be displayed unless you provide your own image.
				// このサンプルにはキャラクターの画像は付随されていないので、ご自身で画像を用意しない限りはダミーの画像が表示されます。
				CharacterImage.gameObject.SetActive (false);
				DummyCharacterSprite.SetActive (true);
			}
			else
			{
				CharacterImage.gameObject.SetActive (true);
				CharacterImage.sprite = sprite;
				DummyCharacterSprite.SetActive (false);
			}
		}

		/// <summary>
		/// Change the character displayed.
		/// 表示するキャラクターを変える。
		/// </summary>
		/// <param name="addValue"></param>
		public void ChangeCharacterIndex (int addValue)
		{
			CharacterIndex += addValue;
			if (CharacterIndex >= CharacterExtended.length)
			{
				CharacterIndex = 0;
			}
			else if (CharacterIndex < 0)
			{
				CharacterIndex = CharacterExtended.length - 1;
			}
			PlayerPrefs.SetInt (PlayerPrefsKeyPrefix + "Index", CharacterIndex);
			Refresh ();
		}

		/// <summary>
		/// Level up your character and save them.
		/// キャラクターのレベルを上げて保存する。
		/// </summary>
		public void LevelUp ()
		{
			// An example of storing information per character.
			// キャラクターごとに情報を保存する例。
			PlayerPrefs.SetInt (PlayerPrefsKeyPrefix + CharacterNow.String + "_Level", PlayerPrefs.GetInt (PlayerPrefsKeyPrefix + CharacterNow.String + "_Level", 0) + 1);
			Refresh ();
		}

		/// <summary>
		/// Change language.
		/// 言語を変える。
		/// </summary>
		/// <param name="language"></param>
		public void ChangeLanguage (string language)
		{
			Language = language;
			PlayerPrefs.SetString (PlayerPrefsKeyPrefix + "Language", Language);
			CharacterExtended.ChangeLanguage (Language);
			Refresh ();
		}

		/// <summary>
		/// Delete all PlayerPrefs saved in this sample.
		/// このサンプルで保存したPlayerPrefsを全て削除する。
		/// </summary>
		public void ResetPlayerPrefs ()
		{
			PlayerPrefs.DeleteKey (PlayerPrefsKeyPrefix + "Index");
			PlayerPrefs.DeleteKey (PlayerPrefsKeyPrefix + "Language");

			// An example of using a for statement to perform some processing on all characters.
			// for文で全てのキャラクターに対して何かしらの処理をする例。
			for (int i = 0; i < CharacterExtended.length; i++)
			{
				PlayerPrefs.DeleteKey (PlayerPrefsKeyPrefix + CharacterExtended.Get (i).String + "_Level");
			}
			Refresh ();
		}

		/// <summary>
		/// Returns a string indicating the character's level.
		/// キャラクターのレベルの文字列を返す。
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		private string GetLevelString (CharacterExtended character)
		{
			return "Lv : " + PlayerPrefs.GetInt (PlayerPrefsKeyPrefix + character.String + "_Level", 0);
		}
	}
}
