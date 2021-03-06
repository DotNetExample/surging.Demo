using MicroService.Core;
using MicroService.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

 namespace MicroService.Entity.Org
 {
	/// <summary>
	/// Organization --实体
	/// </summary>
	public class Organization:Entity<string>
	{
  		//<summary>
		// 
		//<summary>
		[StringLength(64)]
		[Required]
		public string Name { set; get; }
		//<summary>
		// 
		//<summary>
		[StringLength(36)]
		[Required]
		public string ParentId { set; get; }
 
	}
}