//
// System.Web.Configuration.UrlMappingsSection
//
// Authors:
//	Chris Toshok (toshok@ximian.com)
//
// (C) 2005 Novell, Inc (http://www.novell.com)
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Configuration;

#if NET_2_0

namespace System.Web.Configuration {

	public sealed class UrlMappingsSection : ConfigurationSection
	{
		static ConfigurationProperty enabledProp;
		static ConfigurationProperty urlMappingsProp;
		static ConfigurationPropertyCollection properties;

		static UrlMappingsSection ()
		{
			enabledProp = new ConfigurationProperty ("enabled", typeof (bool), true);
			urlMappingsProp = new ConfigurationProperty ("", typeof (UrlMappingCollection), null,
								     null, null, ConfigurationPropertyOptions.IsDefaultCollection);
			properties = new ConfigurationPropertyCollection ();

			properties.Add (enabledProp);
			properties.Add (urlMappingsProp);
		}

		[ConfigurationProperty ("enabled", DefaultValue = "True")]
		public bool IsEnabled {
			get { return (bool) base [enabledProp];}
			set { base[enabledProp] = value; }
		}

		[ConfigurationProperty ("", Options = ConfigurationPropertyOptions.IsDefaultCollection)]
		public UrlMappingCollection UrlMappings {
			get { return (UrlMappingCollection) base [urlMappingsProp];}
		}

		protected override ConfigurationPropertyCollection Properties {
			get { return properties; }
		}
	}
}

#endif
