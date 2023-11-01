using System;
namespace AppCore.Entities
{
	public class Student
	{
		public Student()
		{
			FullName = FirstName + LastName;
            UniqueId = new Guid();
        }
		public Guid UniqueId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName { get; set; }
		public int Age { get; set; }

	}
	
}

