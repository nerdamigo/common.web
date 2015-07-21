using NerdAmigo.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Common.Web
{
	public class WebPathMapper : IPathMapper
	{
		public string MapPath(string appRelativePath)
		{
			return System.Web.HttpContext.Current.Request.MapPath(appRelativePath);
		}
	}
}
