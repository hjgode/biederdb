using System;
using System.IO;
using System.Collections;

using System.ComponentModel;

using System.IO.IsolatedStorage;
using System.Xml;
using System.Text;

namespace VastAbyss.Configuration
{
	/// <summary>
	/// Persists name/value pairs of settings between application occurances.
	/// </summary>
	/// <remarks>
	/// Implements IDisposable. Calling Dispose() causes the configuration to be saved before closing. Otherwise, SaveConfiguration() must be called manually.
	/// </remarks>
	/// <example>
	/// using System;
	/// using VastAbyss.Configuration;
	/// namespace VastAbyss
	/// {
	///   public class TestClass
	///   {
	///     private const string DEFAULT_DISPLAY_STRING = "Enter something to change this.";
	///     
	///     [STAThread]
	///     static void Main(string[] args)
	///     {
	///       ApplicationSettings appSettings = new ApplicationSettings();
	///       string displayString = appSettings.GetValue("DisplayString");
	///       if (displayString == null)
	///       {
	///         displayString = DEFAULT_DISPLAY_STRING;
	///       }
	///       Console.WriteLine(displayString);
	///       displayString = Console.ReadLine();
	///       appSettings.SetValue("DisplayString", displayString);
	///       appSettings.Dispose();
	///     }
	///   }
	/// }
	/// </example>
	public sealed class ApplicationSettings : IDisposable
	{
		#region Constructors

		/// <summary>
		/// Attempts to open the settings file. If none is found, one is created.
		/// </summary>
		public ApplicationSettings()
		{
			Document = OpenDocument();
		}

		#endregion

		#region Private Properties

		private const string FileName = "BiederDBSettings.XML";
		private const string RootElement = "ApplicationSettings";
		private const string SettingElement = "Setting";
		private const string PathSeperator = "/";

		private XmlDocument Document;

		#endregion

		#region Public Properties

		/// <summary>
		/// Gets the underlying XmlDocument containing the settings.
		/// </summary>
		public XmlDocument XmlDocument
		{
			get
			{
				return Document;
			}
		}

		#endregion

		#region Public Methods

		/// <summary>
		/// Sets the property value of the given property name or creates a new property.
		/// </summary>
		/// <param name="Name">The name of the property to set or create.</param>
		/// <param name="Value">The value to set the property to.</param>
		/// <returns>Returns true if a new property was created, false if the property value was only changed.</returns>
		public bool SetValue(string Name, string Value)
		{
			XmlNodeList nodes = Document.SelectNodes(PathSeperator + RootElement + PathSeperator + SettingElement);
			foreach (XmlNode node in nodes)
			{
				if (node.Attributes["Name"].Value.Equals(Name))
				{
					node.Attributes["Value"].Value = Value;
					return false;
				}
			}
			XmlNode parentNode = Document.SelectSingleNode(PathSeperator + RootElement);
			XmlNode newNode = Document.CreateElement("Setting");
			newNode.Attributes.Append(Document.CreateAttribute("Name"));
			newNode.Attributes.Append(Document.CreateAttribute("Value"));
			newNode.Attributes["Name"].Value = Name;
			newNode.Attributes["Value"].Value = Value;
			parentNode.AppendChild(newNode);
			return true;
		}
        public bool SetValue<T>(string Name, T Value)
        {
            XmlNodeList nodes = Document.SelectNodes(PathSeperator + RootElement + PathSeperator + SettingElement);
            foreach (XmlNode node in nodes)
            {
                if (node.Attributes["Name"].Value.Equals(Name))
                {
                    node.Attributes["Value"].Value = Value.ToString();
                    return false;
                }
            }
            XmlNode parentNode = Document.SelectSingleNode(PathSeperator + RootElement);
            XmlNode newNode = Document.CreateElement("Setting");
            newNode.Attributes.Append(Document.CreateAttribute("Name"));
            newNode.Attributes.Append(Document.CreateAttribute("Value"));
            newNode.Attributes["Name"].Value = Name;
            string s = "";
            if (ConvertFromTToString<T>(out s, Value))
                newNode.Attributes["Value"].Value = s;
            parentNode.AppendChild(newNode);
            return true;
        }
        static private bool ConvertFromStringToT<T>(string s, ref T value)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
            if (!converter.CanConvertFrom(typeof(string)))
            {
                return false;
            }
            value = (T)converter.ConvertFrom(s);
            return true;
        }

