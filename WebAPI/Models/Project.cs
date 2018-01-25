﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using WebAPI.Models.Interfaces;

namespace WebAPI.Models
{
	public class Project : ISocial, IDescription
	{
		[Key]
		public Guid Id { get; set; }

		// IDescription Interface
		[Required]
		public string Name { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Icon { get; set; }
		public string Background { get; set; }

		// ISocial Interface
		public string WebsiteUrl { get; set; }
		public string FacebookUrl { get; set; }
		public string TwitterUrl { get; set; }
		public string RepositoryUrl { get; set; }

		public virtual Forum Forum { get; set; } = null;
		[Required]
        public virtual User Owner { get; set; }
        public virtual List<User> Users { get; set; } = new List<User>();

	}
}
