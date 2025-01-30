using UnityEngine;
using UnityEngine.UI;
using TouhouData;

namespace TouhouData.Sample
{
	public class TouhouDataPackageSample : MonoBehaviour
	{
		[SerializeField] private Text ReimuInfoText;
		[SerializeField] private Text RandomCharacterInfoText;
		[SerializeField] private Text IndexText;
		[SerializeField] private Text NameText;
		[SerializeField] private Text SubNameText;
		[SerializeField] private Text PronounText;
		[SerializeField] private Text LevelText;
		[SerializeField] private Image CharacterImage;
		[SerializeField] private GameObject DummyCharacterSprite;

		private Character CharacterNow;
		private int CharacterIndex = 0;
		private string Language = "";

		private const string PlayerPrefsKeyPrefix = "TouhouData_Sample_";

		private void Awake ()
		{
			CharacterIndex = PlayerPrefs.GetInt (PlayerPrefsKeyPrefix + "Index", 0);

			// Set the initial language setting.
			// 言語の初期設定をする。
			Language = PlayerPrefs.GetString (PlayerPrefsKeyPrefix + "Language", "");
			if (!string.IsNullOrEmpty (Language))
			{
				Character.ChangeLanguage (Language);
			}

			Refresh ();
		}

		private void Refresh ()
		{
			// Assign Character of Reimu to a variable and display the information.
			// 霊夢のCharacterを変数に代入し、情報を表示。
			Character reimu = Character.Reimu;
			ReimuInfoText.text = reimu.Name + " " + GetLevelString (reimu);

			// Assign a random character Character to a variable and display the information.
			// ランダムなキャラクターのCharacterを変数に代入し、情報を表示。
			Character randomCharacter = Character.Get (Random.Range (0, Character.length));

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
			CharacterNow = Character.Get (CharacterIndex);
			IndexText.text = "No." + CharacterNow.ID;
			NameText.text = CharacterNow.FullName;

			// Display different text depending on the current language.
			// 現在の言語に応じて表示するテキストを変える。
			switch (Character.SelectedLanguage)
			{
			case SystemLanguage.Japanese:
				SubNameText.text = CharacterNow.Locales.Ja.FullNameKana;
				break;
			case SystemLanguage.English:
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
			case Character.IDs.Ekisya:
			case Character.IDs.Genjii:
			case Character.IDs.Rinnosuke:
				PronounText.text = "he/him";
				break;
			case Character.IDs.Singyoku:
				PronounText.text = "they/them";
				break;
			default:
				PronounText.text = "she/her";
				break;
			}

			LevelText.text = GetLevelString (CharacterNow);

			// An example of a switch statement using String. Change the text color depending on the character.
			// Stringを使ったswitch文の例。キャラクターに応じて文字色を変える。
			switch (CharacterNow.String)
			{
			case Character.Strings.Flandre:
			case Character.Strings.Koakuma:
			case Character.Strings.Meirin:
			case Character.Strings.Patchouli:
			case Character.Strings.Remilia:
			case Character.Strings.Sakuya:
				LevelText.color = Color.red;
				break;
			case Character.Strings.Sumireko:
			case Character.Strings.Yukari:
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
			if (CharacterIndex >= Character.length)
			{
				CharacterIndex = 0;
			}
			else if (CharacterIndex < 0)
			{
				CharacterIndex = Character.length - 1;
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
			Character.ChangeLanguage (Language);
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
			for (int i = 0; i < Character.length; i++)
			{
				PlayerPrefs.DeleteKey (PlayerPrefsKeyPrefix + Character.Get (i).String + "_Level");
			}
			Refresh ();
		}

		/// <summary>
		/// Returns a string indicating the character's level.
		/// キャラクターのレベルの文字列を返す。
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		private string GetLevelString (Character character)
		{
			return "Lv : " + PlayerPrefs.GetInt (PlayerPrefsKeyPrefix + character.String + "_Level", 0);
		}
	}
}
