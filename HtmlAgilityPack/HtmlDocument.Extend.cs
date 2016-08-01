using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlAgilityPack
{
	using System.Text.RegularExpressions;

	partial class HtmlDocument
	{
		/// <summary>
		/// 获得或设置在解析的时候是否忽略空白文本节点
		/// </summary>
		public bool IgnoreWhiteSpace { get; set; } = true;

		/// <summary>
		/// 根据指定的表达式选择节点
		/// </summary>
		/// <param name="xpath"></param>
		/// <returns></returns>
		public HtmlNodeCollection SelectNodes(string xpath) => DocumentNode.SelectNodes(xpath);

		/// <summary>
		/// 根据指定的表达式选择节点
		/// </summary>
		/// <param name="xpath"></param>
		/// <returns></returns>
		public HtmlNode SelectSingleNode(string xpath) => DocumentNode.SelectSingleNode(xpath);

		/// <summary>
		/// 获得所有的指定标签
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public HtmlNodeCollection GetElementsByTagName(string name) => SelectNodes("//" + name);

		/// <summary>
		/// 获得所有的指定标签
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public HtmlNodeCollection GetElementsByName(string name) => SelectNodes($"//*[@name='{name}']");

		/// <summary>
		/// 测试一个字符串是否全都是空白字符串
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		static bool IsWhiteSpace(string value, int start, int length)
		{
			if (string.IsNullOrEmpty(value))
				return true;

			return Enumerable.Range(start, length).All(s => value[s] == ' ' || value[s] == '\t' || value[s] == '\r' || value[s] == '\n');
		}
	}
}