        // Adapted from ConvertFromStringToT above
        static private bool ConvertFromTToString<T>(out string s, T value)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
            if (!converter.CanConvertTo(typeof(string)))
            {
                s = "";
                return false;
            }
            s = (string)converter.ConvertToString(value);
            return true;
        }

		/// <summary>
		/// Removes a property from the settings given the name.
		/// </summary>
		/// <param name="Name">The name of the property to remove.</param>
		/// <returns>Returns true if the property was removed, otherwise false.</returns>
		public bool RemoveValue(string Name)
		{
			XmlNodeList nodes = Document.SelectNodes(PathSeperator + RootElement + PathSeperator + SettingElement);
			foreach (XmlNode node in nodes)
			{
				if (node.Attributes["Name"].Value.Equals(Name))
				{
					node.ParentNode.RemoveChild(node);
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Gets the corresponding property value for the given name.
		/// </summary>
		/// <param name="Name">The name of the property to retrieve.</param>
		/// <returns>Returns the value of the property for the given name or null if the property was not found.</returns>
		public string GetValue(string Name)
		{
			XmlNodeList nodes = Document.SelectNodes(PathSeperator + RootElement + PathSeperator + SettingElement);
			foreach (XmlNode node in nodes)
			{
				if (node.Attributes["Name"].Value.Equals(Name))
				{
					return node.Attributes["Value"].Value;
				}
			}
			return null;
		}
		public string GetValue(string Name, string Default)
		{
			XmlNodeList nodes = Document.SelectNodes(PathSeperator + RootElement + PathSeperator + SettingElement);
			foreach (XmlNode node in nodes)
			{
				if (node.Attributes["Name"].Value.Equals(Name))
				{
					return node.Attributes["Value"].Value;
				}
			}
			return Default;
		}
        public T GetValue<T>(string Name, T Default)
        {
			XmlNodeList nodes = Document.SelectNodes(PathSeperator + RootElement + PathSeperator + SettingElement);
			foreach (XmlNode node in nodes)
			{
				if (node.Attributes["Name"].Value.Equals(Name))
				{
                    return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(node.Attributes["Value"].Value);
				}
			}
			return Default;
        }

		/// <summary>
		/// Removes all settings from the configuration.
		/// </summary>
		public void ClearSettings()
		{
			Document = CreateDocument();
		}

		/// <summary>
		/// Retrieves all of the assigned settings.
		/// </summary>
		/// <returns>Returns a hashtable containing name/value pairs of settings.</returns>
		public Hashtable GetSettings()
		{
			XmlNodeList nodes = Document.SelectNodes(PathSeperator + RootElement + PathSeperator + SettingElement);
			Hashtable hTable = new Hashtable(nodes.Count);
			foreach (XmlNode node in nodes)
			{
				hTable.Add(node.Attributes["Name"].Value, node.Attributes["Value"].Value);
			}
			return hTable;
		}

		/// <summary>
		/// Saves the configuration. This is done automatically during disposal.
		/// </summary>
		public void SaveConfiguration()
		{
			SaveDocument(Document, BiederDB3.Utils.AppPath + FileName);
		}

		#endregion

		#region Private Methods

		private static XmlDocument OpenDocument()
		{
			//IsolatedStorageFileStream isfs;
            FileStream fs;
			try
			{
				//isfs = new IsolatedStorageFileStream(BiederDB3.Utils.AppPath + FileName, FileMode.Open, FileAccess.Read);
                fs = new FileStream(BiederDB3.Utils.AppPath + FileName, FileMode.Open, FileAccess.Read);
			}
			catch (FileNotFoundException)
			{
				return CreateDocument();
			}
			XmlDocument doc = new XmlDocument();
			//XmlTextReader reader = new XmlTextReader(isfs);
            XmlTextReader reader = new XmlTextReader(fs);
			doc.Load(reader);
			reader.Close();
			//isfs.Close();
            fs.Close();
			return doc;
		}

		private static XmlDocument CreateDocument()
		{
			XmlDocument doc = new XmlDocument();
			doc.CreateXmlDeclaration("1.0", null, "yes");
			XmlElement rootElement = doc.CreateElement(RootElement);
			doc.AppendChild(rootElement);
			return doc;
		}

		private static void SaveDocument(XmlDocument document, string filename)
		{
			//IsolatedStorageFileStream isfs = new IsolatedStorageFileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            FileStream isfs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
			isfs.SetLength(0);
			XmlTextWriter writer = new XmlTextWriter(isfs, new UnicodeEncoding());
			document.Save(writer);
			writer.Close();
			isfs.Close();
		}

		#endregion

		#region IDisposable Members

		/// <summary>
		/// Saves the settings before the GC disposes the object.
		/// </summary>
		public void Dispose()
		{
			SaveDocument(Document, BiederDB3.Utils.AppPath + FileName);
		}

		#endregion
	}
}
//© Dewey Vozel, 2005