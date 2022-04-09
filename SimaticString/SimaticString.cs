using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimaticString
{
	public class SimaticString
	{
		public int Length { get; private set; }

		public int MaxLength { get; }

		private string _strData = "";

		public SimaticString(int maxLength)
		{
			MaxLength = maxLength;
		}

		public SimaticString(SimaticString s)
		{
			_strData = s._strData; //initalizing
			Length = _strData.Length;
			MaxLength = s.MaxLength;
		}
		
		private void SetStringLength()
		{
			Length = _strData.Length;
		}

		public void Set(byte[] s)
		{
			foreach (byte b in s)
			{
				Console.WriteLine(b);
			}
			_strData = Encoding.UTF8.GetString(s);
			SetStringLength();

			Console.WriteLine(_strData);
		}

		public void Set(string s)
		{
			if (s != null && s.Length <= MaxLength)
			{
				_strData = s;
				SetStringLength();
			}
			else
			{
				throw new Exception("Invalid input");
			}
		}

		public void Set(SimaticString s)
		{
			_strData = s.ToString();
			SetStringLength();
		}

		public void Reverse()
		{
			_strData = new string(_strData.Reverse().ToArray());
		}

		public override string ToString()
		{
			return _strData;
		}

		public byte[] GetBytes()
		{
			byte[] bytes = new byte[6];
			bytes[0] = 4;
			bytes[1] = 2;
			bytes[2] = (byte)'A';
			bytes[3] = (byte)'B';
			bytes[4] = 0;
			bytes[5] = 0;


			return bytes;
		}
	}
}
