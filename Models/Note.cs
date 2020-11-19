using System;
using System.ComponentModel.DataAnnotations;

namespace stickynotes.Models
{
    public class Note
    {
        public int ID { get; set; }
        public string Text { get; set; }
        [DataType(DataType.Date)]
        public DateTime EnterDate { get; set; }
        public int Order { get; set; }
    }
}