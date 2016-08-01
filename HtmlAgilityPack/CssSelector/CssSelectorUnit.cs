namespace HtmlAgilityPack.CssSelector
{
	class CssSelectorUnit
	{
		/// <summary>
		/// 类型
		/// </summary>
		public CssSelectorType Type { get; set; }

		/// <summary>
		/// 选择器
		/// </summary>
		public string Selector { get; set; }

		/// <summary>
		/// 表达式
		/// </summary>
		public string Expression { get; set; }

		public string Operator { get; set; }

	}
}