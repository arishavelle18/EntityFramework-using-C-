﻿namespace EFCoreTutorial.Models.Domain
{
    public class StudentAddress
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State {  get; set; }

        //naming convention for foreign key is ParentTableNameId
        public int StudentId { get; set; }

        public Student Student {  get; set; }
    }
}
