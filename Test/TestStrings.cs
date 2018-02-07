using Exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
	[TestClass]
	public class TestStrings
	{
		[TestMethod]
		public void Concatenate()
		{
			Strings s = new Strings();

			string s1 = "Prima parte";
			string s2 = "Seconda parte";
			string name = "Nome";
			string surname = "Cognome";

			Assert.AreEqual("Prima parte", s.Capitalize(s1, Strings.CapitalizationModes.FirstLetterOnlyUppercase));
			Assert.AreEqual("Prima Parte", s.Capitalize(s1, Strings.CapitalizationModes.FirstOfEachWordUppercase));
			Assert.AreEqual("PRIMA PARTE", s.Capitalize(s1, Strings.CapitalizationModes.AllUppercase));
			Assert.AreEqual("prima parte", s.Capitalize(s1, Strings.CapitalizationModes.AllLowercase));
			Assert.AreEqual("pRIMA PARTE", s.Capitalize(s1, Strings.CapitalizationModes.Reverse));

			Assert.AreEqual("Nome Cognome", s.FormatName(name, surname));
			Assert.AreEqual("Nome Cognome", s.FormatName(name, surname, Strings.PeopleNameFormats.PlainNameFirst));
			Assert.AreEqual("Cognome, Nome", s.FormatName(name, surname, Strings.PeopleNameFormats.PlainSurnameFirst));
			Assert.AreEqual("Nome COGNOME", s.FormatName(name, surname, Strings.PeopleNameFormats.HighlightNameFirst));
			Assert.AreEqual("COGNOME, Nome", s.FormatName(name, surname, Strings.PeopleNameFormats.HighlightSurnameFirst));

			Assert.AreEqual("Nome Cognome", s.FormatName(name, surname, false, true));
			Assert.AreEqual("Cognome, Nome", s.FormatName(name, surname, false, false));
			Assert.AreEqual("Nome COGNOME", s.FormatName(name, surname, true, true));
			Assert.AreEqual("COGNOME, Nome", s.FormatName(name, surname, true, false));

			Assert.AreEqual("Prima parteSeconda parte", s.Concatenate(s1, s2));
			Assert.AreEqual("Prima parteSeconda parte", s.Concatenate(s1, "", s2));
			Assert.AreEqual("Prima parte, Seconda parte: un'opera di Nome", s.Concatenate(s1, ", ", s2, ": un'opera di ", name));

			Assert.AreEqual("Prima parteSeconda parte", s.Concatenate("", s1, s2));
			Assert.AreEqual("Prima parte Seconda parte", s.Concatenate(" ", s1, s2));
			Assert.AreEqual("Prima parte,Seconda parte", s.Concatenate(",", s1, s2));
			Assert.AreEqual("Prima parte e Seconda parte", s.Concatenate(" e ", s1, s2));
			Assert.AreEqual("Prima parte e Seconda parte e Prima parte", s.Concatenate(" e ", s1, s2, s1));
		}
	}
}
