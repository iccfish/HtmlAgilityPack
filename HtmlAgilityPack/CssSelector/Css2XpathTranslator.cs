using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HtmlAgilityPack.CssSelector
{
	class Css2XpathTranslator
	{
		public IEnumerable<string> Parse(string cssSelector)
		{
			var cssSegemnts = cssSelector.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			foreach (var segemnt in cssSegemnts)
			{
				yield return TranslateSingle(segemnt);
			}
		}

		string TranslateSingle(string cssSelector)
		{
			var parts = cssSelector.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

			//   //h1//span[contains(@class, 'sub')]
			var targetPath = new List<string>();

			return null;
		}
	}
}
