using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Admin.Models.LoginModels
{
	/// <summary>
	/// Class Tokens
	/// </summary>
	public class Tokens
	{
		/// <summary>
		/// JWT Token
		/// </summary>
		public string Token { get; set; }
		/// <summary>
		/// Refresh Token
		/// </summary>
		public string RefreshToken { get; set; }
	}
}
