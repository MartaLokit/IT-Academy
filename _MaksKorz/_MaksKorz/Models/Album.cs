using System.ComponentModel.DataAnnotations;

namespace _MaksKorz.Models
{
	public class Album
	{
		public int ID { get; set; }
		public string Name { get; set; }
		[MinLength(4)]
		[Range(2013,2023)]
		public int Year { get; set; }
		public int CountSong { get; set; }
	}
}
