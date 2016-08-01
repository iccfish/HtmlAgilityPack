namespace HtmlAgilityPack.CssSelector
{
	using System;
	using System.Linq;
	using System.Text.RegularExpressions;

	class CssSelectorRule
	{
		public CssSelectorUnit[] RuleList { get; private set; }

		private CssSelectorRule()
		{

		}

		public static CssSelectorRule Create(CssSelectorRule prev, string selector)
		{
			var matches = Regex.Matches(selector, @"(([#\.:]?)([a-z\d-_]+)(?:[\(]([^)]*)[\)])?|\[([a-z-_\d]+)([^\w]+)['""]?([^'""]+)['""]?\]|[>~+])", RegexOptions.IgnoreCase);

			var result = new CssSelectorRule();
			result.RuleList = matches.Cast<Match>().Select(s =>
															{
																var unit = new CssSelectorUnit();

																if (s.Groups[2].Success)
																{
																	var identidentity = s.GetGroupValue(2);
																	if (identidentity == ".")
																		unit.Type = CssSelectorType.Class;
																	else if (identidentity == "#")
																		unit.Type = CssSelectorType.Id;
																	else if (identidentity == ":")
																		unit.Type = CssSelectorType.Pseudo;
																	else unit.Type = CssSelectorType.Element;

																	unit.Expression = s.GetGroupValue(4);
																	unit.Selector = s.GetGroupValue(3);
																}
																else
																{
																	unit.Type = CssSelectorType.Attribute;
																	unit.Selector = s.GetGroupValue(5);
																	unit.Operator = s.GetGroupValue(6);
																	unit.Expression = s.GetGroupValue(7);
																}

																return unit;
															}).ToArray();

			return result;
		}
	}
}